using Locus.Dto;
using Locus.Provider.Interface;
using Locus.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locus.Provider
{
    public class ProvedorUsuario : IProvedorUsuario
    {
        private readonly long _codigoUsuario;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ProvedorUsuario(IUsuarioRepositorio usuarioRepositorio)
        {
            var principal = Thread.CurrentPrincipal as ClaimsPrincipal;
            this._usuarioRepositorio = usuarioRepositorio;
            
            if (principal.Claims.Any(x => x.Type.Equals("codigo")))
            {
                _codigoUsuario = Convert.ToInt64(principal.Claims.First(x => x.Type.Equals("codigo")).Value);
            }
        }

        public UsuarioDto UsuarioLogado
        {
            get
            {
                return this._usuarioRepositorio.ObterUsuarioPorCredencial(new Dto.Usuario.Credencial()
                {
                     Codigo = _codigoUsuario
                });
            }
        }
    }
}
