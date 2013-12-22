﻿using System.Web;
using System.Web.SessionState;

namespace AngularJS_ServiceStack_Starter.Web
{
    // taken from StackOverflow answer http://stackoverflow.com/a/9193782/523296
    public class SessionHandlerDecorator : IHttpHandler, IRequiresSessionState
    {
        private IHttpHandler Handler { get; set; }

        internal SessionHandlerDecorator(IHttpHandler handler)
        {
            this.Handler = handler;
        }

        public bool IsReusable
        {
            get { return Handler.IsReusable; }
        }

        public void ProcessRequest(HttpContext context)
        {
            Handler.ProcessRequest(context);
        }
    }
}
