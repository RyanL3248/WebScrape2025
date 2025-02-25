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
        public string websiteUrl;
        public string origWebsiteUrl;
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
        }

        private void ScraperScreen_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            //this.websiteTxtbox.Text = Properties.Settings.Default.websiteTxt;
            //origWebsiteUrl = this.websiteTxtbox.Text;
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            //this.websiteTxtbox.Text = origWebsiteUrl;
            Properties.Settings.Default.websiteTxt = origWebsiteUrl;

            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Close();
        }


        private void websiteTxtbox_TextChanged(object sender, EventArgs e)
        {
            //websiteUrl = this.websiteTxtbox.Text;
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            origWebsiteUrl = websiteUrl;
        }
    }
}
