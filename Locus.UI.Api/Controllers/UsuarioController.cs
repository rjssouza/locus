using Locus.Dto;
using Locus.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locus.UI.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            this._usuarioServico = usuarioServico;
        }

        [AllowAnonymous]
        public BaseDto Post(UsuarioDto usuarioDto)
        {
            return this._usuarioServico.CadastrarUsuario(usuarioDto);
        }
    }
}
