﻿using System.Web;
using ServiceStack.WebHost.Endpoints;

namespace AngularJS_ServiceStack_Starter.Web
{
    public class SessionHttpHandlerFactory : IHttpHandlerFactory
    {
        private readonly static ServiceStackHttpHandlerFactory factory = new ServiceStackHttpHandlerFactory();

        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            var handler = factory.GetHandler(context, requestType, url, pathTranslated);
            return handler == null ? null : new SessionHandlerDecorator(handler);
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
            factory.ReleaseHandler(handler);
        }
    }
}