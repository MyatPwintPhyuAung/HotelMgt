
namespace HotelMgt.Master.Customer
{
    partial class FrmCustomerEntry
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCusId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCustomerEntry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.ChkBlock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(196, 349);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(87, 35);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(65, 349);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(87, 35);
            this.BtnSave.TabIndex = 27;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCusName
            // 
            this.TxtCusName.Location = new System.Drawing.Point(122, 109);
            this.TxtCusName.Name = "TxtCusName";
            this.TxtCusName.Size = new System.Drawing.Size(178, 26);
            this.TxtCusName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name";
            // 
            // TxtCusId
            // 
            this.TxtCusId.Location = new System.Drawing.Point(122, 63);
            this.TxtCusId.Name = "TxtCusId";
            this.TxtCusId.Size = new System.Drawing.Size(178, 26);
            this.TxtCusId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id";
            // 
            // LblCustomerEntry
            // 
            this.LblCustomerEntry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblCustomerEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCustomerEntry.Location = new System.Drawing.Point(0, 0);
            this.LblCustomerEntry.Name = "LblCustomerEntry";
            this.LblCustomerEntry.Size = new System.Drawing.Size(375, 30);
            this.LblCustomerEntry.TabIndex = 22;
            this.LblCustomerEntry.Text = "Customer ";
            this.LblCustomerEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "RegDate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 26);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "NRC";
            // 
            // TxtNRC
            // 
            this.TxtNRC.Location = new System.Drawing.Point(122, 206);
            this.TxtNRC.Name = "TxtNRC";
            this.TxtNRC.Size = new System.Drawing.Size(178, 26);
            this.TxtNRC.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Phone";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(122, 248);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(178, 26);
            this.TxtPhone.TabIndex = 34;
            // 
            // ChkBlock
            // 
            this.ChkBlock.AutoSize = true;
            this.ChkBlock.Location = new System.Drawing.Point(122, 291);
            this.ChkBlock.Name = "ChkBlock";
            this.ChkBlock.Size = new System.Drawing.Size(102, 24);
            this.ChkBlock.TabIndex = 36;
            this.ChkBlock.Text = "Block Flag";
            this.ChkBlock.UseVisualStyleBackColor = true;
            // 
            // FrmCustomerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 407);
            this.Controls.Add(this.ChkBlock);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNRC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtCusName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCustomerEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCustomerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Entry";
            this.Load += new System.EventHandler(this.FrmCustomerEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCustomerEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.CheckBox ChkBlock;
    }
}