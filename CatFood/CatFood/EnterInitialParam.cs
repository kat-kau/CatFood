using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatFood
{
    public partial class EnterInitialParam : Form
    {
        public EnterInitialParam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void EnterInitialParam_Load(object sender, EventArgs e)
        {

        }

        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.age = "";
            if (radioButton1.Checked)
                Properties.Settings.Default.age = "kitten";
            else if (radioButton2.Checked)
                Properties.Settings.Default.age = "middleAge";
            else if (radioButton4.Checked)
                Properties.Settings.Default.age = "elderlyAge";
            else
                MessageBox.Show("Введите возраст кошки!");

            Properties.Settings.Default.progeny = "";
            if (radioButton6.Checked)
                Properties.Settings.Default.progeny = "yes";
            else if (radioButton5.Checked)
                Properties.Settings.Default.progeny = "no";
            else
                MessageBox.Show("Укажите начилие или отсутсвие котят у кошки!");

            if (Properties.Settings.Default.age != "" && Properties.Settings.Default.progeny != "")
            {
                EnterAddParam ad = new EnterAddParam();
                ad.Show(this);
                this.Hide();
            }
        }
    }
}
