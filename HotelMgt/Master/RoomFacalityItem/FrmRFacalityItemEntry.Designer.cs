
namespace HotelMgt.Master.RoomFacalityItem
{
    partial class FrmRFacalityItemEntry
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
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFees = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFItemId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEntry = new System.Windows.Forms.Label();
            this.TxtFacalityId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkDefault = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(224, 282);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 35);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(42, 282);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 35);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Price";
            // 
            // TxtFees
            // 
            this.TxtFees.Location = new System.Drawing.Point(122, 184);
            this.TxtFees.Name = "TxtFees";
            this.TxtFees.Size = new System.Drawing.Size(190, 26);
            this.TxtFees.TabIndex = 15;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(122, 144);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(190, 26);
            this.TxtName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // TxtFItemId
            // 
            this.TxtFItemId.Location = new System.Drawing.Point(122, 67);
            this.TxtFItemId.Name = "TxtFItemId";
            this.TxtFItemId.Size = new System.Drawing.Size(190, 26);
            this.TxtFItemId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "FItemId";
            // 
            // LblEntry
            // 
            this.LblEntry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblEntry.Location = new System.Drawing.Point(0, 0);
            this.LblEntry.Name = "LblEntry";
            this.LblEntry.Size = new System.Drawing.Size(405, 30);
            this.LblEntry.TabIndex = 11;
            this.LblEntry.Text = "Facality Item ";
            this.LblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtFacalityId
            // 
            this.TxtFacalityId.Location = new System.Drawing.Point(122, 105);
            this.TxtFacalityId.Name = "TxtFacalityId";
            this.TxtFacalityId.Size = new System.Drawing.Size(190, 26);
            this.TxtFacalityId.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "FacalityId";
            // 
            // ChkDefault
            // 
            this.ChkDefault.AutoSize = true;
            this.ChkDefault.Location = new System.Drawing.Point(122, 231);
            this.ChkDefault.Name = "ChkDefault";
            this.ChkDefault.Size = new System.Drawing.Size(115, 24);
            this.ChkDefault.TabIndex = 24;
            this.ChkDefault.Text = "Default Flag";
            this.ChkDefault.UseVisualStyleBackColor = true;
            // 
            // FrmRFacalityItemEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 377);
            this.Controls.Add(this.ChkDefault);
            this.Controls.Add(this.TxtFacalityId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFees);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFItemId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRFacalityItemEntry";
            this.Text = "Room Facality Item Entry";
            this.Load += new System.EventHandler(this.FrmRFacalityItemEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFees;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEntry;
        private System.Windows.Forms.TextBox TxtFacalityId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkDefault;
    }
}