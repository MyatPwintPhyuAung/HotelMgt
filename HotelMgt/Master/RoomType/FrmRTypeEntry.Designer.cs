
namespace HotelMgt.Master.RoomType
{
    partial class FrmRTypeEntry
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
            this.TxtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTypeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblREntry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(199, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 35);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(65, 190);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 35);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtTypeName
            // 
            this.TxtTypeName.Location = new System.Drawing.Point(122, 117);
            this.TxtTypeName.Name = "TxtTypeName";
            this.TxtTypeName.Size = new System.Drawing.Size(191, 26);
            this.TxtTypeName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // TxtTypeId
            // 
            this.TxtTypeId.Location = new System.Drawing.Point(122, 71);
            this.TxtTypeId.Name = "TxtTypeId";
            this.TxtTypeId.Size = new System.Drawing.Size(191, 26);
            this.TxtTypeId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // LblREntry
            // 
            this.LblREntry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblREntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblREntry.Location = new System.Drawing.Point(0, 0);
            this.LblREntry.Name = "LblREntry";
            this.LblREntry.Size = new System.Drawing.Size(368, 30);
            this.LblREntry.TabIndex = 11;
            this.LblREntry.Text = "New Room Type";
            this.LblREntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmRTypeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(368, 280);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTypeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblREntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRTypeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Type Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTypeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblREntry;
    }
}