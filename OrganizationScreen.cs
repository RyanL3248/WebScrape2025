using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace WebScrape2025
{
    public partial class OrganizationScreen: Form
    {
        private ScraperScreen scraperScreenForm;
        public OrganizationScreen(ScraperScreen scraperScreen, List<string> extractedData1)
        {
            InitializeComponent();

   
            this.MinimumSize = new Size(369, 489);
            this.scraperScreenForm = scraperScreen;

            showData(extractedData1);   

        }

   



    

        private void scraperBttn_Click(object sender, EventArgs e)
        {
            scraperScreenForm.Location = this.Location;
            scraperScreenForm.Show();

            this.Hide();
        }

        private void showData(List<string> exData1)
        {
            try
            {
                this.richTextBox1.Text = "";
                if (exData1 == null)
                {
                    throw new ArgumentNullException("exData1", "Data source is null.");
                }
                foreach (string data in exData1)
                {
                    this.richTextBox1.Text += data + "\n";
                }
            }
            catch (ArgumentNullException ex)
            {
                //MessageBox.Show("Please scrape data first." );
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please scrape data first.");
            }

        }   

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }
    }
}
