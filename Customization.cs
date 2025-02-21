using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrape2025
{
    public partial class Customization : Form
    {

        private HomeScreen homeScreenForm;
        public bool scpTxt;
        public bool txtChecked;
        public bool saveTxt;
        public bool scpImages;
        public bool scpLinks;
        public bool scpQuotes;
        public bool scpStats;
        public bool putTitle;
        public bool putDate;
        public bool putSource;
        public bool parOrg;
        public bool listOrg;

        public Customization()
        {
            InitializeComponent();
            this.MinimumSize = new Size(369, 489);
        }

        public Customization(HomeScreen homeScreen)
        {
            InitializeComponent();
            homeScreenForm = homeScreen;

           this.Load += Customization_Load;
           this.MinimumSize = new Size(369, 489);
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            //TODO
          
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Hide();

            if (saveTxt == false)
            {
                this.txtCbox.Checked = false;
                Properties.Settings.Default.txtCboxState = false;
            }
        }

        private void txtCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpTxt = true;
            txtChecked = true;
        }

        private void imageCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpImages = true;
        }

        private void linksCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpLinks = true;
        }

        private void quotesCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpQuotes = true;
        }

        private void statsCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpStats = true;
        }

        private void titleCbox_CheckedChanged(object sender, EventArgs e)
        {
            putTitle = true;
        }

        private void dateCbox_CheckedChanged(object sender, EventArgs e)
        {
            putDate = true;
        }

        private void sourceCbox_CheckedChanged(object sender, EventArgs e)
        {
            putSource = true;
        }

        private void paragraphCbox_CheckedChanged(object sender, EventArgs e)
        {
            parOrg = true;
        }

        private void listCbox_CheckedChanged(object sender, EventArgs e)
        {
            listOrg = true;
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            if (txtChecked == true)
            {
                saveTxt = true;
                Properties.Settings.Default.Save();
            }
            //txtChecked = true;
            //Properties.Settings.Default.Save();

            //Properties.Settings.Default.imageCboxState = this.imageCbox.Checked;
            //Properties.Settings.Default.Save();

            //Properties.Settings.Default.linksCboxState = this.linksCbox.Checked;
            //Properties.Settings.Default.Save();


        }
    }
}