namespace GUI
{
    partial class formPhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKhu = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtSoSV = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numMaxSV = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSV)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu KTX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số SV tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số SV đang ở";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình trạng phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mô tả";
            // 
            // cmbKhu
            // 
            this.cmbKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhu.FormattingEnabled = true;
            this.cmbKhu.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6"});
            this.cmbKhu.Location = new System.Drawing.Point(245, 42);
            this.cmbKhu.Name = "cmbKhu";
            this.cmbKhu.Size = new System.Drawing.Size(121, 30);
            this.cmbKhu.TabIndex = 7;
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbLoai.Location = new System.Drawing.Point(245, 147);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(102, 30);
            this.cmbLoai.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(245, 94);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(121, 30);
            this.txtMa.TabIndex = 9;
            // 
            // txtSoSV
            // 
            this.txtSoSV.Enabled = false;
            this.txtSoSV.Location = new System.Drawing.Point(245, 256);
            this.txtSoSV.Name = "txtSoSV";
            this.txtSoSV.Size = new System.Drawing.Size(90, 30);
            this.txtSoSV.TabIndex = 11;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(245, 358);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(235, 94);
            this.txtMota.TabIndex = 13;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Items.AddRange(new object[] {
            "Đang sửa chữa",
            "Bình thường"});
            this.cmbTinhTrang.Location = new System.Drawing.Point(245, 302);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(197, 30);
            this.cmbTinhTrang.TabIndex = 14;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(533, 142);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(611, 416);
            this.dgvPhong.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.numMaxSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTinhTrang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMota);
            this.groupBox1.Controls.Add(this.cmbKhu);
            this.groupBox1.Controls.Add(this.txtSoSV);
            this.groupBox1.Controls.Add(this.cmbLoai);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 481);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // numMaxSV
            // 
            this.numMaxSV.Location = new System.Drawing.Point(245, 202);
            this.numMaxSV.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxSV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSV.Name = "numMaxSV";
            this.numMaxSV.Size = new System.Drawing.Size(90, 30);
            this.numMaxSV.TabIndex = 15;
            this.numMaxSV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(393, 513);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 38);
            this.button6.TabIndex = 24;
            this.button6.Text = "Hủy";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(267, 513);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(163, 513);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(63, 513);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(533, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 124);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(319, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(245, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(250, 30);
            this.textBox7.TabIndex = 3;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 69);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(189, 26);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tìm theo loại phòng";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(35, 27);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(181, 26);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tìm theo mã phòng";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // formPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 574);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhong);
            this.MaximumSize = new System.Drawing.Size(1174, 614);
            this.MinimumSize = new System.Drawing.Size(1174, 614);
            this.Name = "formPhong";
            this.Text = "QUẢN LÝ PHÒNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKhu;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtSoSV;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown numMaxSV;
    }
}