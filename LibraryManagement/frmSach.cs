using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmSach.
	/// </summary>
	public class frmSach : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListView lvSach;
		private System.Windows.Forms.TextBox txtSL;
		private System.Windows.Forms.TextBox txtLanXB;
		private System.Windows.Forms.TextBox txtNamXB;
		private System.Windows.Forms.ComboBox cboLoaiSach;
		private System.Windows.Forms.ComboBox cboNXB;
		private System.Windows.Forms.TextBox txtNoiDungSL;
		private System.Windows.Forms.TextBox txtTacGia;
		private System.Windows.Forms.TextBox txtTenSach;
		private System.Windows.Forms.TextBox txtMaSach;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.GroupBox groupBox3;
		private DotNetSkin.SkinControls.SkinButton btnThem;
		private DotNetSkin.SkinControls.SkinButton btnThoát;
		private DotNetSkin.SkinControls.SkinButton btnBoqua;
		private DotNetSkin.SkinControls.SkinButton btnLuu;
		private DotNetSkin.SkinControls.SkinButton btnSua;
		private DotNetSkin.SkinControls.SkinButton btnXoa;
		private int opt=0;
		public frmSach()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiNXB();
			HienThiLoaiSach();
			HienThiSach();
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
		
		void HienThiNXB()
		{
			try
			{
				DataTable dtNXB=SqlHelper.ExecuteDataTable(
					"Pro_NXB",
					CommandType.StoredProcedure);

				cboNXB.DataSource=dtNXB;
				cboNXB.DisplayMember="TENNXB";
				cboNXB.ValueMember="MSNHAXB";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void HienThiLoaiSach()
		{
			try
			{
				DataTable dtLoaiSach=SqlHelper.ExecuteDataTable(
					"Pro_LoaiSach",
					CommandType.StoredProcedure);
				cboLoaiSach.DataSource=dtLoaiSach;
				cboLoaiSach.DisplayMember="LOAISACH";
				cboLoaiSach.ValueMember="MALOAISACH";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void HienThiSach()
		{
			try
			{
				DataTable dtSach=SqlHelper.ExecuteDataTable(
					"Pro_Sach",
					CommandType.StoredProcedure);
				int i=1;
				lvSach.Items.Clear();
				txtMaSach.Text=dtSach.Rows[0]["MSSACH"].ToString();
				txtTenSach.Text=dtSach.Rows[0]["TENSACH"].ToString();
				txtTacGia.Text=dtSach.Rows[0]["TACGIA"].ToString();
				cboNXB.SelectedValue=dtSach.Rows[0]["MSNHAXB"].ToString();
				cboLoaiSach.SelectedValue=dtSach.Rows[0]["MALOAISACH"].ToString();
				txtNamXB.Text=dtSach.Rows[0]["NAMXB"].ToString();
				txtLanXB.Text=dtSach.Rows[0]["LANXB"].ToString();
				txtSL.Text=dtSach.Rows[0]["SOLUONG"].ToString();
				txtNoiDungSL.Text=dtSach.Rows[0]["NOIDUNGTOMLUOC"].ToString();

				foreach(DataRow row in dtSach.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["MSSACH"].ToString());
					item.SubItems.Add(row["TENSACH"].ToString());
					item.SubItems.Add(row["TACGIA"].ToString());
					item.SubItems.Add(row["MSNHAXB"].ToString());
					item.SubItems.Add(row["MALOAISACH"].ToString());
					item.SubItems.Add(row["NAMXB"].ToString());
					item.SubItems.Add(row["LANXB"].ToString());
					item.SubItems.Add(row["SOLUONG"].ToString());
					item.SubItems.Add(row["NOIDUNGTOMLUOC"].ToString());
					
					lvSach.Items.Add(item);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void SetControlVisible(bool b)
		{
			txtMaSach.ReadOnly=!b;
			txtTenSach.ReadOnly=!b;
			txtTacGia.ReadOnly=!b;
			cboNXB.Enabled=b;
			cboLoaiSach.Enabled=b;
			txtNamXB.ReadOnly=!b;
			txtLanXB.ReadOnly=!b;
			txtSL.ReadOnly=!b;
			txtNoiDungSL.ReadOnly=!b;
			btnThem.Enabled=!b;
			btnXoa.Enabled=!b;
			btnSua.Enabled=!b;
			btnLuu.Enabled=b;
			btnBoqua.Enabled=b;
			
		}
		void SetNull()
		{
			txtMaSach.Text="";
			txtTenSach.Text="";
			txtTacGia.Text="";
			cboNXB.SelectedIndex=-1;
			cboLoaiSach.SelectedIndex=-1;
			txtNamXB.Text="";
			txtLanXB.Text="";
			txtSL.Text="";
			txtNoiDungSL.Text="";
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSach));
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lvSach = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSL = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtLanXB = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNamXB = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboLoaiSach = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboNXB = new System.Windows.Forms.ComboBox();
			this.txtNoiDungSL = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTacGia = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenSach = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaSach = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnThem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.btnBoqua = new DotNetSkin.SkinControls.SkinButton();
			this.btnLuu = new DotNetSkin.SkinControls.SkinButton();
			this.btnSua = new DotNetSkin.SkinControls.SkinButton();
			this.btnXoa = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "NamXB";
			this.columnHeader7.Width = 0;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Sách";
			// 
			// lvSach
			// 
			this.lvSach.BackColor = System.Drawing.Color.White;
			this.lvSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
			this.lvSach.FullRowSelect = true;
			this.lvSach.GridLines = true;
			this.lvSach.Location = new System.Drawing.Point(8, 0);
			this.lvSach.Name = "lvSach";
			this.lvSach.Size = new System.Drawing.Size(360, 448);
			this.lvSach.TabIndex = 6;
			this.lvSach.View = System.Windows.Forms.View.Details;
			this.lvSach.SelectedIndexChanged += new System.EventHandler(this.lvSach_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Sách";
			this.columnHeader3.Width = 500;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tác giả";
			this.columnHeader4.Width = 0;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "MaNXB";
			this.columnHeader5.Width = 0;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "MaLoai";
			this.columnHeader6.Width = 0;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "LanXB";
			this.columnHeader8.Width = 0;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Số lượng";
			this.columnHeader9.Width = 30;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Noidung";
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
			this.groupBox1.Controls.Add(this.txtSL);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtLanXB);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtNamXB);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cboLoaiSach);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboNXB);
			this.groupBox1.Controls.Add(this.txtNoiDungSL);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTacGia);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtTenSach);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtMaSach);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(368, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 384);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// txtSL
			// 
			this.txtSL.Location = new System.Drawing.Point(88, 208);
			this.txtSL.MaxLength = 2;
			this.txtSL.Name = "txtSL";
			this.txtSL.Size = new System.Drawing.Size(48, 20);
			this.txtSL.TabIndex = 22;
			this.txtSL.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Số lượng";
			// 
			// txtLanXB
			// 
			this.txtLanXB.Location = new System.Drawing.Point(256, 176);
			this.txtLanXB.MaxLength = 2;
			this.txtLanXB.Name = "txtLanXB";
			this.txtLanXB.Size = new System.Drawing.Size(48, 20);
			this.txtLanXB.TabIndex = 20;
			this.txtLanXB.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(184, 176);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 19;
			this.label8.Text = "Lần xuất bản";
			// 
			// txtNamXB
			// 
			this.txtNamXB.Location = new System.Drawing.Point(88, 176);
			this.txtNamXB.MaxLength = 4;
			this.txtNamXB.Name = "txtNamXB";
			this.txtNamXB.Size = new System.Drawing.Size(72, 20);
			this.txtNamXB.TabIndex = 18;
			this.txtNamXB.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 17;
			this.label7.Text = "Năm xuất bản";
			// 
			// cboLoaiSach
			// 
			this.cboLoaiSach.Location = new System.Drawing.Point(88, 144);
			this.cboLoaiSach.Name = "cboLoaiSach";
			this.cboLoaiSach.Size = new System.Drawing.Size(112, 21);
			this.cboLoaiSach.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Loại sách";
			// 
			// cboNXB
			// 
			this.cboNXB.Location = new System.Drawing.Point(88, 112);
			this.cboNXB.Name = "cboNXB";
			this.cboNXB.Size = new System.Drawing.Size(144, 21);
			this.cboNXB.TabIndex = 14;
			// 
			// txtNoiDungSL
			// 
			this.txtNoiDungSL.Location = new System.Drawing.Point(24, 288);
			this.txtNoiDungSL.MaxLength = 4000;
			this.txtNoiDungSL.Multiline = true;
			this.txtNoiDungSL.Name = "txtNoiDungSL";
			this.txtNoiDungSL.Size = new System.Drawing.Size(360, 80);
			this.txtNoiDungSL.TabIndex = 13;
			this.txtNoiDungSL.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 264);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Nội dung tóm lược";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Nhà xuất bản";
			// 
			// txtTacGia
			// 
			this.txtTacGia.Location = new System.Drawing.Point(88, 80);
			this.txtTacGia.MaxLength = 2000;
			this.txtTacGia.Name = "txtTacGia";
			this.txtTacGia.Size = new System.Drawing.Size(192, 20);
			this.txtTacGia.TabIndex = 5;
			this.txtTacGia.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tác giả";
			// 
			// txtTenSach
			// 
			this.txtTenSach.Location = new System.Drawing.Point(88, 48);
			this.txtTenSach.MaxLength = 1000;
			this.txtTenSach.Name = "txtTenSach";
			this.txtTenSach.Size = new System.Drawing.Size(128, 20);
			this.txtTenSach.TabIndex = 3;
			this.txtTenSach.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên sách";
			// 
			// txtMaSach
			// 
			this.txtMaSach.Location = new System.Drawing.Point(88, 16);
			this.txtMaSach.MaxLength = 10;
			this.txtMaSach.Name = "txtMaSach";
			this.txtMaSach.Size = new System.Drawing.Size(88, 20);
			this.txtMaSach.TabIndex = 1;
			this.txtMaSach.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sách";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnThoát);
			this.groupBox3.Controls.Add(this.btnBoqua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Location = new System.Drawing.Point(368, 384);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(408, 64);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThem.Location = new System.Drawing.Point(32, 16);
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
			this.btnThoát.Location = new System.Drawing.Point(312, 16);
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
			this.btnBoqua.Location = new System.Drawing.Point(256, 16);
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
			this.btnLuu.Location = new System.Drawing.Point(200, 16);
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
			this.btnSua.Location = new System.Drawing.Point(144, 16);
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
			this.btnXoa.Location = new System.Drawing.Point(88, 16);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(48, 40);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// frmSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lvSach);
			this.Controls.Add(this.groupBox3);
			this.Name = "frmSach";
			this.Text = "Sach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSach_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSach_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			SetNull();
			lvSach.Enabled=false;
			txtMaSach.Focus();
			opt=1;
		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			if (txtMaSach.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc xóa Sách này không?",
				"Delete Book",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_DeleteSach",
					CommandType.StoredProcedure,
					"@mssach",txtMaSach.Text);

				MessageBox.Show("Thông tin Sách này đã bị xóa");
				HienThiSach();
			}
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			txtMaSach.ReadOnly=true;
			txtTenSach.Focus();
			opt=2;
		}

		private void btnLuu_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(txtMaSach.Text=="")
				{
					MessageBox.Show(this,"Bạn chưa nhập mã sách","Thông báo");
					return;
				}
				SqlHelper.ExecuteNonQuery(
					"Pro_InsertSach",
					CommandType.StoredProcedure,
					"@option",opt,
					"@mssach",txtMaSach.Text.Trim(),
					"@tensach",txtTenSach.Text.Trim(),
					"@tacgia",txtTacGia.Text.Trim(),
					"@manxb",cboNXB.SelectedValue.ToString(),
					"@maloai",cboLoaiSach.SelectedValue.ToString(),
					"@namxb",txtNamXB.Text.Trim(),
					"@lanxb",txtLanXB.Text.Trim(),
					"@sl",txtSL.Text.Trim(),
					"@nd",txtNoiDungSL.Text.Trim());
					
					
				HienThiSach();
				SetControlVisible(false);
				lvSach.Enabled=true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBoqua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			lvSach.Enabled=true;
			HienThiSach();
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void lvSach_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvSach.SelectedItems.Count==0)
				return;
			txtMaSach.Text=lvSach.SelectedItems[0].SubItems[1].Text;
			txtTenSach.Text=lvSach.SelectedItems[0].SubItems[2].Text;
			txtTacGia.Text=lvSach.SelectedItems[0].SubItems[3].Text;
			cboNXB.SelectedValue=lvSach.SelectedItems[0].SubItems[4].Text;
			cboLoaiSach.SelectedValue=lvSach.SelectedItems[0].SubItems[5].Text;
			txtNamXB.Text=lvSach.SelectedItems[0].SubItems[6].Text;
			txtLanXB.Text=lvSach.SelectedItems[0].SubItems[7].Text;
			txtSL.Text=lvSach.SelectedItems[0].SubItems[8].Text;
			txtNoiDungSL.Text=lvSach.SelectedItems[0].SubItems[9].Text;
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

	}
}
