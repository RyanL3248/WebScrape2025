using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Html.Parser;


namespace WebScrape2025
{
    public class Scraper
    {
        private string url;

        public Scraper(string url)
        {
            this.url = url;
        }

        // ScrapeAsync method to fetch HTML content from the URL
        public async Task<string> ScrapeAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();  // Ensure the request was successful
                string htmlContent = await response.Content.ReadAsStringAsync();
                return htmlContent;  // Return the HTML content as a string
            }
        }
    }

}
