
namespace systeminfo
{
    partial class RamUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RamUpdate));
            this.btluh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwRAM = new System.Windows.Forms.DataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMInterface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.RAMtimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btluh
            // 
            this.btluh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btluh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btluh.Font = new System.Drawing.Font("Rockwell", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluh.ForeColor = System.Drawing.Color.White;
            this.btluh.Location = new System.Drawing.Point(-1, 3);
            this.btluh.Name = "btluh";
            this.btluh.Size = new System.Drawing.Size(1022, 64);
            this.btluh.TabIndex = 10;
            this.btluh.Text = "RAM Update";
            this.btluh.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(118, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwRAM);
            this.groupBox1.Location = new System.Drawing.Point(255, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 503);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dgwRAM
            // 
            this.dgwRAM.AllowUserToAddRows = false;
            this.dgwRAM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwRAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.Model,
            this.RAMInterface,
            this.Speed,
            this.Capacity});
            this.dgwRAM.Location = new System.Drawing.Point(24, 19);
            this.dgwRAM.Name = "dgwRAM";
            this.dgwRAM.ReadOnly = true;
            this.dgwRAM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwRAM.Size = new System.Drawing.Size(712, 469);
            this.dgwRAM.TabIndex = 0;
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
            // RAMInterface
            // 
            this.RAMInterface.DataPropertyName = "RAMInterface";
            this.RAMInterface.HeaderText = "RAMInterface";
            this.RAMInterface.Name = "RAMInterface";
            this.RAMInterface.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.DataPropertyName = "Speed";
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(666, 91);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(231, 20);
            this.searchbox.TabIndex = 19;
            // 
            // RAMtimkiem
            // 
            this.RAMtimkiem.BackColor = System.Drawing.Color.GhostWhite;
            this.RAMtimkiem.ForeColor = System.Drawing.Color.Green;
            this.RAMtimkiem.Location = new System.Drawing.Point(528, 86);
            this.RAMtimkiem.Name = "RAMtimkiem";
            this.RAMtimkiem.Size = new System.Drawing.Size(82, 25);
            this.RAMtimkiem.TabIndex = 20;
            this.RAMtimkiem.Text = "Tìm kiếm";
            this.RAMtimkiem.UseVisualStyleBackColor = false;
            this.RAMtimkiem.Click += new System.EventHandler(this.RAMtimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(41, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thông tin RAM hiện tại";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::systeminfo.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox2.Location = new System.Drawing.Point(954, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // RamUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RAMtimkiem);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btluh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RamUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RamUpdate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RamUpdate_FormClosing);
            this.Load += new System.EventHandler(this.RamUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btluh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMInterface;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button RAMtimkiem;
        private System.Windows.Forms.Label label2;
    }
}