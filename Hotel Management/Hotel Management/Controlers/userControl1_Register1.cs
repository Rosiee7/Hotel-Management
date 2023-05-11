using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Hotel_Management.Controlers
{
    public partial class userControl1_Register1 : UserControl
    {
        DatabaseRequest db = new DatabaseRequest();
        string query;
        String rid;
        public userControl1_Register1()
        {
            InitializeComponent();
        }

        private void UserControl1_Register_Load(object sender, EventArgs e)
        {


        }

        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = db.getDataForComdo(query);
            while (sdr.Read())
            {
                for(int i=0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoomWheneCangeIndex(object sender, EventArgs e)
        {
            txtRoomNum.SelectedIndex = -1;
            txtRoomNum.Items.Clear();
            query = "select roomNumber from rooms where roomtType = '" + txtRoom.Text + "'  and bathType ='" + txtBath.Text + "' and booked='NO' ";
            setComboBox(query, txtRoomNum);
        }

        private void txtBath_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNum.SelectedIndex = -1;
            txtRoomNum.Items.Clear();
            query = "select roomNumber from rooms where roomtType = '" + txtRoom.Text + "'  and bathType ='" + txtBath.Text + "' and booked='NO' ";
            setComboBox(query, txtRoomNum);
        }

        /*show the price of the selected room*/
        private void txtRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceTxt.Text = "";
            if (txtRoomNum.Text != "")
            {
                query = "select price,roomid  from rooms where roomNumber  = '" + txtRoomNum.Text + "'";
                DataSet ds = db.getData(query);
                priceTxt.Text = ds.Tables[0].Rows[0][0].ToString();
                rid = ds.Tables[0].Rows[0][1].ToString();

                /*   
                  var table = ds.Tables[0]; //get first table from Dataset
                  Console.WriteLine(table.Rows.Count);
                     foreach (DataRow dataRow in table.Rows)
                     {
                         foreach (var item in dataRow.ItemArray)
                         {
                             Console.WriteLine(item);
                         }
                     }
                 }
                */


            }
        }

            private void BtnAllocate_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && texLastName.Text!="" && textPhone.Text!=""&& textNationality.Text!="" && txtGender.Text!="" && txtxDob.Text!=""&& textAddress.Text!=""&& txtCheckin.Text!="" && priceTxt.Text != "")
            {
                int num = -1;
                if (int.TryParse(textPhone.Text, out num))

                {

                    String name = txtName.Text;
                    String lastName = texLastName.Text;
                    Int64 phoneNum = Int64.Parse(textPhone.Text);
                    String nation = textNationality.Text;
                    String gender = txtGender.Text;
                    String dob = txtxDob.Text;
                    String idProof = textIDproof.Text;
                    String address = textAddress.Text;
                    String checkout = null;
                    String chckin = txtCheckin.Text;
                    String price = priceTxt.Text;

                    query = "insert into customer (cName,cLastName ,phone,nationality,gender,idProof ,dateOfBirth ,the_address ,checkIn,checkOut ,roomid ) values ( '" + name + "',  '" + lastName + "', '" + phoneNum + "', '" + nation + "', '" + gender + "', '" + idProof + "', '" + dob + "', '" + address + "', '" + chckin + "', '" + checkout + "', '" + rid + "') update rooms set booked ='YES' where roomNumber  ='" + txtRoomNum.Text + "'";
                    db.setData(query, "Room Number " + txtRoomNum.Text + " Allocated Successfully!");
                    clearAll();
                }

                else
                {
                   MessageBox.Show("Phone Must be Numaric.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }



                

            else
            {
                MessageBox.Show("All fields are mandetory.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            texLastName.Clear();
            textPhone.Clear();
            textNationality.Clear();
            txtGender.SelectedIndex=-1;
            txtxDob.ResetText();
            textIDproof.Clear();
            textAddress.Clear();
           // txtxChexkout.ResetText();
            txtCheckin.ResetText();
            priceTxt.Clear();
            txtRoomNum.SelectedIndex = -1;
            txtBath.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            
        }

    }
}
