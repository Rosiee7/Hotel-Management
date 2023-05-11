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

    public partial class customerDetailsUserControl1 : UserControl
    {
        DatabaseRequest db = new DatabaseRequest();
        string query;
        public customerDetailsUserControl1()
        {
            InitializeComponent();
        }

        private void customerDetailsUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textSearch.SelectedIndex == 0)
            {
                query = "select customer.cid, customer.cName, customer.cLastName ,customer.phone, customer.nationality, customer.gender, customer.idProof ,customer.dateOfBirth ,customer.the_address ,customer.checkIn, customer.checkOut,customer.cOut ,rooms.roomNumber, rooms.roomtType ,rooms.bathType, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid";
                DataSet ds = db.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }

            else
                if (textSearch.SelectedIndex == 1)
            {
                query = "select customer.cid, customer.cName, customer.cLastName ,customer.phone, customer.nationality, customer.gender, customer.idProof ,customer.dateOfBirth ,customer.the_address ,customer.checkIn, customer.checkOut,customer.cOut ,rooms.roomNumber, rooms.roomtType ,rooms.bathType, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cOut='NO'";
                DataSet ds = db.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }


            else
                if (textSearch.SelectedIndex == 2)
            {
                query = "select customer.cid, customer.cName, customer.cLastName ,customer.phone, customer.nationality, customer.gender, customer.idProof ,customer.dateOfBirth ,customer.the_address ,customer.checkIn, customer.checkOut,customer.cOut ,rooms.roomNumber, rooms.roomtType ,rooms.bathType, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cOut='YES'";
                DataSet ds = db.getData(query);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}
