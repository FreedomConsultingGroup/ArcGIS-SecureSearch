using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// https://weblog.west-wind.com/posts/2009/Nov/13/Capturing-and-Transforming-ASPNET-Output-with-ResponseFilter
// https://weblog.west-wind.com/posts/2004/Jun/08/Capturing-Output-from-ASPNet-Pages

// Alternatively, intercept incoming requests to the API and wrap the request, write an application that makes a new request and filters the response, then sends that back to the user

namespace SecureSearch
{
    public class SecureSearch : IHttpHandler
    {
        public bool IsReusable { get { return true; } }

        public void ProcessRequest(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}