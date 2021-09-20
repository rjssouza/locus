using Locus.Dto;
using Locus.Dto.Excecao;
using Locus.Dto.Usuario;
using Locus.Servico.Interface;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace Locus.UI.Api.Identity
{
    public class CustomOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly IUsuarioServico _autenticacaoService;

        public CustomOAuthProvider()
        {
            _autenticacaoService = GlobalConfiguration.Configuration.DependencyResolver.BeginScope().GetService(typeof(IUsuarioServico)) as IUsuarioServico;
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            //Buscando dados do usuário
            //string cpf = context.Scope.First(x => x.Contains("CPF:")).Replace("CPF:", string.Empty);

            Credencial usuarioLogin = new Credencial()
            {
                Username = context.UserName,
                Senha = context.Password
            };

            UsuarioDto usuarioParaLogar = null;

            try
            {
                usuarioParaLogar = _autenticacaoService.ObterUsuarioLogado(usuarioLogin);
            }
            catch (ExcecaoValidacao excecaoValidacao)
            {
                string erro = excecaoValidacao.Mensagem;
                context.SetError("invalid_grant", erro);
                context.Response.StatusCode = HttpStatusCode.Unauthorized.GetHashCode();
                return Task.FromResult<object>(null);
            }

            var ticket = new AuthenticationTicket(SetClaimsIdentity(context, usuarioParaLogar), new AuthenticationProperties());
            context.Validated(ticket);

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.FromResult<object>(null);
        }

        private static ClaimsIdentity SetClaimsIdentity(OAuthGrantResourceOwnerCredentialsContext context, UsuarioDto user)
        {
            var identity = new ClaimsIdentity("JWT");
            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            identity.AddClaim(new Claim("sub", context.UserName));

            identity.AddClaim(new Claim("codigo", user.Codigo.ToString()));

            var userRoles = new List<string>();
            foreach (var role in userRoles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            return identity;
        }
    }
}