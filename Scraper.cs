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

        // ScrapeAsync method to fetch HTML content from the URL (#1 HTTP REQUESTS) (#3 AWAIT - ASYNCHRONOUS PROGRAMMING)
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
                        // Attempt to make the GET request
                        var response = await client.GetAsync(url);

                        // Check if the status code indicates success (2xx range)
                        response.EnsureSuccessStatusCode();

                        // Read and return the HTML content as a string
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
                    // Catch any other exceptions (e.g., network issues, invalid URL format)
                    MessageBox.Show($"General error: {ex.Message}");
                    return string.Empty;
                }
            }
            return string.Empty;
        }

    }

}
