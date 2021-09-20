using Locus.Dto.Excecao;
using Locus.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http.Filters;

namespace Locus.UI.Api.CustomFilter
{
    public class TratamentoExcecao : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var baseServico = context.ActionContext.RequestContext.Configuration.DependencyResolver.BeginScope().GetService(typeof(IBaseServico)) as IBaseServico;

            _Exception ex;
            switch (context.Exception.GetType().Name)
            {
                case "ExcecaoValidacao":
                    ex = context.Exception as ExcecaoValidacao;
                    context.Response = context.Request.CreateResponse(HttpStatusCode.PreconditionFailed, ex);
                    break;
                default:
                    switch (context.Exception.HResult)
                    {
                        case -2146233079:
                            context.Response = context.Request.CreateResponse(HttpStatusCode.NoContent, context.Exception);
                            break;
                        default:
                            context.Response = context.Request.CreateResponse(HttpStatusCode.BadRequest, context.Exception);
                            break;
                    }
                    break;
            }

            baseServico.Rollback();
        }
    }
}