
using Hotel_Management.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Btn(object sender, EventArgs e)
        {

            userControl1_Register11.Visible = true;
            userControl1_Register11.BringToFront();

        }

        private void Add_Room(object sender, EventArgs e)
        {
            
            userControl11.Visible = true;
            userControl11.BringToFront();
            userControl11.Refresh();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            addBtn.PerformClick();


        }

        private void checkOutBtn(object sender, EventArgs e)
        {
            checkOutController2.Visible = true;
            checkOutController2.BringToFront();
        }

        private void checkOutController1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            customerDetailsUserControl11.Visible = true;
            customerDetailsUserControl11.BringToFront();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            userControlEmployee11.Visible = true;
            userControlEmployee11.BringToFront();
        }

        private void userControlEmployee11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
