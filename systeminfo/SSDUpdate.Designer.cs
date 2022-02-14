
namespace systeminfo
{
    partial class SSDUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSDUpdate));
            this.btluh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwSSD = new System.Windows.Forms.DataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDFormFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Controller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NANDBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NANDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.SSDtimkiem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btluh
            // 
            this.btluh.AutoSize = true;
            this.btluh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btluh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btluh.Font = new System.Drawing.Font("Rockwell", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluh.ForeColor = System.Drawing.Color.White;
            this.btluh.Location = new System.Drawing.Point(0, 3);
            this.btluh.Name = "btluh";
            this.btluh.Size = new System.Drawing.Size(1019, 64);
            this.btluh.TabIndex = 12;
            this.btluh.Text = "SSD Update";
            this.btluh.UseVisualStyleBackColor = false;
            this.btluh.Click += new System.EventHandler(this.btluh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 522);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(58, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông tin ổ cứng hiện tại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwSSD);
            this.groupBox1.Location = new System.Drawing.Point(261, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 503);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dgwSSD
            // 
            this.dgwSSD.AllowUserToAddRows = false;
            this.dgwSSD.AllowUserToDeleteRows = false;
            this.dgwSSD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwSSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.Model,
            this.Interface,
            this.SSDFormFactor,
            this.Controller,
            this.DRAM,
            this.NANDBrand,
            this.NANDType,
            this.Categories});
            this.dgwSSD.Location = new System.Drawing.Point(6, 28);
            this.dgwSSD.Name = "dgwSSD";
            this.dgwSSD.ReadOnly = true;
            this.dgwSSD.Size = new System.Drawing.Size(723, 469);
            this.dgwSSD.TabIndex = 0;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Interface
            // 
            this.Interface.DataPropertyName = "Interface";
            this.Interface.HeaderText = "Interface";
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            // 
            // SSDFormFactor
            // 
            this.SSDFormFactor.DataPropertyName = "SSDFormFactor";
            this.SSDFormFactor.HeaderText = "SSDFormFactor";
            this.SSDFormFactor.Name = "SSDFormFactor";
            this.SSDFormFactor.ReadOnly = true;
            // 
            // Controller
            // 
            this.Controller.DataPropertyName = "Controller";
            this.Controller.HeaderText = "Controller";
            this.Controller.Name = "Controller";
            this.Controller.ReadOnly = true;
            // 
            // DRAM
            // 
            this.DRAM.DataPropertyName = "DRAM";
            this.DRAM.HeaderText = "DRAM";
            this.DRAM.Name = "DRAM";
            this.DRAM.ReadOnly = true;
            // 
            // NANDBrand
            // 
            this.NANDBrand.DataPropertyName = "NANDBrand";
            this.NANDBrand.HeaderText = "NANDBrand";
            this.NANDBrand.Name = "NANDBrand";
            this.NANDBrand.ReadOnly = true;
            // 
            // NANDType
            // 
            this.NANDType.DataPropertyName = "NANDType";
            this.NANDType.HeaderText = "NANDType";
            this.NANDType.Name = "NANDType";
            this.NANDType.ReadOnly = true;
            // 
            // Categories
            // 
            this.Categories.DataPropertyName = "Categories";
            this.Categories.HeaderText = "Categories";
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(95, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(677, 84);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(223, 20);
            this.searchbox.TabIndex = 2;
            this.searchbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbox_KeyPress);
            // 
            // SSDtimkiem
            // 
            this.SSDtimkiem.BackColor = System.Drawing.Color.GhostWhite;
            this.SSDtimkiem.ForeColor = System.Drawing.Color.Green;
            this.SSDtimkiem.Location = new System.Drawing.Point(558, 81);
            this.SSDtimkiem.Name = "SSDtimkiem";
            this.SSDtimkiem.Size = new System.Drawing.Size(82, 25);
            this.SSDtimkiem.TabIndex = 17;
            this.SSDtimkiem.Text = "Tìm kiếm";
            this.SSDtimkiem.UseVisualStyleBackColor = false;
            this.SSDtimkiem.Click += new System.EventHandler(this.SSDtimkiem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::systeminfo.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox2.Location = new System.Drawing.Point(952, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // SSDUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 632);
            this.Controls.Add(this.SSDtimkiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btluh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SSDUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSDUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SSDUpdate_FormClosed);
            this.Load += new System.EventHandler(this.SSDUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btluh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwSSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDFormFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Controller;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NANDBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn NANDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
        private System.Windows.Forms.Button SSDtimkiem;
        private System.Windows.Forms.Label label2;
    }
}