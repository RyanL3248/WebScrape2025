using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace WebScrape2025
{
    public class ContentExtractor
    {
        public List<string> contentTypes;

        public ContentExtractor(List<string> contentTypes)
        {
            this.contentTypes = contentTypes;
        }

        // Extract text content from <p> tags (#10 - Extract Paragraph Text)
        public List<string> ExtractText(string html)
        {
            var document = ParseHtml(html);
            var paragraphs = document.QuerySelectorAll("p");
            var textContent = new List<string>();

            foreach (var paragraph in paragraphs)
            {
                textContent.Add(paragraph.TextContent.Trim());
            }

            return textContent;
        }

        // Extract title content
        public string ExtractTitle(string html)
        {
            if (string.IsNullOrEmpty(html))
            {
                return null;
            }

            // This regex pattern matches text within h1 tags
            // It's case-insensitive and handles whitespace/attributes in the opening tag
            Regex regex = new Regex(@"<h1[^>]*>(.*?)</h1>", RegexOptions.IgnoreCase | RegexOptions.Singleline);

            Match match = regex.Match(html);

            if (match.Success)
            {
                // Return the content of the h1 tag, trimming any whitespace
                string h1Content = match.Groups[1].Value.Trim();

                // Remove any HTML tags that might be inside the h1
                h1Content = Regex.Replace(h1Content, @"<[^>]+>", string.Empty);

                return h1Content;
            }

            return null;
        }

        // Extract date content (#2 REGEX - VALIDATION)
        public List<string> ExtractDate(string html)
        {
            if (string.IsNullOrEmpty(html))
            {
                return new List<string>();
            }

            List<string> extractedDateStrings = new List<string>();

            // Common date patterns
            var datePatterns = new[]
            {
            // ISO 8601 (yyyy-MM-dd)
            @"\b(\d{4}[-/]\d{1,2}[-/]\d{1,2})\b",
            
            // MM/dd/yyyy or dd/MM/yyyy
            @"\b(\d{1,2}[-/\.]\d{1,2}[-/\.]\d{4})\b",
            
            // Month name, day, year (January 1, 2023 or 1 January 2023)
            @"\b((?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)[a-z]*\.?\s+\d{1,2}(?:st|nd|rd|th)?,?\s+\d{4})\b",
            @"\b(\d{1,2}(?:st|nd|rd|th)?\s+(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)[a-z]*\.?\s+\d{4})\b",
            
            // Full month name
            @"\b((?:January|February|March|April|May|June|July|August|September|October|November|December)\s+\d{1,2}(?:st|nd|rd|th)?,?\s+\d{4})\b",
            @"\b(\d{1,2}(?:st|nd|rd|th)?\s+(?:January|February|March|April|May|June|July|August|September|October|November|December),?\s+\d{4})\b"};

            // Extract date strings
            foreach (var pattern in datePatterns)
            {
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(html);

                foreach (Match match in matches)
                {
                    extractedDateStrings.Add(match.Groups[1].Value);
                }
            }

            // Return unique date strings
            return extractedDateStrings.Distinct().ToList();
        }

        // Method to extract the source of the article (publisher or website name)
        public string ExtractSource(string html, string url)
        {
            var document = ParseHtml(html);

            // Try to find the source in meta tags
            var metaTags = document.QuerySelectorAll("meta");

            // 1. Look for meta tags like og:site_name, twitter:site, or author
            var siteNameMeta = metaTags.FirstOrDefault(m => m.GetAttribute("property") == "og:site_name" || m.GetAttribute("name") == "twitter:site" || m.GetAttribute("name") == "author");
            if (siteNameMeta != null)
            {
                return siteNameMeta.GetAttribute("content");
            }

            // 2. Try to extract the domain name from the URL
            Uri uri = new Uri(url);
            string domain = uri.Host;

            // 3. Check for a <title> tag (sometimes the publisher or site name is in the title)
            var titleTag = document.QuerySelector("title");
            if (titleTag != null)
            {
                string titleText = titleTag.TextContent;

                // Optionally, split the title by common delimiters like "-" or "|" and return the part before it (assuming the publisher is there)
                var parts = titleText.Split(new[] { '-', '|', ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0)
                {
                    return parts[0].Trim(); // Return the first part of the title as the source (publisher)
                }
            }

            // 4. If no source was found, fallback to the domain name
            return domain;
        }

        // Extract links (anchor tags)
        public List<string> ExtractLinks(string html)
        {
            var document = ParseHtml(html);
            var links = document.QuerySelectorAll("a");
            var linkUrls = new List<string>();

            foreach (var link in links)
            {
                linkUrls.Add(link.GetAttribute("href"));
            }

            return linkUrls;
        }

        // Extract image URLs from <img> tags
        public List<string> ExtractImages(string html, string baseUrl)
        {
            var document = ParseHtml(html);

            // Select all <img> tags in the document
            var images = document.QuerySelectorAll("img");

            // List to hold the image URLs
            var imageUrls = new List<string>();

            // Loop through each <img> tag and extract the src attribute
            foreach (var image in images)
            {
                var src = image.GetAttribute("src");  // Get the src attribute (image URL)

                if (!string.IsNullOrEmpty(src))
                {
                    // If the src is a relative URL, prepend the base URL
                    if (!Uri.IsWellFormedUriString(src, UriKind.Absolute))
                    {
                        src = new Uri(new Uri(baseUrl), src).ToString(); // Combine base URL with relative path
                    }

                    // Add the image URL to the list if it's not null or empty
                    imageUrls.Add(src);
                }
            }

            return imageUrls;
        }

        // Method to extract quotes only from <p> tags in the HTML content
        public List<string> ExtractQuotes(string html)
        {
            var document = ParseHtml(html);

            // Select all <p> tags in the document
            var paragraphs = document.QuerySelectorAll("p");

            // Refined regex pattern to find quotes inside double quotes
            var quotePattern = "[\"“”]([^\"“”]+)[\"”]";

            List<string> quotes = new List<string>();

            // Loop through each <p> tag and apply regex to extract quotes
            foreach (var paragraph in paragraphs)
            {
                // Get the text content of the paragraph
                string textContent = paragraph.TextContent;

                // Debugging: Print out the paragraph text content
                Console.WriteLine($"Paragraph content: {textContent}");

                // Use regex to find all quotes in this paragraph
                var matches = Regex.Matches(textContent, quotePattern);

                Console.WriteLine($"Found {matches.Count} quotes in the paragraph.");

                // Extract the quotes and add them to the list
                foreach (Match match in matches)
                {
                    string quote = match.Groups[1].Value.Trim(); // Extract content inside quotes and trim spaces
                    if (!string.IsNullOrWhiteSpace(quote)) // Only add non-empty quotes
                    {
                        quotes.Add(quote);
                    }
                }
            }

            return quotes;
        }

        // Extract numbers (statistics) from <p> tags using regex
        public List<string> ExtractStatistics(string html)
        {
            var document = ParseHtml(html);

            // Select all <p> tags in the document
            var paragraphs = document.QuerySelectorAll("p");

            // List to hold numbers found in <p> tags
            var numbers = new List<string>();

            // Loop through each paragraph and extract numbers
            foreach (var paragraph in paragraphs)
            {
                var paragraphText = paragraph.TextContent;  // Get the text content of the paragraph
                var numbersInParagraph = ExtractNumbersFromText(paragraphText);  // Extract numbers from the paragraph text

                // Add found numbers to the list
                numbers.AddRange(numbersInParagraph);
            }

            return numbers;
        }

        // Helper method to extract numbers from text using regex, keeping symbols like $, %, etc.
        private List<string> ExtractNumbersFromText(string text)
        {
            // Regular expression to match numbers (including decimals, negative numbers, and symbols like $, %, etc.)
            var numberPattern = @"-?\$?\d{1,3}(?:,\d{3})*(\.\d+)?%?";

            var matches = Regex.Matches(text, numberPattern);
            var numbers = matches.Cast<Match>().Select(m => m.Value).ToList();

            return numbers;
        }

        // Extract sentences around given keywords from <p> tags
        public List<string> ExtractSentencesAroundKeywords(string html, List<string> keywords)
        {
            var document = ParseHtml(html);

            // Select all <p> tags in the document
            var paragraphs = document.QuerySelectorAll("p");

            // List to hold sentences containing keywords
            var sentencesWithKeywords = new List<string>();

            // Loop through each paragraph and process text
            foreach (var paragraph in paragraphs)
            {
                var paragraphText = paragraph.TextContent;  // Get the text content of the paragraph
                var sentences = SplitIntoSentences(paragraphText);  // Split paragraph into sentences

                // Loop through each sentence and check for keywords
                foreach (var sentence in sentences)
                {
                    // Check if any keyword is found in the sentence (case-insensitive)
                    if (keywords.Any(keyword => sentence.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        sentencesWithKeywords.Add(sentence.Trim());
                    }
                }
            }

            return sentencesWithKeywords;
        }

        // Helper method to split the text into sentences (simple punctuation-based splitting)
        private List<string> SplitIntoSentences(string text)
        {
            // A simple regex to split by common sentence-ending punctuation marks (period, exclamation, question mark)
            var sentenceEndings = @"(?<=[.!?])\s+";
            var sentences = Regex.Split(text, sentenceEndings)
                                 .Where(sentence => !string.IsNullOrWhiteSpace(sentence))
                                 .Select(sentence => sentence.Trim())
                                 .ToList();

            return sentences;
        }

        // Parse HTML content using AngleSharp (#9 - Parsing HTML w/ Error Handling)
        private IHtmlDocument ParseHtml(string html) 
        {
            try
            {
                var config = Configuration.Default.WithDefaultLoader();
                var document = BrowsingContext.New(config).OpenAsync(req => req.Content(html)).Result;
                return (IHtmlDocument)document;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing HTML: {ex.Message}");
                return null;
            }
        }
    }

}
