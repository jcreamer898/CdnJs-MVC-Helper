using System.Collections.Generic;

namespace CdnJs.Core
{
    public class Package
    {
        public string Name { get; set; }
        public string Filename { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public List<string> Keywords { get; set; }
        public List<Maintainer> Maintainers { get; set; }
        public List<Repository> Repositories { get; set; }
    }
}