
namespace systeminfo
{
    partial class UpdateSSDAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSSDAD));
            this.btluh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dwgSSD = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.txtNANDBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcontroller = new System.Windows.Forms.TextBox();
            this.txtDRAM = new System.Windows.Forms.TextBox();
            this.txtformfactor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtinterface = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgSSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btluh
            // 
            this.btluh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btluh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btluh.Font = new System.Drawing.Font("Rockwell", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluh.ForeColor = System.Drawing.Color.White;
            this.btluh.Location = new System.Drawing.Point(0, 1);
            this.btluh.Name = "btluh";
            this.btluh.Size = new System.Drawing.Size(1133, 64);
            this.btluh.TabIndex = 15;
            this.btluh.Text = "Update SSD information";
            this.btluh.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtCategories);
            this.groupBox1.Controls.Add(this.txtNANDBrand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtcontroller);
            this.groupBox1.Controls.Add(this.txtDRAM);
            this.groupBox1.Controls.Add(this.txtformfactor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmodel);
            this.groupBox1.Controls.Add(this.txtinterface);
            this.groupBox1.Controls.Add(this.txtbrand);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnFix);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dwgSSD);
            this.groupBox1.Location = new System.Drawing.Point(13, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 369);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(325, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(230, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFix
            // 
            this.btnFix.ForeColor = System.Drawing.Color.Black;
            this.btnFix.Location = new System.Drawing.Point(125, 302);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 8;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(16, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dwgSSD
            // 
            this.dwgSSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgSSD.Location = new System.Drawing.Point(427, 43);
            this.dwgSSD.Name = "dwgSSD";
            this.dwgSSD.Size = new System.Drawing.Size(683, 282);
            this.dwgSSD.TabIndex = 0;
            this.dwgSSD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwgSSD_CellClick);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(23, 239);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(57, 13);
            this.category.TabIndex = 40;
            this.category.Text = "Categories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "NANDType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "NANDBrand";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(156, 206);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(232, 20);
            this.txtType.TabIndex = 37;
            // 
            // txtCategories
            // 
            this.txtCategories.Location = new System.Drawing.Point(156, 232);
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.Size = new System.Drawing.Size(232, 20);
            this.txtCategories.TabIndex = 36;
            // 
            // txtNANDBrand
            // 
            this.txtNANDBrand.Location = new System.Drawing.Point(156, 180);
            this.txtNANDBrand.Name = "txtNANDBrand";
            this.txtNANDBrand.Size = new System.Drawing.Size(232, 20);
            this.txtNANDBrand.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "DRAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Controller";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "SSDFormFactor";
            // 
            // txtcontroller
            // 
            this.txtcontroller.Location = new System.Drawing.Point(156, 123);
            this.txtcontroller.Name = "txtcontroller";
            this.txtcontroller.Size = new System.Drawing.Size(232, 20);
            this.txtcontroller.TabIndex = 31;
            // 
            // txtDRAM
            // 
            this.txtDRAM.Location = new System.Drawing.Point(156, 149);
            this.txtDRAM.Name = "txtDRAM";
            this.txtDRAM.Size = new System.Drawing.Size(232, 20);
            this.txtDRAM.TabIndex = 30;
            // 
            // txtformfactor
            // 
            this.txtformfactor.Location = new System.Drawing.Point(156, 97);
            this.txtformfactor.Name = "txtformfactor";
            this.txtformfactor.Size = new System.Drawing.Size(232, 20);
            this.txtformfactor.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Brand";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(156, 45);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(232, 20);
            this.txtmodel.TabIndex = 25;
            // 
            // txtinterface
            // 
            this.txtinterface.Location = new System.Drawing.Point(156, 71);
            this.txtinterface.Name = "txtinterface";
            this.txtinterface.Size = new System.Drawing.Size(232, 20);
            this.txtinterface.TabIndex = 24;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(156, 19);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(232, 20);
            this.txtbrand.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::systeminfo.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox2.Location = new System.Drawing.Point(1067, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::systeminfo.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UpdateSSDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btluh);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSSDAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update SSD Model";
            this.Load += new System.EventHandler(this.UpdateSSDAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgSSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btluh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dwgSSD;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCategories;
        private System.Windows.Forms.TextBox txtNANDBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcontroller;
        private System.Windows.Forms.TextBox txtDRAM;
        private System.Windows.Forms.TextBox txtformfactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtinterface;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}