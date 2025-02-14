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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        private void scraperButton_Click(object sender, EventArgs e)
        {

            ScraperScreen scraperScreen = new ScraperScreen();

            scraperScreen.Show();

            this.Hide();

        }

        private void customizationBttn_Click(object sender, EventArgs e)
        {
            Customization customizationForm = new Customization(this);
            //customizationForm.Location = this.Location;

            customizationForm.Show();

            this.Hide();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
