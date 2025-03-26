using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
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
        public async Task<string> ScrapeAsync(int maxRetries)
        {
            int attempt = 0;
            string htmlContent = string.Empty;
            
            while (attempt < maxRetries)
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(url);

                        response.EnsureSuccessStatusCode();

                        htmlContent = await response.Content.ReadAsStringAsync();
                        return htmlContent;
                    }
                }
                catch (HttpRequestException ex)
                {
                    attempt++;
                    MessageBox.Show($"Attempt {attempt} failed: {ex.Message}");
                    if (attempt >= maxRetries)
                    {
                        MessageBox.Show("Max retry attempts reached.");
                        return string.Empty;
                    }
                    await Task.Delay(2000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General error: {ex.Message}");
                    return string.Empty;
                }
            }
            return string.Empty;
        }

    }

}
