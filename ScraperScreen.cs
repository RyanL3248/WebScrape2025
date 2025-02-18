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
        public ScraperScreen()
        {
            InitializeComponent();

            this.Load += ScraperScreen_Load;
        }

        private void ScraperScreen_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(489, 601);

            //this.Location = new Point(750, 250);
        }

    }
}
