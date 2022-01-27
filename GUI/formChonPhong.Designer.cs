namespace GUI
{
    partial class formChonPhong
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
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.Location = new System.Drawing.Point(12, 12);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(474, 390);
            this.flpPhong.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(75, 419);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(350, 421);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 32);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // formChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 460);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flpPhong);
            this.Name = "formChonPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHuy;
    }
}