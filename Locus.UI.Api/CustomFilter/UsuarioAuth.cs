using Locus.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Locus.UI.Api.CustomFilter
{
    public class UsuarioAuth : AuthorizeAttribute
    {
        public UsuarioAuth()
        {
        }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Thread.CurrentPrincipal = ClaimsPrincipal.Current;
            return base.IsAuthorized(actionContext);
        }

    }
}