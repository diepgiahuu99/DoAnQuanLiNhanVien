namespace doan_ctdl_QuanLiNhanVien_DiepGiaHuu_NgKhacHoangPhi
{
    partial class fXoa
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
            this.lXoa = new System.Windows.Forms.Label();
            this.lMSNV = new System.Windows.Forms.Label();
            this.tMSNV = new System.Windows.Forms.TextBox();
            this.bXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lXoa
            // 
            this.lXoa.AutoSize = true;
            this.lXoa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lXoa.Location = new System.Drawing.Point(147, 18);
            this.lXoa.Name = "lXoa";
            this.lXoa.Size = new System.Drawing.Size(169, 24);
            this.lXoa.TabIndex = 2;
            this.lXoa.Text = "XÓA NHÂN VIÊN";
            // 
            // lMSNV
            // 
            this.lMSNV.AutoSize = true;
            this.lMSNV.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMSNV.Location = new System.Drawing.Point(12, 62);
            this.lMSNV.Name = "lMSNV";
            this.lMSNV.Size = new System.Drawing.Size(59, 23);
            this.lMSNV.TabIndex = 3;
            this.lMSNV.Text = "MSNV:";
            // 
            // tMSNV
            // 
            this.tMSNV.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMSNV.Location = new System.Drawing.Point(101, 59);
            this.tMSNV.Name = "tMSNV";
            this.tMSNV.Size = new System.Drawing.Size(284, 29);
            this.tMSNV.TabIndex = 4;
            // 
            // bXacNhan
            // 
            this.bXacNhan.BackColor = System.Drawing.Color.Silver;
            this.bXacNhan.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXacNhan.ForeColor = System.Drawing.Color.Black;
            this.bXacNhan.Location = new System.Drawing.Point(132, 117);
            this.bXacNhan.Name = "bXacNhan";
            this.bXacNhan.Size = new System.Drawing.Size(184, 47);
            this.bXacNhan.TabIndex = 16;
            this.bXacNhan.Text = "XÁC NHẬN";
            this.bXacNhan.UseVisualStyleBackColor = false;
            this.bXacNhan.Click += new System.EventHandler(this.bXacNhan_Click);
            // 
            // fXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 203);
            this.Controls.Add(this.bXacNhan);
            this.Controls.Add(this.tMSNV);
            this.Controls.Add(this.lMSNV);
            this.Controls.Add(this.lXoa);
            this.Name = "fXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xóa Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lXoa;
        private System.Windows.Forms.Label lMSNV;
        private System.Windows.Forms.TextBox tMSNV;
        private System.Windows.Forms.Button bXacNhan;
    }
}