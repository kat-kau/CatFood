using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatFood
{
    public partial class Result : Form
    {
        public ResourceManager rm = Properties.Resources.ResourceManager;
        public Result()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterInitialParam ip = new EnterInitialParam();
            ip.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Result_Load(object sender, EventArgs e)
        {
                Bitmap myImage = (Bitmap)rm.GetObject("pregnant");
                pictureBox1.Image = myImage;
                label1.Text = "Корм Royal Canin для котят от 1 до 4 мес.и для беременных / лактирующих кошек, Mother & Babycat";
                
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
