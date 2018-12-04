namespace doan_ctdl_QuanLiNhanVien_DiepGiaHuu_NgKhacHoangPhi
{
    partial class fNhanVien
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
            this.TenDoAn = new System.Windows.Forms.Label();
            this.dDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.tTimKiem = new System.Windows.Forms.TextBox();
            this.bTimKiem = new System.Windows.Forms.Button();
            this.bThem = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.bDanhSach = new System.Windows.Forms.Button();
            this.lThaoTac = new System.Windows.Forms.Label();
            this.bLuu = new System.Windows.Forms.Button();
            this.bDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dDanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // TenDoAn
            // 
            this.TenDoAn.AutoSize = true;
            this.TenDoAn.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDoAn.ForeColor = System.Drawing.Color.Red;
            this.TenDoAn.Location = new System.Drawing.Point(12, 18);
            this.TenDoAn.Name = "TenDoAn";
            this.TenDoAn.Size = new System.Drawing.Size(497, 56);
            this.TenDoAn.TabIndex = 0;
            this.TenDoAn.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // dDanhSachNhanVien
            // 
            this.dDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dDanhSachNhanVien.BackgroundColor = System.Drawing.Color.LightGray;
            this.dDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDanhSachNhanVien.Location = new System.Drawing.Point(22, 88);
            this.dDanhSachNhanVien.Name = "dDanhSachNhanVien";
            this.dDanhSachNhanVien.Size = new System.Drawing.Size(792, 474);
            this.dDanhSachNhanVien.TabIndex = 1;
            // 
            // tTimKiem
            // 
            this.tTimKiem.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTimKiem.Location = new System.Drawing.Point(22, 607);
            this.tTimKiem.Name = "tTimKiem";
            this.tTimKiem.Size = new System.Drawing.Size(592, 32);
            this.tTimKiem.TabIndex = 2;
            // 
            // bTimKiem
            // 
            this.bTimKiem.BackColor = System.Drawing.Color.Silver;
            this.bTimKiem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTimKiem.ForeColor = System.Drawing.Color.Black;
            this.bTimKiem.Location = new System.Drawing.Point(648, 604);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(166, 38);
            this.bTimKiem.TabIndex = 3;
            this.bTimKiem.Text = "TÌM KIẾM";
            this.bTimKiem.UseVisualStyleBackColor = false;
            this.bTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // bThem
            // 
            this.bThem.BackColor = System.Drawing.Color.Silver;
            this.bThem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThem.ForeColor = System.Drawing.Color.Black;
            this.bThem.Location = new System.Drawing.Point(851, 283);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(184, 77);
            this.bThem.TabIndex = 4;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = false;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoa
            // 
            this.bXoa.BackColor = System.Drawing.Color.Silver;
            this.bXoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXoa.ForeColor = System.Drawing.Color.Black;
            this.bXoa.Location = new System.Drawing.Point(851, 383);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(184, 77);
            this.bXoa.TabIndex = 5;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = false;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // bSua
            // 
            this.bSua.BackColor = System.Drawing.Color.Silver;
            this.bSua.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSua.ForeColor = System.Drawing.Color.Black;
            this.bSua.Location = new System.Drawing.Point(851, 485);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(184, 77);
            this.bSua.TabIndex = 6;
            this.bSua.Text = "SỬA";
            this.bSua.UseVisualStyleBackColor = false;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // bDanhSach
            // 
            this.bDanhSach.BackColor = System.Drawing.Color.Silver;
            this.bDanhSach.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDanhSach.ForeColor = System.Drawing.Color.Black;
            this.bDanhSach.Location = new System.Drawing.Point(851, 185);
            this.bDanhSach.Name = "bDanhSach";
            this.bDanhSach.Size = new System.Drawing.Size(184, 77);
            this.bDanhSach.TabIndex = 7;
            this.bDanhSach.Text = "XUẤT DANH SÁCH";
            this.bDanhSach.UseVisualStyleBackColor = false;
            this.bDanhSach.Click += new System.EventHandler(this.bDanhSach_Click);
            // 
            // lThaoTac
            // 
            this.lThaoTac.AutoSize = true;
            this.lThaoTac.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThaoTac.Location = new System.Drawing.Point(847, 88);
            this.lThaoTac.Name = "lThaoTac";
            this.lThaoTac.Size = new System.Drawing.Size(0, 22);
            this.lThaoTac.TabIndex = 8;
            // 
            // bLuu
            // 
            this.bLuu.BackColor = System.Drawing.Color.Silver;
            this.bLuu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLuu.ForeColor = System.Drawing.Color.Black;
            this.bLuu.Location = new System.Drawing.Point(851, 587);
            this.bLuu.Name = "bLuu";
            this.bLuu.Size = new System.Drawing.Size(184, 77);
            this.bLuu.TabIndex = 9;
            this.bLuu.Text = "LƯU";
            this.bLuu.UseVisualStyleBackColor = false;
            this.bLuu.Click += new System.EventHandler(this.bLuu_Click);
            // 
            // bDoc
            // 
            this.bDoc.BackColor = System.Drawing.Color.Silver;
            this.bDoc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDoc.ForeColor = System.Drawing.Color.Black;
            this.bDoc.Location = new System.Drawing.Point(851, 88);
            this.bDoc.Name = "bDoc";
            this.bDoc.Size = new System.Drawing.Size(184, 77);
            this.bDoc.TabIndex = 10;
            this.bDoc.Text = "LẤY DỮ LIỆU";
            this.bDoc.UseVisualStyleBackColor = false;
            this.bDoc.Click += new System.EventHandler(this.bDoc_Click);
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 681);
            this.Controls.Add(this.bDoc);
            this.Controls.Add(this.bLuu);
            this.Controls.Add(this.lThaoTac);
            this.Controls.Add(this.bDanhSach);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.bTimKiem);
            this.Controls.Add(this.tTimKiem);
            this.Controls.Add(this.dDanhSachNhanVien);
            this.Controls.Add(this.TenDoAn);
            this.Name = "fNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dDanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenDoAn;
        private System.Windows.Forms.DataGridView dDanhSachNhanVien;
        private System.Windows.Forms.TextBox tTimKiem;
        private System.Windows.Forms.Button bTimKiem;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bDanhSach;
        private System.Windows.Forms.Label lThaoTac;
        private System.Windows.Forms.Button bLuu;
        private System.Windows.Forms.Button bDoc;
    }
}

