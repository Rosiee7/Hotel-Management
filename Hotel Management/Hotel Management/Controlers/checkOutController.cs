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
    public partial class checkOutController : UserControl
    {
        DatabaseRequest db = new DatabaseRequest();
        string query;
        public checkOutController()
        {
            InitializeComponent();
        }

        private void checkOutController_Load(object sender, EventArgs e)
        {
            query = "select customer.cName, customer.cLastName ,customer.phone, customer.nationality, customer.gender, customer.idProof ,customer.dateOfBirth ,customer.the_address ,customer.checkIn, customer.checkOut,customer.cOut ,rooms.roomNumber, rooms.roomtType ,rooms.bathType, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cOut='NO'";
            DataSet ds = db.getData(query);
            customerCheckout.DataSource = ds.Tables[0];

        }

        private void textIName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cName, customer.cLastName ,customer.phone, customer.nationality, customer.gender, customer.idProof ,customer.dateOfBirth ,customer.the_address ,customer.checkIn, customer.checkOut,customer.cOut ,rooms.roomNumber, rooms.roomtType ,rooms.bathType, rooms.price from customer join rooms on customer.roomid = rooms.roomid where cName like '" + textIName.Text+"%' and cOut='NO'";
            DataSet ds = db.getData(query);
            customerCheckout.DataSource = ds.Tables[0];

        }
        int id;
        private void customerCheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(customerCheckout.Rows[e.RowIndex].Cells[0].Value.ToString());
            textName.Text = customerCheckout.Rows[e.RowIndex].Cells[1].Value.ToString();
            textroomNumber.Text = customerCheckout.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void btnCehckOut_Click(object sender, EventArgs e)
        {
            if (textName.Text != "")
            {

                DialogResult result = MessageBox.Show("Are you sure?.", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
              
                {
                    String cdate = dateTimePicker1.Text;
                    query = "update customer set cOut ='YES',checkOut ='"+ dateTimePicker1.Text + "' where cid ='"+id+ "' update rooms set booked='NO' where roomNumber='"+ textroomNumber.Text+"'";
                    db.setData(query, "Checkout Successfully.");
                    checkOutController_Load(this,null);
                    clearAll();
                }

            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void clearAll()
        {
            textIName.Clear();
            textName.Clear();
            textroomNumber.Clear();
            dateTimePicker1.ResetText();
        }

        private void checkOutController_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
