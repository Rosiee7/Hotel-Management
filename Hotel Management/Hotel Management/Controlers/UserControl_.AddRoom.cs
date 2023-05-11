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
    public partial class userControl1 : UserControl
    {

        DatabaseRequest db = new DatabaseRequest();
        string query;
        public userControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UserControl1_Load(object sender, EventArgs e)
        {
            rooms.Font = new Font("Times", 14);
            query = "select * from rooms";
            DataSet ds = db.getData(query);
            rooms.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void AddBtn(object sender, EventArgs e)
        {
                                  
            if (txtRoomNumber.Text != "" && txtroomPrice.Text != "" && txtRoomType.Text != "" && txtxBathType.Text != "")
            {

                Boolean isFreeroom = true;
                query = "select roomNumber from rooms";
                DataSet ds = db.getData(query);

                var table = ds.Tables[0]; //get first table from Dataset
             
                foreach (DataRow dataRow in table.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        if (item.ToString() == txtRoomNumber.Text)
                            isFreeroom = false;
                    }
                }

            int num = -1;
                if (isFreeroom && (int.TryParse(txtroomPrice.Text, out num))&& (int.TryParse(txtRoomNumber.Text, out num)))
                {
                    String Name = name.Text;
                    String roomType = txtRoomType.Text;
                    String bathType = txtxBathType.Text;
                    Int64 price = Int64.Parse(txtroomPrice.Text);
                    query = "insert into rooms (roomNumber,roomtType,bathType,price) values('" + roomNumber + "','" + roomType + "','" + bathType + "','" + price + "')";
                    db.setData(query, "Room Added");
                    clearAll();
                }
                else
                {
                    if(!isFreeroom)
                        MessageBox.Show("Room Number is not Available", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    else
                        MessageBox.Show("Room Numbr and Price Must be Numaric.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UserControl1_Load(this,null);



        }

        public  void clearAll()
        {
            txtRoomNumber.Clear();
            txtRoomType.SelectedIndex= -1;
            txtxBathType.SelectedIndex = -1;
            txtroomPrice.Clear();

        }

        private void getRooms(object sender, EventArgs e)
        {
           
        }

        private void load_Rooms(object sender, DataGridViewCellEventArgs e)
        {

            UserControl1_Load(this, null);
        }

        private void userControl1_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void userControl1_Enter(object sender, EventArgs e)
        {
            UserControl1_Load(this, null);
        }

        private void rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, LayoutEventArgs e)
        {

        }
    }
}
