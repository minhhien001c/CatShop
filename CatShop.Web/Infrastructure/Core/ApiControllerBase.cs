using CatShop.Model.Models;
using CatShop.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CatShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }
        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;
            try
            {
                response = function.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                //Trace.writeline khi debug se ra cua so output
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type {eve.Entry.Entity.GetType().Name } in state {eve.Entry.State} has the following validation errors.");
                    foreach (var ev in eve.ValidationErrors)
                    {
                        Trace.WriteLine($" _property {ev.PropertyName} , Error {ev.ErrorMessage}");
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return response;
        }
        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                error.CreatedDate = DateTime.Now;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {

            }

        }
    }
}
