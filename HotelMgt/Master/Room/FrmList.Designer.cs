
namespace HotelMgt.Master.Room
{
    partial class FrmList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(1200, 30);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Rooms";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.LightGray;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 93);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "RoomId";
            gridViewTextBoxColumn3.HeaderText = "ID";
            gridViewTextBoxColumn3.Name = "RoomId";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "RoomName";
            gridViewTextBoxColumn4.HeaderText = "Name";
            gridViewTextBoxColumn4.Name = "RoomName";
            gridViewTextBoxColumn4.Width = 150;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1200, 599);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 63);
            this.panel1.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(448, 13);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(339, 13);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(100, 35);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(121, 13);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 35);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(230, 13);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 35);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(12, 13);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(100, 35);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmList";
            this.Text = "Room List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCreate;
    }
}