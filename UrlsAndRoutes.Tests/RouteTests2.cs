using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Collections.Specialized;
using System.Web.Routing;

namespace UrlsAndRoutes.Tests
{
    public class StubHttpContextForRouting : HttpContextBase
    {
        StubHttpRequestForRouting _request;
        StubHttpResponseForRouting _response;

        public StubHttpContextForRouting(string appPath = "/", string requestUrl = "~/")
        {
            _request = new StubHttpRequestForRouting(appPath, requestUrl);
            _response = new StubHttpResponseForRouting();
        }

        public override HttpRequestBase Request
        {
            get { return _request; }
        }

        public override HttpResponseBase Response
        {
            get { return _response; }
        }
    }

    public class StubHttpRequestForRouting : HttpRequestBase
    {
        string _appPath;
        string _requestUrl;

        public StubHttpRequestForRouting(string appPath, string requestUrl)
        {
            _appPath = appPath;
            _requestUrl = requestUrl;
        }

        public override string ApplicationPath
        {
            get { return _appPath; }
        }

        public override string AppRelativeCurrentExecutionFilePath
        {
            get { return _requestUrl; }
        }

        public override string PathInfo
        {
            get { return ""; }
        }

        public override NameValueCollection ServerVariables
        {
            get { return new NameValueCollection(); }
        }
    }

    public class StubHttpResponseForRouting : HttpResponseBase
    {
        public override string ApplyAppPathModifier(string virtualPath)
        {
            return virtualPath;
        }
    }

    [TestClass]
    public class RouteTests2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new StubHttpContextForRouting(requestUrl: "~/Admin1");
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            // Act
            RouteData routeData = routes.GetRouteData(context);

            // Assert
            Assert.IsNull(routeData);
        }
    }
}
