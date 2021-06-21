namespace Document_Management
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDocMng = new System.Windows.Forms.Button();
            this.btnUserMng = new System.Windows.Forms.Button();
            this.btnDocSearch = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống quản lý công văn";
            // 
            // btnDocMng
            // 
            this.btnDocMng.Location = new System.Drawing.Point(12, 65);
            this.btnDocMng.Name = "btnDocMng";
            this.btnDocMng.Size = new System.Drawing.Size(158, 65);
            this.btnDocMng.TabIndex = 1;
            this.btnDocMng.Text = "Quản lý công văn";
            this.btnDocMng.UseVisualStyleBackColor = true;
            this.btnDocMng.Click += new System.EventHandler(this.btnDocMng_Click);
            // 
            // btnUserMng
            // 
            this.btnUserMng.Location = new System.Drawing.Point(12, 207);
            this.btnUserMng.Name = "btnUserMng";
            this.btnUserMng.Size = new System.Drawing.Size(158, 65);
            this.btnUserMng.TabIndex = 4;
            this.btnUserMng.Text = "Quản lý người dùng";
            this.btnUserMng.UseVisualStyleBackColor = true;
            this.btnUserMng.Click += new System.EventHandler(this.btnUserMng_Click);
            // 
            // btnDocSearch
            // 
            this.btnDocSearch.Location = new System.Drawing.Point(190, 65);
            this.btnDocSearch.Name = "btnDocSearch";
            this.btnDocSearch.Size = new System.Drawing.Size(158, 65);
            this.btnDocSearch.TabIndex = 5;
            this.btnDocSearch.Text = "Tìm kiếm công văn";
            this.btnDocSearch.UseVisualStyleBackColor = true;
            this.btnDocSearch.Click += new System.EventHandler(this.btnDocSearch_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(190, 136);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(158, 65);
            this.btnUserInfo.TabIndex = 6;
            this.btnUserInfo.Text = "Thông tin người dùng";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(190, 207);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 65);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(12, 136);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(158, 65);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "Phê duyệt công văn";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 287);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnDocSearch);
            this.Controls.Add(this.btnUserMng);
            this.Controls.Add(this.btnDocMng);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Text = "Chào mừng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDocMng;
        private System.Windows.Forms.Button btnUserMng;
        private System.Windows.Forms.Button btnDocSearch;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVerify;
    }
}