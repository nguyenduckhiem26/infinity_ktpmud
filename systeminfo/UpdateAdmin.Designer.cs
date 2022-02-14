
namespace systeminfo
{
    partial class UpdateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTTK = new System.Windows.Forms.TextBox();
            this.TXTMK = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.dwgAdmin = new System.Windows.Forms.DataGridView();
            this.btluh = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnFix);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXTTK);
            this.groupBox1.Controls.Add(this.TXTMK);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.dwgAdmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(323, 236);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(228, 236);
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
            this.btnFix.Location = new System.Drawing.Point(123, 236);
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
            this.btnAdd.Location = new System.Drawing.Point(14, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã NV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTTK
            // 
            this.TXTTK.Location = new System.Drawing.Point(146, 125);
            this.TXTTK.Name = "TXTTK";
            this.TXTTK.Size = new System.Drawing.Size(232, 20);
            this.TXTTK.TabIndex = 3;
            this.TXTTK.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TXTMK
            // 
            this.TXTMK.Location = new System.Drawing.Point(146, 191);
            this.TXTMK.Name = "TXTMK";
            this.TXTMK.Size = new System.Drawing.Size(232, 20);
            this.TXTMK.TabIndex = 2;
            this.TXTMK.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(146, 70);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(232, 20);
            this.txtMANV.TabIndex = 1;
            this.txtMANV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dwgAdmin
            // 
            this.dwgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgAdmin.Location = new System.Drawing.Point(427, 43);
            this.dwgAdmin.Name = "dwgAdmin";
            this.dwgAdmin.Size = new System.Drawing.Size(343, 282);
            this.dwgAdmin.TabIndex = 0;
            this.dwgAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwgAdmin_CellClick);
            // 
            // btluh
            // 
            this.btluh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btluh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btluh.Font = new System.Drawing.Font("Rockwell", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluh.ForeColor = System.Drawing.Color.White;
            this.btluh.Location = new System.Drawing.Point(-1, -4);
            this.btluh.Name = "btluh";
            this.btluh.Size = new System.Drawing.Size(801, 64);
            this.btluh.TabIndex = 11;
            this.btluh.Text = "Update admin information";
            this.btluh.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::systeminfo.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox2.Location = new System.Drawing.Point(732, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::systeminfo.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btluh);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAdmin";
            this.Load += new System.EventHandler(this.UpdateAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTTK;
        private System.Windows.Forms.TextBox TXTMK;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.DataGridView dwgAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btluh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}