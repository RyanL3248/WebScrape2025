using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrape2025
{
    public class ScraperSettings
    {
        public bool ScpText { get; set; }
        public bool ScpImages { get; set; }
        public bool ScpLinks { get; set; }
        public bool ScpQuotes { get; set; }
        public bool ScpStats { get; set; }
        public bool PutTitle { get; set; }
        public bool PutDate { get; set; }
        public bool PutSource { get; set; }
        public bool ParOrg { get; set; }
        public bool ListOrg { get; set; }
        public List<string> Keywords { get; set; }

        // Constructor to initialize all properties
        public ScraperSettings(bool scpText, bool scpImages, bool scpLinks, bool scpQuotes, bool scpStats, bool putTitle, bool putDate, bool putSource, bool parOrg, bool listOrg, List<string> keywords)
        {
            ScpText = scpText;
            ScpImages = scpImages;
            ScpLinks = scpLinks;
            ScpQuotes = scpQuotes;
            ScpStats = scpStats;
            PutTitle = putTitle;
            PutDate = putDate;
            PutSource = putSource;
            ParOrg = parOrg;
            ListOrg = listOrg;
            Keywords = keywords ?? new List<string>();
        }
    }
}
