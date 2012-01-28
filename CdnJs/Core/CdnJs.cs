using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace CdnJs.Core
{
    public class CdnJs
    {
        /// <summary>
        /// The CdnJs package Url
        /// </summary>
        private const string CdnjsUrl = "http://www.cdnjs.com/packages.json";

        public CdnPackages GetAllPackages()
        {
            WebRequest request = WebRequest.Create(CdnjsUrl);
            Stream response = request.GetResponse().GetResponseStream();

            string jsonResponse;
            using (var sr = new StreamReader(response))
            {
                jsonResponse = sr.ReadToEnd();
            }

            var cdnPackages = JsonConvert.DeserializeObject<CdnPackages>(jsonResponse);

            return cdnPackages;
        }

        public Package GetPackage(string name)
        {
            CdnPackages cdnPackages = GetAllPackages();
            return cdnPackages.Packages.SingleOrDefault(p => p.Name == name);
        }
    }
}