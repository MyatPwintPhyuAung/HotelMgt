
namespace HotelMgt.Master.RoomFacality
{
    partial class FrmRFacalityEntry
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
            this.ChkDefault = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtFacalityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFacalityId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCustomerEntry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkDefault
            // 
            this.ChkDefault.AutoSize = true;
            this.ChkDefault.Location = new System.Drawing.Point(122, 173);
            this.ChkDefault.Name = "ChkDefault";
            this.ChkDefault.Size = new System.Drawing.Size(115, 24);
            this.ChkDefault.TabIndex = 50;
            this.ChkDefault.Text = "Default Flag";
            this.ChkDefault.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(196, 223);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(87, 35);
            this.BtnCancel.TabIndex = 43;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(65, 223);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(87, 35);
            this.BtnSave.TabIndex = 42;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtFacalityName
            // 
            this.TxtFacalityName.Location = new System.Drawing.Point(122, 120);
            this.TxtFacalityName.Name = "TxtFacalityName";
            this.TxtFacalityName.Size = new System.Drawing.Size(178, 26);
            this.TxtFacalityName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name";
            // 
            // TxtFacalityId
            // 
            this.TxtFacalityId.Location = new System.Drawing.Point(122, 74);
            this.TxtFacalityId.Name = "TxtFacalityId";
            this.TxtFacalityId.Size = new System.Drawing.Size(178, 26);
            this.TxtFacalityId.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id";
            // 
            // LblCustomerEntry
            // 
            this.LblCustomerEntry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblCustomerEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCustomerEntry.Location = new System.Drawing.Point(0, 0);
            this.LblCustomerEntry.Name = "LblCustomerEntry";
            this.LblCustomerEntry.Size = new System.Drawing.Size(350, 30);
            this.LblCustomerEntry.TabIndex = 37;
            this.LblCustomerEntry.Text = "Room Facality";
            this.LblCustomerEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmRFacalityEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.ChkDefault);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtFacalityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFacalityId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCustomerEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRFacalityEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Facality Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkDefault;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtFacalityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFacalityId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCustomerEntry;
    }
}