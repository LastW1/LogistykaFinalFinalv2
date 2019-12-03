using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistyka2_staging_0._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            try
            {
                pictureBox1.ImageLocation = @"graph.png";
            }
            catch (Exception)
            {
                MessageBox.Show("nie załadowano grafu");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
