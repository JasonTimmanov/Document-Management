namespace Document_Management
{
    partial class Verify
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbShowAll = new System.Windows.Forms.RadioButton();
            this.rdbShowChecked = new System.Windows.Forms.RadioButton();
            this.rdbShowUnchecked = new System.Windows.Forms.RadioButton();
            this.btnReturnWelcome = new System.Windows.Forms.Button();
            this.btnReturnMng = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.cbLegit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 269);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phê duyệt công văn";
            // 
            // rdbShowAll
            // 
            this.rdbShowAll.AutoSize = true;
            this.rdbShowAll.Checked = true;
            this.rdbShowAll.Location = new System.Drawing.Point(12, 50);
            this.rdbShowAll.Name = "rdbShowAll";
            this.rdbShowAll.Size = new System.Drawing.Size(139, 17);
            this.rdbShowAll.TabIndex = 3;
            this.rdbShowAll.TabStop = true;
            this.rdbShowAll.Text = "Hiển thị tất cả công văn";
            this.rdbShowAll.UseVisualStyleBackColor = true;
            this.rdbShowAll.CheckedChanged += new System.EventHandler(this.rdbShowAll_CheckedChanged);
            // 
            // rdbShowChecked
            // 
            this.rdbShowChecked.AutoSize = true;
            this.rdbShowChecked.Location = new System.Drawing.Point(12, 73);
            this.rdbShowChecked.Name = "rdbShowChecked";
            this.rdbShowChecked.Size = new System.Drawing.Size(170, 17);
            this.rdbShowChecked.TabIndex = 4;
            this.rdbShowChecked.Text = "Chỉ hiển thị công văn đã duyệt";
            this.rdbShowChecked.UseVisualStyleBackColor = true;
            this.rdbShowChecked.CheckedChanged += new System.EventHandler(this.rdbShowChecked_CheckedChanged);
            // 
            // rdbShowUnchecked
            // 
            this.rdbShowUnchecked.AutoSize = true;
            this.rdbShowUnchecked.Location = new System.Drawing.Point(12, 96);
            this.rdbShowUnchecked.Name = "rdbShowUnchecked";
            this.rdbShowUnchecked.Size = new System.Drawing.Size(181, 17);
            this.rdbShowUnchecked.TabIndex = 5;
            this.rdbShowUnchecked.Text = "Chỉ hiển thị công văn chưa duyệt";
            this.rdbShowUnchecked.UseVisualStyleBackColor = true;
            this.rdbShowUnchecked.CheckedChanged += new System.EventHandler(this.rdbShowUnchecked_CheckedChanged);
            // 
            // btnReturnWelcome
            // 
            this.btnReturnWelcome.Location = new System.Drawing.Point(370, 119);
            this.btnReturnWelcome.Name = "btnReturnWelcome";
            this.btnReturnWelcome.Size = new System.Drawing.Size(169, 37);
            this.btnReturnWelcome.TabIndex = 27;
            this.btnReturnWelcome.Text = "Quay lại giao diện chào mừng";
            this.btnReturnWelcome.UseVisualStyleBackColor = true;
            this.btnReturnWelcome.Click += new System.EventHandler(this.btnReturnWelcome_Click);
            // 
            // btnReturnMng
            // 
            this.btnReturnMng.Location = new System.Drawing.Point(545, 119);
            this.btnReturnMng.Name = "btnReturnMng";
            this.btnReturnMng.Size = new System.Drawing.Size(152, 37);
            this.btnReturnMng.TabIndex = 28;
            this.btnReturnMng.Text = "Quay lại giao diện quản lý";
            this.btnReturnMng.UseVisualStyleBackColor = true;
            this.btnReturnMng.Click += new System.EventHandler(this.btnReturnMng_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(12, 119);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(193, 37);
            this.btnVerify.TabIndex = 29;
            this.btnVerify.Text = "Thay đổi trạng thái của công văn";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(447, 50);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.ReadOnly = true;
            this.txbNumber.Size = new System.Drawing.Size(92, 20);
            this.txbNumber.TabIndex = 30;
            // 
            // cbLegit
            // 
            this.cbLegit.AutoSize = true;
            this.cbLegit.Enabled = false;
            this.cbLegit.Location = new System.Drawing.Point(447, 87);
            this.cbLegit.Name = "cbLegit";
            this.cbLegit.Size = new System.Drawing.Size(90, 17);
            this.cbLegit.TabIndex = 31;
            this.cbLegit.Text = "Đã phê duyệt";
            this.cbLegit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số công văn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Trạng thái";
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLegit);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnReturnMng);
            this.Controls.Add(this.btnReturnWelcome);
            this.Controls.Add(this.rdbShowUnchecked);
            this.Controls.Add(this.rdbShowChecked);
            this.Controls.Add(this.rdbShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Verify";
            this.Text = "Phê duyệt công văn";
            this.Load += new System.EventHandler(this.Verify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbShowAll;
        private System.Windows.Forms.RadioButton rdbShowChecked;
        private System.Windows.Forms.RadioButton rdbShowUnchecked;
        private System.Windows.Forms.Button btnReturnWelcome;
        private System.Windows.Forms.Button btnReturnMng;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.CheckBox cbLegit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}