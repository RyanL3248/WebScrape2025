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
        public string websiteUrl;
        public string origWebsiteUrl;
        public string websiteUrl2;
        public string origWebsiteUrl2;
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
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastSelectedTab = this.tabControl1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            this.websiteTxtbox.Text = origWebsiteUrl;
            Properties.Settings.Default.websiteTxt = origWebsiteUrl;

            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Close();
        }

        private void homeBttn2_Click(object sender, EventArgs e)
        {
            this.websiteTxtbox2.Text = origWebsiteUrl2;
            Properties.Settings.Default.websiteTxt2 = origWebsiteUrl2;

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

        private void saveBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            origWebsiteUrl = websiteUrl;
        }

        private void saveBttn2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            origWebsiteUrl2 = websiteUrl2;
        }
    }
}
