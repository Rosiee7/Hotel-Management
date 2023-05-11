
namespace Hotel_Management.Controlers
{
    partial class userControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtroomPrice = new System.Windows.Forms.TextBox();
            this.BathType = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.txtxBathType = new System.Windows.Forms.ComboBox();
            this.rooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(980, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(808, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(810, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Type";
            // 
            // txtRoomType
            // 
            this.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomType.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Items.AddRange(new object[] {
            "Single",
            "Double ",
            "Triple ",
            "Quad",
            "Suite"});
            this.txtRoomType.Location = new System.Drawing.Point(816, 224);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(269, 33);
            this.txtRoomType.TabIndex = 9;
            this.txtRoomType.SelectedIndexChanged += new System.EventHandler(this.getRooms);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(816, 141);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(269, 31);
            this.txtRoomNumber.TabIndex = 11;
            // 
            // txtroomPrice
            // 
            this.txtroomPrice.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomPrice.Location = new System.Drawing.Point(816, 375);
            this.txtroomPrice.Name = "txtroomPrice";
            this.txtroomPrice.Size = new System.Drawing.Size(269, 31);
            this.txtroomPrice.TabIndex = 12;
            // 
            // BathType
            // 
            this.BathType.AutoSize = true;
            this.BathType.BackColor = System.Drawing.Color.Transparent;
            this.BathType.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BathType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BathType.Location = new System.Drawing.Point(810, 267);
            this.BathType.Name = "BathType";
            this.BathType.Size = new System.Drawing.Size(121, 32);
            this.BathType.TabIndex = 7;
            this.BathType.Text = "Bath Type";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Price.Location = new System.Drawing.Point(810, 340);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(66, 32);
            this.Price.TabIndex = 8;
            this.Price.Text = "Price";
            // 
            // txtxBathType
            // 
            this.txtxBathType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtxBathType.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxBathType.FormattingEnabled = true;
            this.txtxBathType.Items.AddRange(new object[] {
            "Alcove tub",
            "Walk in shower",
            "Jacuzzi"});
            this.txtxBathType.Location = new System.Drawing.Point(816, 302);
            this.txtxBathType.Name = "txtxBathType";
            this.txtxBathType.Size = new System.Drawing.Size(269, 33);
            this.txtxBathType.TabIndex = 10;
            // 
            // rooms
            // 
            this.rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rooms.Location = new System.Drawing.Point(41, 72);
            this.rooms.Name = "rooms";
            this.rooms.RowHeadersWidth = 60;
            this.rooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rooms.RowTemplate.Height = 24;
            this.rooms.Size = new System.Drawing.Size(675, 405);
            this.rooms.TabIndex = 14;
            this.rooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rooms_CellContentClick);
            // 
            // userControl1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(36F, 81F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.txtroomPrice);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtxBathType);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.BathType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.Name = "userControl1";
            this.Size = new System.Drawing.Size(1805, 602);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.EnabledChanged += new System.EventHandler(this.UserControl1_Load);
            this.Enter += new System.EventHandler(this.userControl1_Enter);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.UserControl1_Load);
            this.Leave += new System.EventHandler(this.userControl1_Leave);
            this.MouseEnter += new System.EventHandler(this.UserControl1_Load);
            this.Move += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtroomPrice;
        private System.Windows.Forms.Label BathType;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.ComboBox txtxBathType;
        private System.Windows.Forms.DataGridView rooms;
    }
}
