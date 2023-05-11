using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.Controlers
{
    public partial class UserControlEmployee1 : UserControl
    {
        DatabaseRequest db = new DatabaseRequest();
        string query;
        public UserControlEmployee1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void UserControlEmployee1_Load(object sender, EventArgs e)
        {
            getmaxID();

        }


        public void getmaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = db.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelIDD.Text = (num + 1).ToString();
            }
        }

        private void button1_Click_Register(object sender, EventArgs e)
        {
            if (Nametxt.Text!="" && LastNametxt.Text != "" && phonetxt.Text!=""&& txtGender.Text!=""&&emailtxt.Text!=""&&usertxt.Text!=""&&passtxt.Text!="")
            {
                String name = Nametxt.Text;
                String lname = LastNametxt.Text;
                String phone = phonetxt.Text;
                String gender = txtGender.Text;
                String email = emailtxt.Text;
                String user = usertxt.Text;
                String pass = passtxt.Text;

                query = "insert into employee(ename,ellastName ,phone,gender,emailid ,username ,pass ) values('" + name + "',  '" + lname + "', '" + phone + "', '" + gender + "',  '" + email + "', '" + user + "', '" + pass + "')";
                db.setData(query,"Employee Registered.");
                clearAll();
                getmaxID();
            }
            else
            {
                MessageBox.Show("All fields are mandetory.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void clearAll()
        {
            Nametxt.Clear();
           LastNametxt.Clear();
           phonetxt.Clear();
           txtGender.SelectedIndex = -1;
           emailtxt.Clear();
           usertxt.Clear();
           passtxt.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                query = "select * from employee";
                DataSet ds = db.getData(query);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = db.getData(query);
                dataGridView3.DataSource = ds.Tables[0];

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labelId.Text!="")
            {
                DialogResult result =MessageBox.Show("Are you sure?.", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ;
                
                if (result == DialogResult.Yes)
                {
                    query = "delete from employee where eid =" + labelId.Text + "";
                    db.setData(query, "Record Deleated");
                    tabControl1_SelectedIndexChanged(this, null);

                }
            }
            
        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
