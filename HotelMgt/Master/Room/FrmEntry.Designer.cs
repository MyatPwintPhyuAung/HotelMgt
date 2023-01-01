
namespace HotelMgt.Master.Room
{
    partial class FrmEntry
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
            this.LblEntry = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFees = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEntry
            // 
            this.LblEntry.BackColor = System.Drawing.Color.CadetBlue;
            this.LblEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblEntry.Location = new System.Drawing.Point(0, 0);
            this.LblEntry.Name = "LblEntry";
            this.LblEntry.Size = new System.Drawing.Size(379, 30);
            this.LblEntry.TabIndex = 0;
            this.LblEntry.Text = "New Room";
            this.LblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(122, 60);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(191, 26);
            this.TxtId.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(122, 106);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(191, 26);
            this.TxtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // TxtCapacity
            // 
            this.TxtCapacity.Location = new System.Drawing.Point(122, 198);
            this.TxtCapacity.Name = "TxtCapacity";
            this.TxtCapacity.Size = new System.Drawing.Size(191, 26);
            this.TxtCapacity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // TxtFees
            // 
            this.TxtFees.Location = new System.Drawing.Point(122, 152);
            this.TxtFees.Name = "TxtFees";
            this.TxtFees.Size = new System.Drawing.Size(191, 26);
            this.TxtFees.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "label3";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(42, 249);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 35);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(224, 249);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 35);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 313);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFees);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEntry";
            this.Text = "FrmEntry";
            this.Load += new System.EventHandler(this.FrmEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}