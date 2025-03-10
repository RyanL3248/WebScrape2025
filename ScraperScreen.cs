using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrape2025
{
    public partial class ScraperScreen : Form
    {
        private HomeScreen homeScreenForm;
        public int currentTab;
        public int numTabs;
        public string websiteUrl;
        public string origWebsiteUrl;
        public string websiteUrl2;
        public string origWebsiteUrl2;
        public string websiteUrl3;
        public string origWebsiteUrl3;
        public string websiteUrl4;
        public string origWebsiteUrl4;
        public string websiteUrl5;
        public string origWebsiteUrl5;
        private List<String> websites = new List<String>();
        private bool scpDone;
        public ScraperScreen()
        {
            InitializeComponent();

            this.Load += ScraperScreen_Load;
            this.MinimumSize = new Size(369, 489);
        }

        public ScraperScreen(HomeScreen homeScreen)
        {
            InitializeComponent();
            homeScreenForm = homeScreen;

            this.Load += ScraperScreen_Load;
            this.MinimumSize = new Size(369, 489);
            this.tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        private void ScraperScreen_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            if (Properties.Settings.Default.lastSelectedTab >= 0  && Properties.Settings.Default.lastSelectedTab < this.tabControl1.TabCount)
            {
                this.tabControl1.SelectedIndex = Properties.Settings.Default.lastSelectedTab;
            } 
            else
            {
                this.tabControl1.SelectedIndex = 0;
            }

            this.websiteTxtbox.Text = Properties.Settings.Default.websiteTxt;
            origWebsiteUrl = this.websiteTxtbox.Text;

            this.websiteTxtbox2.Text = Properties.Settings.Default.websiteTxt2;
            origWebsiteUrl2 = this.websiteTxtbox2.Text;

            this.websiteTxtbox3.Text = Properties.Settings.Default.websiteTxt3;
            origWebsiteUrl3 = this.websiteTxtbox3.Text;

            this.websiteTxtbox4.Text = Properties.Settings.Default.websiteTxt4;
            origWebsiteUrl4 = this.websiteTxtbox3.Text;

            this.websiteTxtbox5.Text = Properties.Settings.Default.websiteTxt5;
            origWebsiteUrl5 = this.websiteTxtbox3.Text;

            numTabs = this.tabControl1.TabCount;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastSelectedTab = this.tabControl1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                this.websiteTxtbox.Text = origWebsiteUrl;
                Properties.Settings.Default.websiteTxt = origWebsiteUrl;
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                this.websiteTxtbox2.Text = origWebsiteUrl2;
                Properties.Settings.Default.websiteTxt2 = origWebsiteUrl2;
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                this.websiteTxtbox3.Text = origWebsiteUrl3;
                Properties.Settings.Default.websiteTxt3 = origWebsiteUrl3;
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                this.websiteTxtbox4.Text = origWebsiteUrl4;
                Properties.Settings.Default.websiteTxt4 = origWebsiteUrl4;
            }
            else if (this.tabControl1.SelectedIndex == 4)
            {
                this.websiteTxtbox5.Text = origWebsiteUrl5;
                Properties.Settings.Default.websiteTxt5 = origWebsiteUrl5;
            }

            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Close();
        }

        private void websiteTxtbox_TextChanged(object sender, EventArgs e)
        {
            websiteUrl = this.websiteTxtbox.Text;
        }

        private void websiteTxtbox2_TextChanged(object sender, EventArgs e)
        {
            websiteUrl2 = this.websiteTxtbox2.Text;
        }

        private void websiteTxtbox3_TextChanged(object sender, EventArgs e)
        {
            websiteUrl3 = this.websiteTxtbox3.Text;
        }

        private void websiteTxtbox4_TextChanged(object sender, EventArgs e)
        {
            websiteUrl4 = this.websiteTxtbox4.Text;
        }

        private void websiteTxtbox5_TextChanged(object sender, EventArgs e)
        {
            websiteUrl5 = this.websiteTxtbox5.Text;
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            if (this.tabControl1.SelectedIndex == 0)
            {
                origWebsiteUrl = websiteUrl;
            } 
            else if (this.tabControl1.SelectedIndex == 1)
            {
                origWebsiteUrl2 = websiteUrl2;
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                origWebsiteUrl3 = websiteUrl3;
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                origWebsiteUrl4 = websiteUrl4;
            }
            else if (this.tabControl1.SelectedIndex == 4)
            {
                origWebsiteUrl5 = websiteUrl5;
            }

        }

        private async void scrapeBttn_Click(object sender, EventArgs e)
        {
            // URL to scrape
            string url = this.websiteTxtbox.Text;

            // List of keywords to search for
            var keywords = new List<string> { "outbreak", "dose", "vaccine" };

            // Step 1: Create an instance of the WebScraper to get raw HTML content
            var webScraper = new Scraper(url);
            string htmlContent = await webScraper.ScrapeAsync();  // Scraping HTML content

            // Step 2: Create an instance of ContentExtractor to extract sentences with keywords
            var contentExtractor = new ContentExtractor(new List<string> { "source" });

            // Step 3: Extract the sentences containing the keywords
            List<string> extractedData = new List<string>();

            if (contentExtractor != null)
            {
                if (contentExtractor.contentTypes.Contains("text"))
                {
                    var textContent = contentExtractor.ExtractText(htmlContent);
                    extractedData.AddRange(textContent);
                }

                if (contentExtractor.contentTypes.Contains("links"))
                {
                    var links = contentExtractor.ExtractLinks(htmlContent);
                    extractedData.AddRange(links);
                }

                if (contentExtractor.contentTypes.Contains("statistics"))
                {
                    var statistics = contentExtractor.ExtractStatistics(htmlContent);
                    extractedData.AddRange(statistics);
                }

                if (contentExtractor.contentTypes.Contains("keywords"))
                {
                    var keySentences = contentExtractor.ExtractSentencesAroundKeywords(htmlContent, keywords);
                    extractedData.AddRange(keySentences);
                }

                if (contentExtractor.contentTypes.Contains("images"))
                {
                    var images = contentExtractor.ExtractImages(htmlContent, url);
                    extractedData.AddRange(images);
                }

                if (contentExtractor.contentTypes.Contains("title"))
                {
                    var titles = contentExtractor.ExtractTitle(htmlContent);
                    extractedData.Add(titles);
                }

                if (contentExtractor.contentTypes.Contains("date"))
                {
                    var dates = contentExtractor.ExtractDate(htmlContent);
                    extractedData.Add(dates[0]);
                }

                if (contentExtractor.contentTypes.Contains("source"))
                {
                    var source = contentExtractor.ExtractSource(htmlContent, url);
                    extractedData.Add(source);
                }

                /*if (contentExtractor.contentTypes.Contains("quotes"))
                {
                    var quotes = contentExtractor.ExtractQuotes(htmlContent);
                    extractedData.AddRange(quotes); 
                }*/
            }

            // Step 4: Display the extracted data in the console (or wherever needed)
            DisplayExtractedData(extractedData);
        }

        private void DisplayExtractedData(List<string> data)
        {
            Console.WriteLine("Extracted Data:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
