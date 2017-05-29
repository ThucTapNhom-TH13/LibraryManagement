using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmChiTietDG.
	/// </summary>
	public class frmChiTietDG : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnXoaHinh;
		private System.Windows.Forms.PictureBox picHinh;
		private System.Windows.Forms.TextBox txtThongtin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton optNu;
		private System.Windows.Forms.RadioButton optNam;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenDG;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaDG;
		private System.Windows.Forms.Label label1;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string filename="";
		public frmChiTietDG()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiDocGia();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Methods
		void HienThiDocGia()
		{
			try
			{
				DataTable dtDocgia=SqlHelper.ExecuteDataTable(
					"Pro_SelectTenDG",
					CommandType.StoredProcedure,
					"@msdg",SqlHelper.strMaDG.Trim());
				
				txtMaDG.Text=dtDocgia.Rows[0]["MSDG"].ToString();
				txtTenDG.Text=dtDocgia.Rows[0]["TENDG"].ToString();
				txtDC.Text=dtDocgia.Rows[0]["DIACHI"].ToString();
				dtNgaySinh.Value=(DateTime)dtDocgia.Rows[0]["NGAYSINH"];
				txtEmail.Text=dtDocgia.Rows[0]["Email"].ToString();
				if(dtDocgia.Rows[0]["GIOITINH"].ToString()=="1")
				{
					optNam.Checked=true;
				}
				else
				{
					optNu.Checked=true;
				}

				txtThongtin.Text=dtDocgia.Rows[0]["THONGTINKHAC"].ToString();
				try
				{
					if(dtDocgia.Rows[0]["HINHANHDG"].ToString()!="")
					{
						filename=dtDocgia.Rows[0]["HINHANHDG"].ToString();
						picHinh.Image=new Bitmap(Application.StartupPath+"\\hinh\\"+filename);

					}
					else
					{
						filename="";
						picHinh.Image=null;
					}
				}
				catch{}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChiTietDG));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnXoaHinh = new System.Windows.Forms.Button();
			this.picHinh = new System.Windows.Forms.PictureBox();
			this.txtThongtin = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.optNu = new System.Windows.Forms.RadioButton();
			this.optNam = new System.Windows.Forms.RadioButton();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenDG = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaDG = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.btnXoaHinh);
			this.groupBox1.Controls.Add(this.picHinh);
			this.groupBox1.Controls.Add(this.txtThongtin);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtNgaySinh);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDC);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtTenDG);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtMaDG);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(36, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 353);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnXoaHinh
			// 
			this.btnXoaHinh.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnXoaHinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnXoaHinh.Location = new System.Drawing.Point(328, 112);
			this.btnXoaHinh.Name = "btnXoaHinh";
			this.btnXoaHinh.Size = new System.Drawing.Size(32, 24);
			this.btnXoaHinh.TabIndex = 15;
			this.btnXoaHinh.Text = "X";
			// 
			// picHinh
			// 
			this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picHinh.Location = new System.Drawing.Point(304, 16);
			this.picHinh.Name = "picHinh";
			this.picHinh.Size = new System.Drawing.Size(72, 88);
			this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picHinh.TabIndex = 14;
			this.picHinh.TabStop = false;
			// 
			// txtThongtin
			// 
			this.txtThongtin.Location = new System.Drawing.Point(96, 296);
			this.txtThongtin.MaxLength = 1000;
			this.txtThongtin.Multiline = true;
			this.txtThongtin.Name = "txtThongtin";
			this.txtThongtin.Size = new System.Drawing.Size(280, 48);
			this.txtThongtin.TabIndex = 13;
			this.txtThongtin.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Thông tin khác";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.optNu);
			this.groupBox2.Controls.Add(this.optNam);
			this.groupBox2.Location = new System.Drawing.Point(24, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(160, 56);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Giới tính";
			// 
			// optNu
			// 
			this.optNu.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optNu.Location = new System.Drawing.Point(72, 24);
			this.optNu.Name = "optNu";
			this.optNu.Size = new System.Drawing.Size(64, 16);
			this.optNu.TabIndex = 1;
			this.optNu.Text = "Nữ";
			// 
			// optNam
			// 
			this.optNam.Checked = true;
			this.optNam.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optNam.Location = new System.Drawing.Point(8, 24);
			this.optNam.Name = "optNam";
			this.optNam.Size = new System.Drawing.Size(64, 16);
			this.optNam.TabIndex = 0;
			this.optNam.TabStop = true;
			this.optNam.Text = "Nam";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(88, 152);
			this.txtEmail.MaxLength = 50;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(168, 20);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "EMail";
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgaySinh.Location = new System.Drawing.Point(88, 120);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.Size = new System.Drawing.Size(112, 20);
			this.dtNgaySinh.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ngày sinh";
			// 
			// txtDC
			// 
			this.txtDC.Location = new System.Drawing.Point(88, 88);
			this.txtDC.MaxLength = 100;
			this.txtDC.Name = "txtDC";
			this.txtDC.Size = new System.Drawing.Size(192, 20);
			this.txtDC.TabIndex = 5;
			this.txtDC.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ";
			// 
			// txtTenDG
			// 
			this.txtTenDG.Location = new System.Drawing.Point(88, 56);
			this.txtTenDG.MaxLength = 50;
			this.txtTenDG.Name = "txtTenDG";
			this.txtTenDG.Size = new System.Drawing.Size(128, 20);
			this.txtTenDG.TabIndex = 3;
			this.txtTenDG.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên độc giả";
			// 
			// txtMaDG
			// 
			this.txtMaDG.Location = new System.Drawing.Point(88, 16);
			this.txtMaDG.MaxLength = 10;
			this.txtMaDG.Name = "txtMaDG";
			this.txtMaDG.Size = new System.Drawing.Size(88, 20);
			this.txtMaDG.TabIndex = 1;
			this.txtMaDG.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã độc giả";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoat.Location = new System.Drawing.Point(224, 376);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(48, 40);
			this.btnThoat.TabIndex = 17;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmChiTietDG
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(472, 422);
			this.ControlBox = false;
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChiTietDG";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiet";
			this.Load += new System.EventHandler(this.frmChiTietDG_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmChiTietDG_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
