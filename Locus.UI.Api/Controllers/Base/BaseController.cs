using Locus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locus.UI.Api.Controllers
{
    public class BaseController : ApiController
    {
        public BaseController()
        {
        }

        protected UsuarioDto UsuarioLogado { get; set; }
    }
}
