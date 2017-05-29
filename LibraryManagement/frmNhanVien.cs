using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmNhanVien.
	/// </summary>
	public class frmNhanVien : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picHinh;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton optNu;
		private System.Windows.Forms.RadioButton optNam;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.DateTimePicker dtNgayVao;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.ComponentModel.IContainer components;

		private int opt=0;
		private System.Windows.Forms.ListView lvNhanVien;
		private System.Windows.Forms.Button btnXoaHinh;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.TextBox txtGoLai;
		private System.Windows.Forms.Label lblGoLai;
		private System.Windows.Forms.Button btnDoiMM;
		private System.Windows.Forms.GroupBox groupMatMa;
		private System.Windows.Forms.TextBox txtDanhLai;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMatMaMoi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMaMaCu;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCanCel;
		private DotNetSkin.SkinControls.SkinButton btnXoa;
		private DotNetSkin.SkinControls.SkinButton btnSua;
		private DotNetSkin.SkinControls.SkinButton btnLuu;
		private DotNetSkin.SkinControls.SkinButton btnBoqua;
		private DotNetSkin.SkinControls.SkinButton btnThoát;
		private DotNetSkin.SkinControls.SkinButton btnThem;
		public string filename="";

		public frmNhanVien()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiNhanVien();
			SetControlVisible(false);
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
		void HienThiNhanVien()
		{
			picHinh.Image=null;
			try
			{
				DataTable dtNhanVien=SqlHelper.ExecuteDataTable(
					"Pro_NhanVien",
					CommandType.StoredProcedure);
				int i=1;
				lvNhanVien.Items.Clear();
				txtMaNV.Text=dtNhanVien.Rows[0]["MSNV"].ToString();
				txtMatKhau.Text=dtNhanVien.Rows[0]["MATMA"].ToString();
				txtTenNV.Text=dtNhanVien.Rows[0]["HOTENNV"].ToString();
				txtDC.Text=dtNhanVien.Rows[0]["DIACHINV"].ToString();
				
				dtNgaySinh.Value=(DateTime)dtNhanVien.Rows[0]["NGAYSINHNV"];
				if(dtNhanVien.Rows[0]["GIOITINHNV"].ToString()=="1")
				{
					optNam.Checked=true;
				}
				else
				{
					optNu.Checked=true;
				}
				txtDienThoai.Text=dtNhanVien.Rows[0]["DIENTHOAINV"].ToString();
				txtEmail.Text=dtNhanVien.Rows[0]["EMAILNV"].ToString();
				
				dtNgayVao.Value=(DateTime)dtNhanVien.Rows[0]["NGAYVAOLAM"];
				try
				{
					if(dtNhanVien.Rows[0]["HINHANHNV"].ToString()!="")
					{
						filename=dtNhanVien.Rows[0]["HINHANHNV"].ToString();
						picHinh.Image=new Bitmap(Application.StartupPath+"\\hinh\\"+filename);

					}
					else
					{
						filename="";
						picHinh.Image=null;
					}
				}
				catch{}

				foreach(DataRow row in dtNhanVien.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["MSNV"].ToString());
					item.SubItems.Add(row["HOTENNV"].ToString());
					item.SubItems.Add(row["DIACHINV"].ToString());
					item.SubItems.Add(row["NGAYSINHNV"].ToString());
					item.SubItems.Add(row["GIOITINHNV"].ToString());
					item.SubItems.Add(row["DIENTHOAINV"].ToString());
					item.SubItems.Add(row["EMAILNV"].ToString());
					item.SubItems.Add(row["NGAYVAOLAM"].ToString());
					item.SubItems.Add(row["HINHANHNV"].ToString());
					item.SubItems.Add(row["MATMA"].ToString());
					lvNhanVien.Items.Add(item);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void SetControlVisible(bool b)
		{
			txtMaNV.ReadOnly=!b;
			txtMatKhau.ReadOnly=!b;
			lblGoLai.Visible=b;
			txtGoLai.Visible=b;
			txtTenNV.ReadOnly=!b;
			txtDC.ReadOnly=!b;
			txtEmail.ReadOnly=!b;
			txtDienThoai.ReadOnly=!b;
			optNam.Enabled=b;
			optNu.Enabled=b;
			dtNgaySinh.Enabled=b;
			dtNgayVao.Enabled=b;
			btnDoiMM.Visible=!b;
			btnThem.Enabled=!b;
			btnXoa.Enabled=!b;
			btnSua.Enabled=!b;
			btnLuu.Enabled=b;
			btnBoqua.Enabled=b;
			picHinh.Enabled=b;
			btnXoaHinh.Visible=b;
		}
		void SetNull()
		{
			txtMaNV.Text="";
			txtMatKhau.Text="";
			txtTenNV.Text="";
			txtDC.Text="";
			dtNgaySinh.Value=DateTime.Now;
			dtNgayVao.Value=DateTime.Now;
			txtEmail.Text="";
			optNam.Checked=true;
			txtDienThoai.Text="";
			picHinh.Image=null;
			
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmNhanVien));
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lvNhanVien = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupMatMa = new System.Windows.Forms.GroupBox();
			this.btnCanCel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtMaMaCu = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtDanhLai = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMatMaMoi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnDoiMM = new System.Windows.Forms.Button();
			this.txtGoLai = new System.Windows.Forms.TextBox();
			this.lblGoLai = new System.Windows.Forms.Label();
			this.btnXoaHinh = new System.Windows.Forms.Button();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.dtNgayVao = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.picHinh = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.optNu = new System.Windows.Forms.RadioButton();
			this.optNam = new System.Windows.Forms.RadioButton();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnThem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.btnBoqua = new DotNetSkin.SkinControls.SkinButton();
			this.btnLuu = new DotNetSkin.SkinControls.SkinButton();
			this.btnSua = new DotNetSkin.SkinControls.SkinButton();
			this.btnXoa = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.groupMatMa.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Dien thoai";
			this.columnHeader7.Width = 0;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã NV";
			this.columnHeader2.Width = 100;
			// 
			// lvNhanVien
			// 
			this.lvNhanVien.BackColor = System.Drawing.Color.White;
			this.lvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader1,
																						 this.columnHeader2,
																						 this.columnHeader3,
																						 this.columnHeader4,
																						 this.columnHeader5,
																						 this.columnHeader6,
																						 this.columnHeader7,
																						 this.columnHeader8,
																						 this.columnHeader9,
																						 this.columnHeader10});
			this.lvNhanVien.FullRowSelect = true;
			this.lvNhanVien.GridLines = true;
			this.lvNhanVien.Location = new System.Drawing.Point(8, 0);
			this.lvNhanVien.Name = "lvNhanVien";
			this.lvNhanVien.Size = new System.Drawing.Size(352, 448);
			this.lvNhanVien.TabIndex = 6;
			this.lvNhanVien.View = System.Windows.Forms.View.Details;
			this.lvNhanVien.Click += new System.EventHandler(this.lvNhanVien_Click);
			this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Nhân viên";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Địa chỉ";
			this.columnHeader4.Width = 200;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày sinh";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Giới tính";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Email";
			this.columnHeader8.Width = 0;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "NgayVaoLam";
			this.columnHeader9.Width = 0;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Matma";
			this.columnHeader10.Width = 0;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.groupMatMa);
			this.groupBox1.Controls.Add(this.btnDoiMM);
			this.groupBox1.Controls.Add(this.txtGoLai);
			this.groupBox1.Controls.Add(this.lblGoLai);
			this.groupBox1.Controls.Add(this.btnXoaHinh);
			this.groupBox1.Controls.Add(this.txtMatKhau);
			this.groupBox1.Controls.Add(this.lblMatKhau);
			this.groupBox1.Controls.Add(this.dtNgayVao);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.picHinh);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtNgaySinh);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDC);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtTenNV);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(360, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 448);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupMatMa
			// 
			this.groupMatMa.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupMatMa.Controls.Add(this.btnCanCel);
			this.groupMatMa.Controls.Add(this.btnOK);
			this.groupMatMa.Controls.Add(this.txtMaMaCu);
			this.groupMatMa.Controls.Add(this.label10);
			this.groupMatMa.Controls.Add(this.txtDanhLai);
			this.groupMatMa.Controls.Add(this.label8);
			this.groupMatMa.Controls.Add(this.txtMatMaMoi);
			this.groupMatMa.Controls.Add(this.label9);
			this.groupMatMa.Location = new System.Drawing.Point(176, 88);
			this.groupMatMa.Name = "groupMatMa";
			this.groupMatMa.Size = new System.Drawing.Size(232, 128);
			this.groupMatMa.TabIndex = 26;
			this.groupMatMa.TabStop = false;
			this.groupMatMa.Visible = false;
			// 
			// btnCanCel
			// 
			this.btnCanCel.Location = new System.Drawing.Point(128, 96);
			this.btnCanCel.Name = "btnCanCel";
			this.btnCanCel.Size = new System.Drawing.Size(56, 24);
			this.btnCanCel.TabIndex = 32;
			this.btnCanCel.Text = "Bỏ qua";
			this.btnCanCel.Click += new System.EventHandler(this.btnCanCel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(64, 96);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(56, 24);
			this.btnOK.TabIndex = 31;
			this.btnOK.Text = "Đồng ý";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtMaMaCu
			// 
			this.txtMaMaCu.Location = new System.Drawing.Point(96, 16);
			this.txtMaMaCu.Name = "txtMaMaCu";
			this.txtMaMaCu.PasswordChar = '*';
			this.txtMaMaCu.Size = new System.Drawing.Size(128, 20);
			this.txtMaMaCu.TabIndex = 30;
			this.txtMaMaCu.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 16);
			this.label10.TabIndex = 29;
			this.label10.Text = "Mật mã cũ";
			// 
			// txtDanhLai
			// 
			this.txtDanhLai.Location = new System.Drawing.Point(96, 72);
			this.txtDanhLai.Name = "txtDanhLai";
			this.txtDanhLai.PasswordChar = '*';
			this.txtDanhLai.Size = new System.Drawing.Size(128, 20);
			this.txtDanhLai.TabIndex = 28;
			this.txtDanhLai.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "Gõ lại";
			// 
			// txtMatMaMoi
			// 
			this.txtMatMaMoi.Location = new System.Drawing.Point(96, 48);
			this.txtMatMaMoi.Name = "txtMatMaMoi";
			this.txtMatMaMoi.PasswordChar = '*';
			this.txtMatMaMoi.Size = new System.Drawing.Size(128, 20);
			this.txtMatMaMoi.TabIndex = 26;
			this.txtMatMaMoi.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 25;
			this.label9.Text = "Mật mã mới";
			// 
			// btnDoiMM
			// 
			this.btnDoiMM.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDoiMM.Location = new System.Drawing.Point(336, 64);
			this.btnDoiMM.Name = "btnDoiMM";
			this.btnDoiMM.Size = new System.Drawing.Size(72, 24);
			this.btnDoiMM.TabIndex = 25;
			this.btnDoiMM.Text = "Đổi mật mã";
			this.btnDoiMM.Click += new System.EventHandler(this.btnDoiMM_Click);
			// 
			// txtGoLai
			// 
			this.txtGoLai.Location = new System.Drawing.Point(200, 88);
			this.txtGoLai.Name = "txtGoLai";
			this.txtGoLai.PasswordChar = '*';
			this.txtGoLai.Size = new System.Drawing.Size(128, 20);
			this.txtGoLai.TabIndex = 24;
			this.txtGoLai.Text = "";
			// 
			// lblGoLai
			// 
			this.lblGoLai.BackColor = System.Drawing.Color.Transparent;
			this.lblGoLai.Location = new System.Drawing.Point(112, 88);
			this.lblGoLai.Name = "lblGoLai";
			this.lblGoLai.Size = new System.Drawing.Size(88, 16);
			this.lblGoLai.TabIndex = 23;
			this.lblGoLai.Text = "Gõ lại Mật mã";
			// 
			// btnXoaHinh
			// 
			this.btnXoaHinh.BackColor = System.Drawing.SystemColors.GrayText;
			this.btnXoaHinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnXoaHinh.Location = new System.Drawing.Point(40, 152);
			this.btnXoaHinh.Name = "btnXoaHinh";
			this.btnXoaHinh.Size = new System.Drawing.Size(24, 24);
			this.btnXoaHinh.TabIndex = 22;
			this.btnXoaHinh.Text = "X";
			this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(200, 64);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(128, 20);
			this.txtMatKhau.TabIndex = 21;
			this.txtMatKhau.Text = "";
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.Location = new System.Drawing.Point(112, 72);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(80, 16);
			this.lblMatKhau.TabIndex = 20;
			this.lblMatKhau.Text = "Mật mã";
			// 
			// dtNgayVao
			// 
			this.dtNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgayVao.Location = new System.Drawing.Point(200, 344);
			this.dtNgayVao.Name = "dtNgayVao";
			this.dtNgayVao.Size = new System.Drawing.Size(112, 20);
			this.dtNgayVao.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(112, 344);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 18;
			this.label6.Text = "Ngày vào làm";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Location = new System.Drawing.Point(200, 280);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(104, 20);
			this.txtDienThoai.TabIndex = 17;
			this.txtDienThoai.Text = "";
			this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(112, 280);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Điện thoại";
			// 
			// picHinh
			// 
			this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picHinh.Location = new System.Drawing.Point(16, 56);
			this.picHinh.Name = "picHinh";
			this.picHinh.Size = new System.Drawing.Size(72, 88);
			this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picHinh.TabIndex = 14;
			this.picHinh.TabStop = false;
			this.picHinh.Click += new System.EventHandler(this.picHinh_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.optNu);
			this.groupBox2.Controls.Add(this.optNam);
			this.groupBox2.Location = new System.Drawing.Point(136, 216);
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
			this.txtEmail.Location = new System.Drawing.Point(200, 312);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(168, 20);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(112, 312);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "EMail";
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgaySinh.Location = new System.Drawing.Point(200, 184);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.Size = new System.Drawing.Size(112, 20);
			this.dtNgaySinh.TabIndex = 7;
			this.dtNgaySinh.ValueChanged += new System.EventHandler(this.dtNgaySinh_ValueChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(112, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ngày sinh";
			// 
			// txtDC
			// 
			this.txtDC.Location = new System.Drawing.Point(200, 152);
			this.txtDC.Name = "txtDC";
			this.txtDC.Size = new System.Drawing.Size(192, 20);
			this.txtDC.TabIndex = 5;
			this.txtDC.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(112, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ";
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(200, 120);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(128, 20);
			this.txtTenNV.TabIndex = 3;
			this.txtTenNV.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên nhân viên";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(200, 32);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(88, 20);
			this.txtMaNV.TabIndex = 1;
			this.txtMaNV.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Nhân viên";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnThoát);
			this.groupBox3.Controls.Add(this.btnBoqua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Location = new System.Drawing.Point(360, 400);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 56);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThem.Location = new System.Drawing.Point(48, 8);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(48, 40);
			this.btnThem.TabIndex = 17;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnThoát
			// 
			this.btnThoát.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThoát.Image = ((System.Drawing.Image)(resources.GetObject("btnThoát.Image")));
			this.btnThoát.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoát.Location = new System.Drawing.Point(328, 8);
			this.btnThoát.Name = "btnThoát";
			this.btnThoát.Size = new System.Drawing.Size(48, 40);
			this.btnThoát.TabIndex = 16;
			this.btnThoát.Text = "Thoát";
			this.btnThoát.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoát.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnBoqua
			// 
			this.btnBoqua.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
			this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBoqua.Location = new System.Drawing.Point(272, 8);
			this.btnBoqua.Name = "btnBoqua";
			this.btnBoqua.Size = new System.Drawing.Size(48, 40);
			this.btnBoqua.TabIndex = 15;
			this.btnBoqua.Text = "Bỏ qua";
			this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLuu.Location = new System.Drawing.Point(216, 8);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(48, 40);
			this.btnLuu.TabIndex = 14;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSua.Location = new System.Drawing.Point(160, 8);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(48, 40);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sữa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnXoa.Location = new System.Drawing.Point(104, 8);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(48, 40);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// frmNhanVien
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lvNhanVien);
			this.Name = "frmNhanVien";
			this.Text = "frmNhanVien";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmNhanVien_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupMatMa.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmNhanVien_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			SetNull();
			lvNhanVien.Enabled=false;
			txtMaNV.Focus();
			opt=1;
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			txtMaNV.ReadOnly=true;
			txtTenNV.Focus();
			txtMatKhau.ReadOnly=true;
			lblGoLai.Visible=false;
			txtGoLai.Visible=false;
			opt=2;
		}

		private void btnBoqua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			lvNhanVien.Enabled=true;
			HienThiNhanVien();
		}

		private void btnLuu_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(txtMaNV.Text==""||txtTenNV.Text==""||txtMatKhau.Text=="")
				{
					MessageBox.Show(this,"Bạn chưa nhập thông tin cần thiết","Thong bao");
					return;
				}
				if(dtNgaySinh.Value.Year>=DateTime.Now.Year-18 || dtNgaySinh.Value.Year <=DateTime.Now.Year-40)
				{
					MessageBox.Show(this,"Tuổi >=18 và <=40","Thong bao");
					return;
				}
				if(opt==1)
				{
					if(!txtMatKhau.Text.Equals(txtGoLai.Text))
					{
						MessageBox.Show(this,"Mật khẩu gõ lại không đúng","Thong bao");
						return;
					}
				}

				string gt=optNam.Checked?"1":"0";
				

				SqlHelper.ExecuteNonQuery(
					"Pro_InsertNhanVien",
					CommandType.StoredProcedure,
					"@option",opt,
					"@msnv",txtMaNV.Text.Trim(),
				    "@matma",txtMatKhau.Text.Trim(),
					"@hotennv",txtTenNV.Text.Trim(),
					"@diachinv",txtDC.Text.Trim(),
					"@ngaysinhnv",dtNgaySinh.Value,
					"@gioitinhnv",gt,
					"@dienthoainv",txtDienThoai.Text.Trim(),
					"@emailnv",txtEmail.Text.Trim(),				
					"@ngayvaolam",dtNgayVao.Value,
					"@hinhanhnv",filename);
					

				HienThiNhanVien();
				SetControlVisible(false);
				lvNhanVien.Enabled=true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void picHinh_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg=new OpenFileDialog();
			dlg.InitialDirectory=Application.StartupPath+@"\hinh";
			if(dlg.ShowDialog()==DialogResult.OK)
			{

				filename=dlg.FileName.Substring(dlg.FileName.LastIndexOf("\\")+1,12);
				try
				{
					picHinh.Image=new Bitmap(Application.StartupPath+@"\hinh\"+filename);
				}
				catch
				{
					MessageBox.Show(this,"Hình chọn không đúng","Information");
				}
			}
		}

		private void lvNhanVien_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			if (lvNhanVien.SelectedItems.Count==0)
				return;
			txtMaNV.Text=lvNhanVien.SelectedItems[0].SubItems[1].Text;
			txtMatKhau.Text=lvNhanVien.SelectedItems[0].SubItems[10].Text;
			txtTenNV.Text=lvNhanVien.SelectedItems[0].SubItems[2].Text;
			txtDC.Text=lvNhanVien.SelectedItems[0].SubItems[3].Text;
			dtNgaySinh.Value=DateTime.Parse(lvNhanVien.SelectedItems[0].SubItems[4].Text);
			if(lvNhanVien.SelectedItems[0].SubItems[5].Text=="1")
			{
				optNam.Checked=true;
			}
			else{ optNu.Checked=true;}
			txtDienThoai.Text=lvNhanVien.SelectedItems[0].SubItems[6].Text;
			txtEmail.Text=lvNhanVien.SelectedItems[0].SubItems[7].Text;
		
			dtNgayVao.Value=DateTime.Parse(lvNhanVien.SelectedItems[0].SubItems[8].Text);
			try
			{
				if(lvNhanVien.SelectedItems[0].SubItems[9].Text!="")
				{
					filename=lvNhanVien.SelectedItems[0].SubItems[9].Text;
					picHinh.Image=new Bitmap(Application.StartupPath+@"\hinh\"+filename);
				}
				else
				{
					filename="";
					picHinh.Image=null;
				}
			}
			catch{}


		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			if (txtMaNV.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này chưa",
				"Delete Employee",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_DeleteNhanVien",
					CommandType.StoredProcedure,
					"@msnv",txtMaNV.Text);

				MessageBox.Show("Nhân viên đã bị xóa");
				HienThiNhanVien();
			}

		}

		private void lvNhanVien_Click(object sender, System.EventArgs e)
		{
			
		}

		private void btnXoaHinh_Click(object sender, System.EventArgs e)
		{
			if(filename!="")
			{
				filename="";
				picHinh.Image=null;
			}
		}

		private void txtDienThoai_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(txtDienThoai.Text!="")
				{
					int i=Int32.Parse(txtDienThoai.Text);
				}
			}
			catch{
			  MessageBox.Show(this,"Bạn chỉ nhập số","Thong bao");
				txtDienThoai.Text="";
				txtDienThoai.Focus();
				return;
			}

		}

		private void dtNgaySinh_ValueChanged(object sender, System.EventArgs e)
		{
			
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(txtMaMaCu.Text=="" ||txtMatMaMoi.Text==""||txtDanhLai.Text=="")
			{
				MessageBox.Show(this,"Bạn phải nhập hết thông tin","Thong bao");
				return;
			}
			if(!txtMatKhau.Text.Equals(txtMaMaCu.Text))
			{
				MessageBox.Show(this,"Sai mật mã cũ","Thong bao");
				return;
			}
			if(!txtMatMaMoi.Text.Equals(txtDanhLai.Text))
			{
				MessageBox.Show(this,"Mật mã gõ lại bị sai","Thong bao");
				return;
			}
			SqlHelper.ExecuteNonQuery(
					"Pro_UpdateMatMa",
					CommandType.StoredProcedure,
					"@manv",txtMaNV.Text.Trim(),
					"@matma",txtMatMaMoi.Text.Trim());
			MessageBox.Show(this,"Mật mã đã được đổi","Thong bao");
			groupMatMa.Visible=false;
			
		}

		private void btnCanCel_Click(object sender, System.EventArgs e)
		{
			groupMatMa.Visible=false;
		}

		private void btnDoiMM_Click(object sender, System.EventArgs e)
		{	if(groupMatMa.Visible==false)
			groupMatMa.Visible=true;
			else
			 groupMatMa.Visible=false;

		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		
	}
}
