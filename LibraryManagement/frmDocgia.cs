using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmDocgia.
	/// </summary>
	
	public class frmDocgia : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox picHinh;
		private System.Windows.Forms.ListView lvDocgia;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox txtThongtin;
		private System.Windows.Forms.RadioButton optNu;
		private System.Windows.Forms.RadioButton optNam;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.TextBox txtDC;
		private System.Windows.Forms.TextBox txtTenDG;
		private System.Windows.Forms.TextBox txtMaDG;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		private int opt=0;
		private System.Windows.Forms.Button btnXoaHinh;
		private System.Windows.Forms.GroupBox groupBox3;
		private DotNetSkin.SkinControls.SkinButton btnThem;
		private DotNetSkin.SkinControls.SkinButton btnThoát;
		private DotNetSkin.SkinControls.SkinButton btnBoqua;
		private DotNetSkin.SkinControls.SkinButton btnLuu;
		private DotNetSkin.SkinControls.SkinButton btnSua;
		private DotNetSkin.SkinControls.SkinButton btnXoa;
		public string filename="";

		public frmDocgia()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiDocGia();
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDocgia));
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
			this.lvDocgia = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnThem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.btnBoqua = new DotNetSkin.SkinControls.SkinButton();
			this.btnLuu = new DotNetSkin.SkinControls.SkinButton();
			this.btnSua = new DotNetSkin.SkinControls.SkinButton();
			this.btnXoa = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.groupBox1.Location = new System.Drawing.Point(376, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 392);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "nv";
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
			this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);
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
			this.picHinh.Click += new System.EventHandler(this.picHinh_Click);
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
			this.dtNgaySinh.ValueChanged += new System.EventHandler(this.dtNgaySinh_ValueChanged);
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
			// lvDocgia
			// 
			this.lvDocgia.BackColor = System.Drawing.Color.White;
			this.lvDocgia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvDocgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2,
																					   this.columnHeader3,
																					   this.columnHeader4,
																					   this.columnHeader5,
																					   this.columnHeader6,
																					   this.columnHeader7,
																					   this.columnHeader9,
																					   this.columnHeader10});
			this.lvDocgia.FullRowSelect = true;
			this.lvDocgia.GridLines = true;
			this.lvDocgia.Location = new System.Drawing.Point(8, 0);
			this.lvDocgia.Name = "lvDocgia";
			this.lvDocgia.Size = new System.Drawing.Size(368, 456);
			this.lvDocgia.TabIndex = 2;
			this.lvDocgia.View = System.Windows.Forms.View.Details;
			this.lvDocgia.SelectedIndexChanged += new System.EventHandler(this.lvDocgia_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã DG";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên độc giả";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Địa chỉ";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 200;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày sinh";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Email";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Gioitinh";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 0;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Thongtinkhac";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 0;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "hinh";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader10.Width = 0;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnThoát);
			this.groupBox3.Controls.Add(this.btnBoqua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Location = new System.Drawing.Point(376, 392);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(408, 56);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThem.Location = new System.Drawing.Point(16, 8);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(64, 40);
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
			this.btnThoát.Location = new System.Drawing.Point(336, 8);
			this.btnThoát.Name = "btnThoát";
			this.btnThoát.Size = new System.Drawing.Size(64, 40);
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
			this.btnBoqua.Size = new System.Drawing.Size(64, 40);
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
			this.btnLuu.Location = new System.Drawing.Point(208, 8);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(64, 40);
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
			this.btnSua.Location = new System.Drawing.Point(144, 8);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(64, 40);
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
			this.btnXoa.Location = new System.Drawing.Point(80, 8);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(64, 40);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// frmDocgia
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.lvDocgia);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmDocgia";
			this.Text = "frmDocgia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmDocgia_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region Methods
		void HienThiDocGia()
		{
			try
			{
				DataTable dtDocgia=SqlHelper.ExecuteDataTable(
					"Pro_DocGia",
					CommandType.StoredProcedure);
				int i=1;
				lvDocgia.Items.Clear();
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

				foreach(DataRow row in dtDocgia.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["MSDG"].ToString());
					item.SubItems.Add(row["TENDG"].ToString());
					item.SubItems.Add(row["DIACHI"].ToString());
					item.SubItems.Add(row["NGAYSINH"].ToString());
					item.SubItems.Add(row["EMAIL"].ToString());
					item.SubItems.Add(row["GIOITINH"].ToString());
					item.SubItems.Add(row["THONGTINKHAC"].ToString());
					item.SubItems.Add(row["HINHANHDG"].ToString());
					
					lvDocgia.Items.Add(item);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void SetControlVisible(bool b)
		{
			txtMaDG.ReadOnly=!b;
			txtTenDG.ReadOnly=!b;
			txtDC.ReadOnly=!b;
			txtEmail.ReadOnly=!b;
			txtThongtin.ReadOnly=!b;
			optNam.Enabled=b;
			optNu.Enabled=b;
			dtNgaySinh.Enabled=b;
			btnThem.Enabled=!b;
			btnXoa.Enabled=!b;
			btnSua.Enabled=!b;
			btnLuu.Enabled=b;
			btnBoqua.Enabled=b;
			btnXoaHinh.Visible=b;
			picHinh.Enabled=b;
		}
		void SetNull()
		{
			txtMaDG.Text="";
			txtTenDG.Text="";
			txtDC.Text="";
			dtNgaySinh.Value=DateTime.Now;
			txtEmail.Text="";
			optNam.Checked=true;
			txtThongtin.Text="";
			picHinh.Image=null;
		}
		#endregion

		private void frmDocgia_Load(object sender, System.EventArgs e)
		{
		
		}
		static void Main()
		{
			Application.Run(new frmDocgia());
		}

		private void lvDocgia_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			


		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			
		}

		private void btnBoqua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			lvDocgia.Enabled=true;
			HienThiDocGia();
			
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			txtMaDG.ReadOnly=true;
			txtTenDG.Focus();
			opt=2;
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnLuu_Click(object sender, System.EventArgs e)
		{
			
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

		private void btnXoaHinh_Click(object sender, System.EventArgs e)
		{
			if(filename!="")
			{
				filename="";
				picHinh.Image=null;
			}
		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			if (txtMaDG.Text=="")
				return;
			

			DialogResult result=MessageBox.Show("Bạn có chắc xóa độc giả này không?",
				"Delete Reader",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_DeleteDocGia",
					CommandType.StoredProcedure,
					"@madg",txtMaDG.Text);

				MessageBox.Show("Thông tin độc giả đã bị xóa");
				HienThiDocGia();
			}
		}

		private void dtNgaySinh_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		
	}
	
}
