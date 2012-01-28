using System;
using System.Web.Mvc;

namespace CdnJs.Helpers
{
    /// <summary>
    /// CdnJsHelper for loading JS files from CdnJs
    /// </summary>
    public static class CdnJsHelper
    {   
        /// <summary>
        /// The main url for building script file locations
        /// </summary>
        private const string BaseScriptUrl = "http://cdnjs.cloudflare.com/ajax/libs/{0}/{1}/{2}";

        /// <summary>
        /// Load a script file and return it as an html string
        /// </summary>
        /// <param name="script">The name of the script to load</param>
        /// <returns>An MvcHtmlString of containing the requested script</returns>
        public static MvcHtmlString LoadScript(string script)
        {
            var package = new Core.CdnJs().GetPackage(script);

            if(package != null)
            {
                return new MvcHtmlString(@"<script src=""" + string.Format(BaseScriptUrl, package.Name, package.Version, package.Filename)  + @"""></script>");    
            }
            
            return new MvcHtmlString(string.Empty);
        }
    }
}