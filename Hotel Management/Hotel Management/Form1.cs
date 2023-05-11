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
    public partial class Form1 : Form
    {
        DatabaseRequest db = new DatabaseRequest();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserText(object sender, EventArgs e)
        {
            
        }

        private void login(object sender, EventArgs e)
        {
            query = "select username ,pass from employee where username='" + userText.Text + "' and pass='" + passText.Text + "'";
            DataSet ds = db.getData(query);

           //if ((userText.Text=="Admin") && (passText.Text=="Admin")) {

            if (ds.Tables[0].Rows.Count!=0) { 
                labelErr.Visible = false;

                Dashboard da =new Dashboard();
                this.Hide();
                da.Show();
            }
           else
            {
                labelErr.Visible=true;
                passText.Clear();
                
           }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
