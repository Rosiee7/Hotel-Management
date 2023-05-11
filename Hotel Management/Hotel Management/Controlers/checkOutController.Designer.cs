
namespace Hotel_Management.Controlers
{
    partial class checkOutController
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textIName = new System.Windows.Forms.TextBox();
            this.customerCheckout = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.בNשצק = new System.Windows.Forms.Label();
            this.textroomNumber = new System.Windows.Forms.TextBox();
            this.roomNum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCehckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Check Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(441, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name";
            // 
            // textIName
            // 
            this.textIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIName.Location = new System.Drawing.Point(447, 122);
            this.textIName.Name = "textIName";
            this.textIName.Size = new System.Drawing.Size(264, 28);
            this.textIName.TabIndex = 21;
            this.textIName.TextChanged += new System.EventHandler(this.textIName_TextChanged);
            // 
            // customerCheckout
            // 
            this.customerCheckout.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerCheckout.GridColor = System.Drawing.SystemColors.ControlLight;
            this.customerCheckout.Location = new System.Drawing.Point(21, 186);
            this.customerCheckout.Name = "customerCheckout";
            this.customerCheckout.RowHeadersWidth = 51;
            this.customerCheckout.RowTemplate.Height = 24;
            this.customerCheckout.Size = new System.Drawing.Size(1247, 245);
            this.customerCheckout.TabIndex = 22;
            this.customerCheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerCheckout_CellContentClick);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(42, 473);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(264, 28);
            this.textName.TabIndex = 24;
            // 
            // בNשצק
            // 
            this.בNשצק.AutoSize = true;
            this.בNשצק.BackColor = System.Drawing.Color.Transparent;
            this.בNשצק.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.בNשצק.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.בNשצק.Location = new System.Drawing.Point(36, 438);
            this.בNשצק.Name = "בNשצק";
            this.בNשצק.Size = new System.Drawing.Size(79, 32);
            this.בNשצק.TabIndex = 23;
            this.בNשצק.Text = "Name";
            // 
            // textroomNumber
            // 
            this.textroomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textroomNumber.Location = new System.Drawing.Point(336, 473);
            this.textroomNumber.Name = "textroomNumber";
            this.textroomNumber.Size = new System.Drawing.Size(264, 28);
            this.textroomNumber.TabIndex = 26;
            // 
            // roomNum
            // 
            this.roomNum.AutoSize = true;
            this.roomNum.BackColor = System.Drawing.Color.Transparent;
            this.roomNum.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomNum.Location = new System.Drawing.Point(330, 438);
            this.roomNum.Name = "roomNum";
            this.roomNum.Size = new System.Drawing.Size(172, 32);
            this.roomNum.TabIndex = 25;
            this.roomNum.Text = "Room Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(708, 473);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // btnCehckOut
            // 
            this.btnCehckOut.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCehckOut.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCehckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCehckOut.Location = new System.Drawing.Point(1012, 444);
            this.btnCehckOut.Name = "btnCehckOut";
            this.btnCehckOut.Size = new System.Drawing.Size(161, 77);
            this.btnCehckOut.TabIndex = 29;
            this.btnCehckOut.Text = "Check Out";
            this.btnCehckOut.UseVisualStyleBackColor = false;
            this.btnCehckOut.Click += new System.EventHandler(this.btnCehckOut_Click);
            // 
            // checkOutController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCehckOut);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textroomNumber);
            this.Controls.Add(this.roomNum);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.בNשצק);
            this.Controls.Add(this.customerCheckout);
            this.Controls.Add(this.textIName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "checkOutController";
            this.Size = new System.Drawing.Size(1290, 656);
            this.Load += new System.EventHandler(this.checkOutController_Load);
            this.Leave += new System.EventHandler(this.checkOutController_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.customerCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textIName;
        private System.Windows.Forms.DataGridView customerCheckout;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label בNשצק;
        private System.Windows.Forms.TextBox textroomNumber;
        private System.Windows.Forms.Label roomNum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCehckOut;
    }
}
