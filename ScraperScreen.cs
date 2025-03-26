using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
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
        private List<string> customizations = new List<string>();
        public List<string> extractedData1;
        public List<string> extractedData2;
        public List<string> extractedData3;
        public List<string> extractedData4;
        public List<string> extractedData5;
        public List<string> extractedData6;
        private bool scpDone;
        public string url;
        private ScraperSettings settings;
        public ScraperScreen()
        {
            InitializeComponent();

            this.Load += ScraperScreen_Load;
            this.MinimumSize = new Size(369, 489);
        }

        public ScraperScreen(HomeScreen homeScreen, ScraperSettings settings)
        {
            InitializeComponent();
            homeScreenForm = homeScreen;

            this.Load += ScraperScreen_Load;
            this.MinimumSize = new Size(369, 489);
            this.tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            this.settings = settings;
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

            //MessageBox.Show("This ScpText: " + settings.ScpText.ToString());
            //MessageBox.Show("First word in keywords: " + settings.Keywords[0]);

            if (settings.ScpText && settings.Keywords.Count == 0)
            {
                customizations.Add("text");
            }
            if (settings.ScpText && settings.Keywords.Count > 0)
            {
                customizations.Add("keywords");
            }
            if (settings.ScpImages)
            {
                customizations.Add("images");
            }
            if (settings.ScpLinks)
            {
                customizations.Add("links");
            }
            if (settings.ScpStats)
            {
                customizations.Add("statistics");
            }
            if (settings.ScpQuotes)
            {
                customizations.Add("quotes");
            }
            if (settings.PutTitle)
            {
                customizations.Add("title");
            }
            if (settings.PutDate)
            {
                customizations.Add("date");
            }
            if (settings.PutSource)
            {
                customizations.Add("source");
            }
            if (settings.ParOrg)
            {
                customizations.Add("paragraphs");
            }
            if (settings.ListOrg)
            {
                customizations.Add("lists");
            }

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

            if (this.tabControl1.SelectedIndex == 0)
            {
                url = this.websiteTxtbox.Text;
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                url = this.websiteTxtbox2.Text;
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                url = this.websiteTxtbox3.Text;
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                url = this.websiteTxtbox4.Text;
            }
            else if (this.tabControl1.SelectedIndex == 4)
            {
                url = this.websiteTxtbox5.Text;
            }

            // List of keywords to search for
            var keywords = new List<string> { "outbreak", "dose", "vaccine" };

            // Step 1: Create an instance of the WebScraper to get raw HTML content
            var webScraper = new Scraper(url);
            string htmlContent = await webScraper.ScrapeAsync(3);  // Scraping HTML content

            // Step 2: Create an instance of ContentExtractor to extract sentences with keywords
            //var contentExtractor = new ContentExtractor(new List<string> { "images" });
            var contentExtractor = new ContentExtractor(customizations);

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
                    var keySentences = contentExtractor.ExtractSentencesAroundKeywords(htmlContent, settings.Keywords);
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

                if (contentExtractor.contentTypes.Contains("quotes"))
                {
                    var quotes = contentExtractor.ExtractQuotes(htmlContent);
                    extractedData.AddRange(quotes); 
                }
            }

            if (this.tabControl1.SelectedIndex == 0)
            {
                extractedData1 = extractedData; 
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                extractedData2 = extractedData;
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                extractedData3 = extractedData;
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                extractedData4 = extractedData;
            }
            else if (this.tabControl1.SelectedIndex == 4)
            {
                extractedData5 = extractedData;
            }

            // Step 4: Display the extracted data in the console (or wherever needed)
            //DisplayExtractedData(extractedData);
        }

        private void DisplayExtractedData(List<string> data)
        {
            Console.WriteLine("Extracted Data:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        private void downloadBttn_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Select desired file type for export. \n (1) PDF (2) RTF (3) TXT (4) JSON \n Enter number next to desired file type:", "Export Extracted Data", "Enter a single digit number");
            string userInput2 = Interaction.InputBox("Enter the filepath name: ", "Designate FilePath", "Enter FilePath");
            DataExporter dataExp = new DataExporter();

            if (this.tabControl1.SelectedIndex == 0)
            {
                if (userInput == "1")
                {
                    dataExp.ExportToPdf(extractedData1, userInput2);
                }
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                if (userInput == "1")
                {
                    dataExp.ExportToPdf(extractedData1, userInput2);
                }
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                if (userInput == "1")
                {
                    dataExp.ExportToPdf(extractedData1, userInput2);
                }
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                if (userInput == "1")
                {
                    dataExp.ExportToPdf(extractedData1, userInput2);
                }
            }
            else if (this.tabControl1.SelectedIndex == 4)
            {
                if (userInput == "1")
                {
                    dataExp.ExportToPdf(extractedData1, userInput2);
                }
            }
        }

        private void orgBttn_Click(object sender, EventArgs e)
        {
            OrganizationScreen organizationScreen = new OrganizationScreen(this, extractedData1);
            organizationScreen.Location = this.Location;
            organizationScreen.Show();
            this.Hide();
        }

        private void wordBttn5_Click(object sender, EventArgs e)
        {
            DataExporter dataExporter = new DataExporter();
            string userInput = Interaction.InputBox("Enter the filepath name: ", "Designate FilePath", "Enter FilePath");

            if (this.tabControl1.SelectedIndex == 0)
            {
                dataExporter.ExportToWord(userInput, extractedData1);
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                dataExporter.ExportToWord(userInput, extractedData2);
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                dataExporter.ExportToWord(userInput, extractedData3);
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                dataExporter.ExportToWord(userInput, extractedData4);
            }
            else if (this.tabControl1.SelectedIndex == 4)
            {
                dataExporter.ExportToWord(userInput, extractedData5);
            }
        }

        private void orgBttn2_Click(object sender, EventArgs e)
        {
            OrganizationScreen organizationScreen = new OrganizationScreen(this, extractedData2);
            organizationScreen.Location = this.Location;
            organizationScreen.Show();
            this.Hide();
        }
    }
}
