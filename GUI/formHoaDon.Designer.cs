namespace GUI
{
    partial class formHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.txtSoNuoc = new System.Windows.Forms.TextBox();
            this.txtSoDien = new System.Windows.Forms.TextBox();
            this.txtNopTien = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtCSNuocMoi = new System.Windows.Forms.TextBox();
            this.txtCSDienMoi = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCSNuocCu = new System.Windows.Forms.TextBox();
            this.txtCSDienCu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ckb2);
            this.groupBox1.Controls.Add(this.ckb1);
            this.groupBox1.Controls.Add(this.date2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date1);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(576, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 225);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.Location = new System.Drawing.Point(39, 170);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(123, 26);
            this.ckb2.TabIndex = 9;
            this.ckb2.Text = "Còn nợ tiền";
            this.ckb2.UseVisualStyleBackColor = true;
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Location = new System.Drawing.Point(39, 109);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(96, 26);
            this.ckb1.TabIndex = 8;
            this.ckb1.Text = "Từ ngày";
            this.ckb1.UseVisualStyleBackColor = true;
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(384, 109);
            this.date2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(139, 30);
            this.date2.TabIndex = 7;
            this.date2.Value = new System.DateTime(2022, 1, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "đến ngày";
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(141, 109);
            this.date1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(139, 30);
            this.date1.TabIndex = 5;
            this.date1.Value = new System.DateTime(2022, 1, 7, 0, 0, 0, 0);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AutoSize = true;
            this.btnTimkiem.Location = new System.Drawing.Point(293, 45);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(95, 32);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(138, 47);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(124, 30);
            this.txtKey.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tiền nước";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tiền điện";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Location = new System.Drawing.Point(160, 142);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.ReadOnly = true;
            this.txtTienNuoc.Size = new System.Drawing.Size(140, 30);
            this.txtTienNuoc.TabIndex = 21;
            this.txtTienNuoc.Text = "0";
            this.txtTienNuoc.TextChanged += new System.EventHandler(this.txtTienNuoc_TextChanged);
            // 
            // txtTienDien
            // 
            this.txtTienDien.Location = new System.Drawing.Point(160, 142);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.ReadOnly = true;
            this.txtTienDien.Size = new System.Drawing.Size(140, 30);
            this.txtTienDien.TabIndex = 20;
            this.txtTienDien.Text = "0";
            this.txtTienDien.TextChanged += new System.EventHandler(this.txtTienDien_TextChanged);
            // 
            // txtSoNuoc
            // 
            this.txtSoNuoc.Location = new System.Drawing.Point(160, 101);
            this.txtSoNuoc.Name = "txtSoNuoc";
            this.txtSoNuoc.ReadOnly = true;
            this.txtSoNuoc.Size = new System.Drawing.Size(72, 30);
            this.txtSoNuoc.TabIndex = 18;
            this.txtSoNuoc.Text = "0";
            // 
            // txtSoDien
            // 
            this.txtSoDien.Location = new System.Drawing.Point(160, 101);
            this.txtSoDien.Name = "txtSoDien";
            this.txtSoDien.ReadOnly = true;
            this.txtSoDien.Size = new System.Drawing.Size(72, 30);
            this.txtSoDien.TabIndex = 17;
            this.txtSoDien.Text = "0";
            // 
            // txtNopTien
            // 
            this.txtNopTien.Location = new System.Drawing.Point(178, 510);
            this.txtNopTien.Name = "txtNopTien";
            this.txtNopTien.Size = new System.Drawing.Size(138, 30);
            this.txtNopTien.TabIndex = 16;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(178, 469);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(138, 30);
            this.txtTongTien.TabIndex = 19;
            this.txtTongTien.Text = "0";
            // 
            // txtCSNuocMoi
            // 
            this.txtCSNuocMoi.Location = new System.Drawing.Point(160, 60);
            this.txtCSNuocMoi.Name = "txtCSNuocMoi";
            this.txtCSNuocMoi.Size = new System.Drawing.Size(100, 30);
            this.txtCSNuocMoi.TabIndex = 15;
            this.txtCSNuocMoi.TextChanged += new System.EventHandler(this.txtCSNuocMoi_TextChanged);
            this.txtCSNuocMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSNuocMoi_KeyPress);
            // 
            // txtCSDienMoi
            // 
            this.txtCSDienMoi.Location = new System.Drawing.Point(160, 60);
            this.txtCSDienMoi.Name = "txtCSDienMoi";
            this.txtCSDienMoi.Size = new System.Drawing.Size(100, 30);
            this.txtCSDienMoi.TabIndex = 14;
            this.txtCSDienMoi.TextChanged += new System.EventHandler(this.txtCSDienMoi_TextChanged);
            this.txtCSDienMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSDienMoi_KeyPress);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(119, 23);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 30);
            this.txtMaPhong.TabIndex = 13;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(454, 230);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(706, 332);
            this.dgvHoaDon.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số nước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số tiền đã đóng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chỉ số điện mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã phòng";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(454, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 33);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.AutoSize = true;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(454, 169);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 33);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(454, 98);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 33);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chỉ số nước mới";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNopTien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 569);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(242, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Lấy chỉ số cũ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCSNuocCu
            // 
            this.txtCSNuocCu.Location = new System.Drawing.Point(160, 17);
            this.txtCSNuocCu.Name = "txtCSNuocCu";
            this.txtCSNuocCu.ReadOnly = true;
            this.txtCSNuocCu.Size = new System.Drawing.Size(100, 30);
            this.txtCSNuocCu.TabIndex = 25;
            // 
            // txtCSDienCu
            // 
            this.txtCSDienCu.Location = new System.Drawing.Point(160, 17);
            this.txtCSDienCu.Name = "txtCSDienCu";
            this.txtCSDienCu.ReadOnly = true;
            this.txtCSDienCu.Size = new System.Drawing.Size(100, 30);
            this.txtCSDienCu.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCSDienMoi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCSDienCu);
            this.groupBox3.Controls.Add(this.txtSoDien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTienDien);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 189);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtCSNuocCu);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtCSNuocMoi);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtTienNuoc);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtSoNuoc);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 189);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 22);
            this.label12.TabIndex = 26;
            this.label12.Text = "Chỉ số nước cũ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Chỉ số điện cũ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã phòng";
            // 
            // formHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 574);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1174, 614);
            this.MinimumSize = new System.Drawing.Size(1174, 614);
            this.Name = "formHoaDon";
            this.Text = "HÓA ĐƠN TIỀN PHÒNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.TextBox txtSoNuoc;
        private System.Windows.Forms.TextBox txtSoDien;
        private System.Windows.Forms.TextBox txtNopTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtCSNuocMoi;
        private System.Windows.Forms.TextBox txtCSDienMoi;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCSNuocCu;
        private System.Windows.Forms.TextBox txtCSDienCu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}