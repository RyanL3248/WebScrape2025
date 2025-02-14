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
    public partial class Customization : Form
    {

        private HomeScreen homeScreenForm;
        public Customization()
        {
            InitializeComponent();
        }

        public Customization(HomeScreen homeScreen)
        {
            InitializeComponent();
            homeScreenForm = homeScreen;
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Close();
        }
    }
}
