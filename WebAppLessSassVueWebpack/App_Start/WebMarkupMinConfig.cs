using System.Collections.Generic;
using WebMarkupMin.AspNet.Common;
using WebMarkupMin.AspNet.Common.Compressors;
using WebMarkupMin.AspNet.Common.UrlMatchers;
using WebMarkupMin.AspNet4.Common;
using WebMarkupMin.Core;

namespace WebAppVueWebpack
{
    public class WebMarkupMinConfig
    {
        public static void Configure(WebMarkupMinConfiguration configuration)
        {
            configuration.AllowMinificationInDebugMode = false;
            configuration.AllowCompressionInDebugMode = false;            

            IHtmlMinificationManager htmlMinificationManager =HtmlMinificationManager.Current;
            htmlMinificationManager.ExcludedPages = new List<IUrlMatcher>
            {
                new WildcardUrlMatcher("/minifiers/x*ml-minifier"),
                //new ExactUrlMatcher("/contact")
            };
            HtmlMinificationSettings htmlMinificationSettings = htmlMinificationManager.MinificationSettings;
            htmlMinificationSettings.RemoveHtmlComments = true;
            htmlMinificationSettings.RemoveHtmlCommentsFromScriptsAndStyles = true;
            htmlMinificationSettings.RemoveRedundantAttributes = false;
            htmlMinificationSettings.RemoveHttpProtocolFromAttributes = false;
            htmlMinificationSettings.RemoveHttpsProtocolFromAttributes = false;
            //htmlMinificationManager.CssMinifierFactory = new MsAjaxCssMinifierFactory();
            //htmlMinificationManager.JsMinifierFactory = new MsAjaxJsMinifierFactory();

            IXhtmlMinificationManager xhtmlMinificationManager = XhtmlMinificationManager.Current;
            xhtmlMinificationManager.IncludedPages = new List<IUrlMatcher>
            {
                new WildcardUrlMatcher("/minifiers/x*ml-minifier"),
                //new ExactUrlMatcher("/contact")
            };
            XhtmlMinificationSettings xhtmlMinificationSettings = xhtmlMinificationManager.MinificationSettings;
            htmlMinificationSettings.RemoveHtmlComments = true;
            htmlMinificationSettings.RemoveHtmlCommentsFromScriptsAndStyles = true;
            xhtmlMinificationSettings.RemoveRedundantAttributes = false;
            xhtmlMinificationSettings.RemoveHttpProtocolFromAttributes = false;
            xhtmlMinificationSettings.RemoveHttpsProtocolFromAttributes = false;
            //xhtmlMinificationManager.CssMinifierFactory = new YuiCssMinifierFactory();
            //xhtmlMinificationManager.JsMinifierFactory = new YuiJsMinifierFactory();

            IXmlMinificationManager xmlMinificationManager = XmlMinificationManager.Current;
            XmlMinificationSettings xmlMinificationSettings = xmlMinificationManager.MinificationSettings;
            xmlMinificationSettings.CollapseTagsWithoutContent = false;

            IHttpCompressionManager httpCompressionManager = HttpCompressionManager.Current;
            httpCompressionManager.CompressorFactories = new List<ICompressorFactory>
            {
                new DeflateCompressorFactory(),
                new GZipCompressorFactory()
            };
        }
    }
}