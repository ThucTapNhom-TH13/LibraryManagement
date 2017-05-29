using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmMuonSach.
	/// </summary>
	public class frmMuonSach : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;
		public  string masach="";
		private System.Windows.Forms.TextBox txtNgaySinhDG;
		private System.Windows.Forms.TextBox txtDCDG;
		private System.Windows.Forms.ComboBox cboNhanVien;
		private System.Windows.Forms.ComboBox cboDocGia;
		private System.Windows.Forms.TextBox txtMaPhieu;
		private System.Windows.Forms.DateTimePicker dtNgayMuon;
		public  DateTime hantra=DateTime.Today;
		private System.Windows.Forms.CheckBox chkNXB;
		private System.Windows.Forms.ComboBox cboLoaiSach;
		private System.Windows.Forms.ComboBox cboNXB;
		private System.Windows.Forms.CheckBox chkLoaiSach;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtHanTra;
		private System.Windows.Forms.GroupBox groupSach;
		private System.Windows.Forms.ListView lvDMSach;
		public string tensach="";
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvSach;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.GroupBox groupChiTiet;
		private System.Windows.Forms.Button btnBoQuaChiTiet;
		private System.Windows.Forms.Button btnLuuChiTiet;
		private System.Windows.Forms.Button btnSuaChiTiet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker txtHanTra;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMaSach;
		private System.Windows.Forms.TextBox txtTenSach;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.GroupBox groupBox3;
		private DotNetSkin.SkinControls.SkinButton btnThem;
		private DotNetSkin.SkinControls.SkinButton btnThoát;
		private DotNetSkin.SkinControls.SkinButton btnBoqua;
		private DotNetSkin.SkinControls.SkinButton btnLuu;
		private DotNetSkin.SkinControls.SkinButton btnSua;
		private DotNetSkin.SkinControls.SkinButton btnXoa;
		private DotNetSkin.SkinControls.SkinButton btnTimMaPhieu;
		private DotNetSkin.SkinControls.SkinButton btnBo;
		private DotNetSkin.SkinControls.SkinButton btnMuon;
		private DotNetSkin.SkinControls.SkinButton btnSave;
		private DotNetSkin.SkinControls.SkinButton btnOK;
		private DotNetSkin.SkinControls.SkinButton btnCancel;
		private DotNetSkin.SkinControls.SkinButton btnTimSach;
		
		private System.Windows.Forms.TextBox txtTacGia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtTimTenSach;
		private System.Windows.Forms.TextBox txtMssach;
		private int opt=0;
		public frmMuonSach()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			HienThiLoaiSach();
			HienThiNXB();
			HienThiDocGia();
			HienThiNhanVien();
			HienThiPhieuMuon();
			SetControlVisible(false);
			SetControlChiTiet(false);
			
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
			
				DataTable dtDocGia=SqlHelper.ExecuteDataTable(
					"Pro_DocGia",
					CommandType.StoredProcedure);
				//cboDocGia.Items.Clear();
				cboDocGia.DataSource=dtDocGia;
				cboDocGia.DisplayMember="TENDG";
				cboDocGia.ValueMember="MSDG";

			
			
		}

		void HienThiNhanVien()
		{
			try
			{
				DataTable dtNhanVien=SqlHelper.ExecuteDataTable(
					"Pro_NhanVien",
					CommandType.StoredProcedure);

				//cboNhanVien.Items.Clear();
				cboNhanVien.DataSource=dtNhanVien;
				cboNhanVien.DisplayMember="HOTENNV";
				cboNhanVien.ValueMember="MSNV";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

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
					"Pro_TimSach",
					CommandType.StoredProcedure,
					"@option",opt,
					"@masach",txtMssach.Text.Trim(),
					"@tensach",txtTimTenSach.Text,
					"@tacgia",txtTacGia.Text,
					"@loai",cboLoaiSach.SelectedValue.ToString().Trim(),
					"@manxb",cboNXB.SelectedValue.ToString().Trim());
				
				
				int i=1;
				lvDMSach.Items.Clear();
				
				foreach(DataRow row in dtSach.Rows)
				{
					if(Int32.Parse(row["SOLUONG"].ToString())>0)
					{
						ListViewItem item=new ListViewItem();
						item.Text=""+i++;
						item.SubItems.Add(row["MSSACH"].ToString());
						item.SubItems.Add(row["TENSACH"].ToString());
						item.SubItems.Add(row["SOLUONG"].ToString());
					
						lvDMSach.Items.Add(item);
					}
				}
				

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		
		void HienThiPhieuMuon()
		{
			try
			{
				DataTable dtPhieuMuon=SqlHelper.ExecuteDataTable(
					"Pro_PhieuMuon",
					CommandType.StoredProcedure);
				
				txtMaPhieu.Text=dtPhieuMuon.Rows[0]["SOPHIEUMUON"].ToString();
				cboDocGia.SelectedValue=dtPhieuMuon.Rows[0]["MSDG"].ToString();
				
				//hien thi thong tin Doc gia
				DataTable dtdg=SqlHelper.ExecuteDataTable(
					"Pro_SelectDocGia",
					CommandType.StoredProcedure,"@msdg",cboDocGia.SelectedValue.ToString());
				txtNgaySinhDG.Text=dtdg.Rows[0]["NGAYSINH"].ToString();
				txtDCDG.Text=dtdg.Rows[0]["DIACHI"].ToString();
				//------------------------
				cboNhanVien.SelectedValue=dtPhieuMuon.Rows[0]["MSNV"].ToString();
				dtNgayMuon.Value=(DateTime)dtPhieuMuon.Rows[0]["NGAYMUON"];
				DataTable dtCTPhieuMuon=SqlHelper.ExecuteDataTable(
					"Pro_ChiTietPhieuMuon",
					CommandType.StoredProcedure,"@maphieu",txtMaPhieu.Text.Trim());
				int i=1;
				lvSach.Items.Clear();
				
				foreach(DataRow row in dtCTPhieuMuon.Rows)
				{
						ListViewItem item=new ListViewItem();
						item.Text=""+i++;
						item.SubItems.Add(row["MSSACH"].ToString());

						DataTable dtTenSach=SqlHelper.ExecuteDataTable(
							"Pro_SelectSach",
							CommandType.StoredProcedure,"@mssach",row["MSSACH"].ToString().Trim());
						item.SubItems.Add(dtTenSach.Rows[0]["TENSACH"].ToString());	
					
						item.SubItems.Add(row["HANTRA"].ToString());	
						lvSach.Items.Add(item);
					
				}
				

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
		void HienThiPhieuMuon(string maphieu)
		{
			try
			{
				DataTable dtPhieuMuon=SqlHelper.ExecuteDataTable(
					"Pro_SelectPhieuMuon",
					CommandType.StoredProcedure,"@maphieu",maphieu);
				if(dtPhieuMuon.Rows.Count>0)
				{
					txtMaPhieu.Text=dtPhieuMuon.Rows[0]["SOPHIEUMUON"].ToString();
					cboDocGia.SelectedValue=dtPhieuMuon.Rows[0]["MSDG"].ToString();
				
					//hien thi thong tin Doc gia
					DataTable dtdg=SqlHelper.ExecuteDataTable(
						"Pro_SelectDocGia",
						CommandType.StoredProcedure,"@msdg",cboDocGia.SelectedValue.ToString());
					txtNgaySinhDG.Text=dtdg.Rows[0]["NGAYSINH"].ToString();
					txtDCDG.Text=dtdg.Rows[0]["DIACHI"].ToString();
					//------------------------
					cboNhanVien.SelectedValue=dtPhieuMuon.Rows[0]["MSNV"].ToString();
					dtNgayMuon.Value=(DateTime)dtPhieuMuon.Rows[0]["NGAYMUON"];
					DataTable dtCTPhieuMuon=SqlHelper.ExecuteDataTable(
						"Pro_ChiTietPhieuMuon",
						CommandType.StoredProcedure,"@maphieu",txtMaPhieu.Text.Trim());
					int i=1;
					lvSach.Items.Clear();
				
					foreach(DataRow row in dtCTPhieuMuon.Rows)
					{
						
							ListViewItem item=new ListViewItem();
							item.Text=""+i++;
							item.SubItems.Add(row["MSSACH"].ToString());

							DataTable dtTenSach=SqlHelper.ExecuteDataTable(
								"Pro_SelectSach",
								CommandType.StoredProcedure,"@mssach",row["MSSACH"].ToString().Trim());
							item.SubItems.Add(dtTenSach.Rows[0]["TENSACH"].ToString());	
					
							item.SubItems.Add(row["HANTRA"].ToString());	
							lvSach.Items.Add(item);
						
					}
				}
				else
				{
				
					MessageBox.Show(this,"Mã phiếu mượn không có","Thong bao");
				
					SetNull();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
		void UpdateSL(int choice,string txtms)
		{
			try
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_UpdateSL",
					CommandType.StoredProcedure,
					"@option",choice,
					"@mssach",txtms);		
			}
			catch{}
		}
		void SetNull()
		{
			lvSach.Items.Clear();
			txtMaPhieu.Text="";
			cboDocGia.SelectedIndex=-1;
			cboNhanVien.SelectedIndex=-1;
			dtNgayMuon.Value=DateTime.Now;

		}

		void SetControlVisible(bool b)
		{
			//txtMaPhieu.ReadOnly=!b;
			
			cboDocGia.Enabled=b;
			//cboNhanVien.Enabled=b;
			dtNgayMuon.Enabled=b;
			btnThem.Enabled=!b;
			btnXoa.Enabled=!b;
			btnSua.Enabled=!b;
			btnLuu.Enabled=b;
			btnBoqua.Enabled=b;
			btnTimMaPhieu.Enabled=!b;
			
		}

		void SetControlChiTiet(bool b)
		{
			txtHanTra.Enabled=b;
			btnSuaChiTiet.Enabled=!b;
			btnLuuChiTiet.Enabled=b;
			btnBoQuaChiTiet.Enabled=b;
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMuonSach));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnThem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.btnBoqua = new DotNetSkin.SkinControls.SkinButton();
			this.btnLuu = new DotNetSkin.SkinControls.SkinButton();
			this.btnSua = new DotNetSkin.SkinControls.SkinButton();
			this.btnXoa = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnBo = new DotNetSkin.SkinControls.SkinButton();
			this.btnMuon = new DotNetSkin.SkinControls.SkinButton();
			this.btnSave = new DotNetSkin.SkinControls.SkinButton();
			this.groupChiTiet = new System.Windows.Forms.GroupBox();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnBoQuaChiTiet = new System.Windows.Forms.Button();
			this.btnLuuChiTiet = new System.Windows.Forms.Button();
			this.btnSuaChiTiet = new System.Windows.Forms.Button();
			this.txtMaSach = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtHanTra = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTenSach = new System.Windows.Forms.TextBox();
			this.lvSach = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNgaySinhDG = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDCDG = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboNhanVien = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboDocGia = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaPhieu = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTimMaPhieu = new DotNetSkin.SkinControls.SkinButton();
			this.groupSach = new System.Windows.Forms.GroupBox();
			this.btnTimSach = new DotNetSkin.SkinControls.SkinButton();
			this.btnOK = new DotNetSkin.SkinControls.SkinButton();
			this.btnCancel = new DotNetSkin.SkinControls.SkinButton();
			this.label3 = new System.Windows.Forms.Label();
			this.dtHanTra = new System.Windows.Forms.DateTimePicker();
			this.chkNXB = new System.Windows.Forms.CheckBox();
			this.cboLoaiSach = new System.Windows.Forms.ComboBox();
			this.cboNXB = new System.Windows.Forms.ComboBox();
			this.chkLoaiSach = new System.Windows.Forms.CheckBox();
			this.lvDMSach = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			
			this.txtTacGia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTimTenSach = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMssach = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupChiTiet.SuspendLayout();
			this.groupSach.SuspendLayout();
			this.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.dtNgayMuon);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtNgaySinhDG);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtDCDG);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cboNhanVien);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboDocGia);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtMaPhieu);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnTimMaPhieu);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 472);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnThoát);
			this.groupBox3.Controls.Add(this.btnBoqua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Location = new System.Drawing.Point(64, 176);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(352, 64);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Transparent;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThem.Location = new System.Drawing.Point(16, 16);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(48, 40);
			this.btnThem.TabIndex = 17;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnThoát
			// 
			this.btnThoát.BackColor = System.Drawing.Color.Transparent;
			this.btnThoát.Image = ((System.Drawing.Image)(resources.GetObject("btnThoát.Image")));
			this.btnThoát.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoát.Location = new System.Drawing.Point(296, 16);
			this.btnThoát.Name = "btnThoát";
			this.btnThoát.Size = new System.Drawing.Size(48, 40);
			this.btnThoát.TabIndex = 16;
			this.btnThoát.Text = "Thoát";
			this.btnThoát.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoát.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnBoqua
			// 
			this.btnBoqua.BackColor = System.Drawing.Color.Transparent;
			this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
			this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBoqua.Location = new System.Drawing.Point(240, 16);
			this.btnBoqua.Name = "btnBoqua";
			this.btnBoqua.Size = new System.Drawing.Size(48, 40);
			this.btnBoqua.TabIndex = 15;
			this.btnBoqua.Text = "Bỏ qua";
			this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.Transparent;
			this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLuu.Location = new System.Drawing.Point(184, 16);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(48, 40);
			this.btnLuu.TabIndex = 14;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Transparent;
			this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSua.Location = new System.Drawing.Point(128, 16);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(48, 40);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sữa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnXoa.Location = new System.Drawing.Point(72, 16);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(48, 40);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
			this.groupBox2.Controls.Add(this.btnBo);
			this.groupBox2.Controls.Add(this.btnMuon);
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.groupChiTiet);
			this.groupBox2.Controls.Add(this.lvSach);
			this.groupBox2.Location = new System.Drawing.Point(0, 248);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(744, 224);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chi tiết phiếu mượn";
			// 
			// btnBo
			// 
			this.btnBo.BackColor = System.Drawing.Color.Transparent;
			this.btnBo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBo.Location = new System.Drawing.Point(200, 8);
			this.btnBo.Name = "btnBo";
			this.btnBo.Size = new System.Drawing.Size(56, 24);
			this.btnBo.TabIndex = 38;
			this.btnBo.Text = "Bỏ";
			this.btnBo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBo.Visible = false;
			this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
			// 
			// btnMuon
			// 
			this.btnMuon.BackColor = System.Drawing.Color.Transparent;
			this.btnMuon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMuon.Location = new System.Drawing.Point(360, 8);
			this.btnMuon.Name = "btnMuon";
			this.btnMuon.Size = new System.Drawing.Size(64, 24);
			this.btnMuon.TabIndex = 37;
			this.btnMuon.Text = "Mượn";
			this.btnMuon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSave.Location = new System.Drawing.Point(264, 8);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 24);
			this.btnSave.TabIndex = 36;
			this.btnSave.Text = "Lưu chi tiết";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupChiTiet
			// 
			this.groupChiTiet.Controls.Add(this.btnDong);
			this.groupChiTiet.Controls.Add(this.btnBoQuaChiTiet);
			this.groupChiTiet.Controls.Add(this.btnLuuChiTiet);
			this.groupChiTiet.Controls.Add(this.btnSuaChiTiet);
			this.groupChiTiet.Controls.Add(this.txtMaSach);
			this.groupChiTiet.Controls.Add(this.label10);
			this.groupChiTiet.Controls.Add(this.label11);
			this.groupChiTiet.Controls.Add(this.txtHanTra);
			this.groupChiTiet.Controls.Add(this.label6);
			this.groupChiTiet.Controls.Add(this.txtTenSach);
			this.groupChiTiet.Location = new System.Drawing.Point(448, 16);
			this.groupChiTiet.Name = "groupChiTiet";
			this.groupChiTiet.Size = new System.Drawing.Size(280, 184);
			this.groupChiTiet.TabIndex = 35;
			this.groupChiTiet.TabStop = false;
			this.groupChiTiet.Visible = false;
			// 
			// btnDong
			// 
			this.btnDong.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDong.Location = new System.Drawing.Point(208, 136);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(40, 24);
			this.btnDong.TabIndex = 49;
			this.btnDong.Text = "Đóng";
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnBoQuaChiTiet
			// 
			this.btnBoQuaChiTiet.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnBoQuaChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnBoQuaChiTiet.Location = new System.Drawing.Point(144, 136);
			this.btnBoQuaChiTiet.Name = "btnBoQuaChiTiet";
			this.btnBoQuaChiTiet.Size = new System.Drawing.Size(56, 24);
			this.btnBoQuaChiTiet.TabIndex = 48;
			this.btnBoQuaChiTiet.Text = "Bỏ qua";
			this.btnBoQuaChiTiet.Click += new System.EventHandler(this.btnBoQuaChiTiet_Click);
			// 
			// btnLuuChiTiet
			// 
			this.btnLuuChiTiet.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnLuuChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnLuuChiTiet.Location = new System.Drawing.Point(88, 136);
			this.btnLuuChiTiet.Name = "btnLuuChiTiet";
			this.btnLuuChiTiet.Size = new System.Drawing.Size(48, 24);
			this.btnLuuChiTiet.TabIndex = 47;
			this.btnLuuChiTiet.Text = "Lưu";
			this.btnLuuChiTiet.Click += new System.EventHandler(this.btnLuuChiTiet_Click);
			// 
			// btnSuaChiTiet
			// 
			this.btnSuaChiTiet.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSuaChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSuaChiTiet.Location = new System.Drawing.Point(8, 136);
			this.btnSuaChiTiet.Name = "btnSuaChiTiet";
			this.btnSuaChiTiet.Size = new System.Drawing.Size(72, 24);
			this.btnSuaChiTiet.TabIndex = 45;
			this.btnSuaChiTiet.Text = "Sữa chi tiết";
			this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
			// 
			// txtMaSach
			// 
			this.txtMaSach.Location = new System.Drawing.Point(72, 16);
			this.txtMaSach.Name = "txtMaSach";
			this.txtMaSach.ReadOnly = true;
			this.txtMaSach.Size = new System.Drawing.Size(96, 20);
			this.txtMaSach.TabIndex = 39;
			this.txtMaSach.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 42;
			this.label10.Text = "Tên sách";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 96);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 16);
			this.label11.TabIndex = 43;
			this.label11.Text = "Hạn trả";
			// 
			// txtHanTra
			// 
			this.txtHanTra.CustomFormat = "dd/mm/yyyy";
			this.txtHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtHanTra.Location = new System.Drawing.Point(72, 96);
			this.txtHanTra.Name = "txtHanTra";
			this.txtHanTra.Size = new System.Drawing.Size(112, 20);
			this.txtHanTra.TabIndex = 44;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 40;
			this.label6.Text = "Mã sách";
			// 
			// txtTenSach
			// 
			this.txtTenSach.Location = new System.Drawing.Point(72, 56);
			this.txtTenSach.Name = "txtTenSach";
			this.txtTenSach.ReadOnly = true;
			this.txtTenSach.Size = new System.Drawing.Size(200, 20);
			this.txtTenSach.TabIndex = 41;
			this.txtTenSach.Text = "";
			// 
			// lvSach
			// 
			this.lvSach.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lvSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader3,
																					 this.columnHeader4});
			this.lvSach.FullRowSelect = true;
			this.lvSach.GridLines = true;
			this.lvSach.Location = new System.Drawing.Point(8, 32);
			this.lvSach.Name = "lvSach";
			this.lvSach.Size = new System.Drawing.Size(432, 176);
			this.lvSach.TabIndex = 27;
			this.lvSach.View = System.Windows.Forms.View.Details;
			this.lvSach.Click += new System.EventHandler(this.lvSach_Click);
			this.lvSach.SelectedIndexChanged += new System.EventHandler(this.lvSach_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Sách";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Sách";
			this.columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Hạn trả sách";
			this.columnHeader4.Width = 120;
			// 
			// dtNgayMuon
			// 
			this.dtNgayMuon.CustomFormat = "dd/mm/yyyy";
			this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgayMuon.Location = new System.Drawing.Point(104, 152);
			this.dtNgayMuon.Name = "dtNgayMuon";
			this.dtNgayMuon.Size = new System.Drawing.Size(104, 20);
			this.dtNgayMuon.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Ngày mượn";
			// 
			// txtNgaySinhDG
			// 
			this.txtNgaySinhDG.Location = new System.Drawing.Point(328, 56);
			this.txtNgaySinhDG.Name = "txtNgaySinhDG";
			this.txtNgaySinhDG.ReadOnly = true;
			this.txtNgaySinhDG.Size = new System.Drawing.Size(56, 20);
			this.txtNgaySinhDG.TabIndex = 20;
			this.txtNgaySinhDG.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(272, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 19;
			this.label8.Text = "Ngày sinh";
			// 
			// txtDCDG
			// 
			this.txtDCDG.Location = new System.Drawing.Point(104, 88);
			this.txtDCDG.Name = "txtDCDG";
			this.txtDCDG.ReadOnly = true;
			this.txtDCDG.Size = new System.Drawing.Size(360, 20);
			this.txtDCDG.TabIndex = 18;
			this.txtDCDG.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 17;
			this.label7.Text = "Địa chỉ";
			// 
			// cboNhanVien
			// 
			this.cboNhanVien.Enabled = false;
			this.cboNhanVien.Location = new System.Drawing.Point(104, 120);
			this.cboNhanVien.Name = "cboNhanVien";
			this.cboNhanVien.Size = new System.Drawing.Size(144, 21);
			this.cboNhanVien.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Nhân viên";
			// 
			// cboDocGia
			// 
			this.cboDocGia.Location = new System.Drawing.Point(104, 56);
			this.cboDocGia.Name = "cboDocGia";
			this.cboDocGia.Size = new System.Drawing.Size(144, 21);
			this.cboDocGia.TabIndex = 14;
			this.cboDocGia.Click += new System.EventHandler(this.cboDocGia_Click);
			this.cboDocGia.SelectedIndexChanged += new System.EventHandler(this.cboDocGia_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Họ tên độc giả";
			// 
			// txtMaPhieu
			// 
			this.txtMaPhieu.Location = new System.Drawing.Point(104, 24);
			this.txtMaPhieu.Name = "txtMaPhieu";
			this.txtMaPhieu.Size = new System.Drawing.Size(136, 20);
			this.txtMaPhieu.TabIndex = 1;
			this.txtMaPhieu.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã số phiếu mượn";
			// 
			// btnTimMaPhieu
			// 
			this.btnTimMaPhieu.BackColor = System.Drawing.Color.Transparent;
			this.btnTimMaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimMaPhieu.Image")));
			this.btnTimMaPhieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTimMaPhieu.Location = new System.Drawing.Point(240, 16);
			this.btnTimMaPhieu.Name = "btnTimMaPhieu";
			this.btnTimMaPhieu.Size = new System.Drawing.Size(48, 40);
			this.btnTimMaPhieu.TabIndex = 18;
			this.btnTimMaPhieu.Text = "Tìm";
			this.btnTimMaPhieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTimMaPhieu.Click += new System.EventHandler(this.btnTimMaPhieu_Click);
			// 
			// groupSach
			// 
			this.groupSach.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupSach.Controls.Add(this.txtTacGia);
			this.groupSach.Controls.Add(this.label2);
			this.groupSach.Controls.Add(this.txtTimTenSach);
			this.groupSach.Controls.Add(this.label12);
			this.groupSach.Controls.Add(this.txtMssach);
			this.groupSach.Controls.Add(this.label13);
			this.groupSach.Controls.Add(this.btnTimSach);
			this.groupSach.Controls.Add(this.btnOK);
			this.groupSach.Controls.Add(this.btnCancel);
			this.groupSach.Controls.Add(this.label3);
			this.groupSach.Controls.Add(this.dtHanTra);
			this.groupSach.Controls.Add(this.chkNXB);
			this.groupSach.Controls.Add(this.cboLoaiSach);
			this.groupSach.Controls.Add(this.cboNXB);
			this.groupSach.Controls.Add(this.chkLoaiSach);
			this.groupSach.Controls.Add(this.lvDMSach);
			this.groupSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupSach.Location = new System.Drawing.Point(392, 8);
			this.groupSach.Name = "groupSach";
			this.groupSach.Size = new System.Drawing.Size(400, 472);
			this.groupSach.TabIndex = 12;
			this.groupSach.TabStop = false;
			this.groupSach.Visible = false;
			this.groupSach.Enter += new System.EventHandler(this.groupSach_Enter);
			// 
			// btnTimSach
			// 
			this.btnTimSach.BackColor = System.Drawing.Color.Transparent;
			this.btnTimSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSach.Image")));
			this.btnTimSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTimSach.Location = new System.Drawing.Point(304, 16);
			this.btnTimSach.Name = "btnTimSach";
			this.btnTimSach.Size = new System.Drawing.Size(56, 40);
			this.btnTimSach.TabIndex = 33;
			this.btnTimSach.Text = "Tìm sách";
			this.btnTimSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Transparent;
			this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
			this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOK.Location = new System.Drawing.Point(152, 400);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(56, 40);
			this.btnOK.TabIndex = 32;
			this.btnOK.Text = "Đồng ý";
			this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Transparent;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancel.Location = new System.Drawing.Point(224, 400);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(56, 40);
			this.btnCancel.TabIndex = 31;
			this.btnCancel.Text = "Bỏ qua";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(192, 368);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 30;
			this.label3.Text = "Hạn trả sách";
			// 
			// dtHanTra
			// 
			this.dtHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtHanTra.Location = new System.Drawing.Point(264, 360);
			this.dtHanTra.Name = "dtHanTra";
			this.dtHanTra.Size = new System.Drawing.Size(96, 20);
			this.dtHanTra.TabIndex = 29;
			this.dtHanTra.ValueChanged += new System.EventHandler(this.dtHanTra_ValueChanged);
			// 
			// chkNXB
			// 
			this.chkNXB.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkNXB.Location = new System.Drawing.Point(16, 136);
			this.chkNXB.Name = "chkNXB";
			this.chkNXB.Size = new System.Drawing.Size(64, 16);
			this.chkNXB.TabIndex = 28;
			this.chkNXB.Text = "NXB";
			this.chkNXB.CheckedChanged += new System.EventHandler(this.chkNXB_CheckedChanged);
			// 
			// cboLoaiSach
			// 
			this.cboLoaiSach.Location = new System.Drawing.Point(96, 112);
			this.cboLoaiSach.Name = "cboLoaiSach";
			this.cboLoaiSach.Size = new System.Drawing.Size(128, 21);
			this.cboLoaiSach.TabIndex = 25;
			this.cboLoaiSach.Visible = false;
			// 
			// cboNXB
			// 
			this.cboNXB.Location = new System.Drawing.Point(96, 136);
			this.cboNXB.Name = "cboNXB";
			this.cboNXB.Size = new System.Drawing.Size(200, 21);
			this.cboNXB.TabIndex = 27;
			this.cboNXB.Visible = false;
			// 
			// chkLoaiSach
			// 
			this.chkLoaiSach.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkLoaiSach.Location = new System.Drawing.Point(16, 112);
			this.chkLoaiSach.Name = "chkLoaiSach";
			this.chkLoaiSach.Size = new System.Drawing.Size(80, 16);
			this.chkLoaiSach.TabIndex = 26;
			this.chkLoaiSach.Text = "Loại sách";
			this.chkLoaiSach.CheckedChanged += new System.EventHandler(this.chkLoaiSach_CheckedChanged);
			// 
			// lvDMSach
			// 
			this.lvDMSach.BackColor = System.Drawing.Color.White;
			this.lvDMSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvDMSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader5,
																					   this.columnHeader6,
																					   this.columnHeader7,
																					   this.columnHeader9});
			this.lvDMSach.FullRowSelect = true;
			this.lvDMSach.GridLines = true;
			this.lvDMSach.Location = new System.Drawing.Point(8, 176);
			this.lvDMSach.MultiSelect = false;
			this.lvDMSach.Name = "lvDMSach";
			this.lvDMSach.Size = new System.Drawing.Size(384, 176);
			this.lvDMSach.TabIndex = 18;
			this.lvDMSach.View = System.Windows.Forms.View.Details;
			this.lvDMSach.SelectedIndexChanged += new System.EventHandler(this.lvDMSach_SelectedIndexChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "STT";
			this.columnHeader5.Width = 40;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Mã Sách";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Tên Sách";
			this.columnHeader7.Width = 200;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Số lượng";
			this.columnHeader9.Width = 70;
			// 
			// skinImage
			// 
	
			// 
			// txtTacGia
			// 
			this.txtTacGia.Location = new System.Drawing.Point(104, 80);
			this.txtTacGia.MaxLength = 2000;
			this.txtTacGia.Name = "txtTacGia";
			this.txtTacGia.Size = new System.Drawing.Size(192, 20);
			this.txtTacGia.TabIndex = 46;
			this.txtTacGia.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 45;
			this.label2.Text = "Tác giả";
			// 
			// txtTimTenSach
			// 
			this.txtTimTenSach.Location = new System.Drawing.Point(104, 48);
			this.txtTimTenSach.MaxLength = 1000;
			this.txtTimTenSach.Name = "txtTimTenSach";
			this.txtTimTenSach.Size = new System.Drawing.Size(176, 20);
			this.txtTimTenSach.TabIndex = 44;
			this.txtTimTenSach.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 16);
			this.label12.TabIndex = 43;
			this.label12.Text = "Tên sách";
			// 
			// txtMssach
			// 
			this.txtMssach.Location = new System.Drawing.Point(104, 16);
			this.txtMssach.MaxLength = 10;
			this.txtMssach.Name = "txtMssach";
			this.txtMssach.Size = new System.Drawing.Size(88, 20);
			this.txtMssach.TabIndex = 42;
			this.txtMssach.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 16);
			this.label13.TabIndex = 41;
			this.label13.Text = "Mã sách";
			// 
			// frmMuonSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.groupSach);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmMuonSach";
			this.Text = "Quan ly MuonSach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMuonSach_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupChiTiet.ResumeLayout(false);
			this.groupSach.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnMuon_Click(object sender, System.EventArgs e)
		{
			if(txtMaPhieu.Text=="")
			{
				MessageBox.Show(this,"Bạn nên nhập mã số phiếu mượn trước","Thong bao");
				return;
			}
			

			groupSach.Visible=true;
			//btnMuon.Enabled=false;
			opt=1;
			HienThiSach();
		}

		private void frmMuonSach_Load(object sender, System.EventArgs e)
		{
			
		}

		private void lvDMSach_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvDMSach.SelectedItems.Count==0)
				return;
			masach=lvDMSach.SelectedItems[0].SubItems[1].Text;
			tensach=lvDMSach.SelectedItems[0].SubItems[2].Text;
			foreach(ListViewItem item in lvDMSach.Items)
			{
				item.BackColor=Color.White;
			}
			lvDMSach.SelectedItems[0].BackColor=SystemColors.ControlDark;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			groupSach.Visible=false;
			masach="";
			btnMuon.Enabled=true;
			btnSave.Visible=false;
			btnBo.Visible=false;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(masach=="") return;
			ListViewItem item=new ListViewItem();
			int i=0;
			foreach(ListViewItem item1 in lvSach.Items)
			{
				if(item1.SubItems[1].Text.Trim()==masach.Trim())
				{
					i+=1;
				}
			}
			if(i>0)
			{ 
				MessageBox.Show(this,"Sách đã mượn","Thong bao");
			}
			else
			{
				i=lvSach.Items.Count+1;
				item.Text=""+i++;
				item.SubItems.Add(masach);
				item.SubItems.Add(tensach);
				item.SubItems.Add(hantra.ToString());
			
				lvSach.Items.Add(item);					
				groupSach.Visible=false;
				masach="";
				
				if(btnThem.Enabled==true)
				{
					btnSave.Visible=true;
					btnBo.Visible=true;
					btnMuon.Enabled=false;
				}
				else
				{
					btnSave.Visible=false;
					btnBo.Visible=false;
					
				}
			}
		}

		private void dtHanTra_ValueChanged(object sender, System.EventArgs e)
		{
			if(dtHanTra.Value<DateTime.Now)
			{
				MessageBox.Show(this,"Hạn trả phải sau ngày hiện tại","Thong bao");
				dtHanTra.Value=DateTime.Now;
				return;
			}
			hantra=dtHanTra.Value;
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			SetNull();
			txtMaPhieu.Focus();
			opt=1;
			groupChiTiet.Visible=false;
			btnBo.Visible=false;
			btnSave.Visible=false;
			btnMuon.Enabled=true;
			cboNhanVien.SelectedValue=SqlHelper.strMaNV.Trim();
		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			if (txtMaPhieu.Text=="" || lvSach.Items.Count>0)
			{
				MessageBox.Show("Không thể xoá vì còn sách chưa trả");
				return;
			}
			

			DialogResult result=MessageBox.Show("Bạn có chắc xóa phiếu này không?",
				"Delete PhieuMuon",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_DeletePhieuMuon",
					CommandType.StoredProcedure,
					"@maphieu",txtMaPhieu.Text.Trim());

				MessageBox.Show("Thông tin phiếu mượn này đã bị xóa");
				HienThiPhieuMuon();
			}
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			txtMaPhieu.ReadOnly=true;
			cboDocGia.Focus();
			opt=2;
			btnMuon.Enabled=false;
			cboNhanVien.Enabled=true;
		}

		private void btnBoqua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			txtMaPhieu.ReadOnly=false;
			HienThiPhieuMuon();
			btnMuon.Enabled=true;
			cboNhanVien.Enabled=false;
		}

		private void btnLuu_Click(object sender, System.EventArgs e)
		{
			if(lvSach.Items.Count<=0)
			{
				MessageBox.Show(this,"Bạn chưa chọn sách mượn","Thông báo");
				return;
			}
			try
			{

				SqlHelper.ExecuteNonQuery(
					"Pro_InsertPhieuMuon",
					CommandType.StoredProcedure,
					"@option",opt,
					"@maphieu",txtMaPhieu.Text.Trim(),
					"@msdg",cboDocGia.SelectedValue.ToString(),
					"@msnv",cboNhanVien.SelectedValue.ToString(),
					"@ngaymuon",dtNgayMuon.Value);

				foreach(ListViewItem item in lvSach.Items)
				{
					SqlHelper.ExecuteNonQuery(
						"Pro_InsertChiTietPhieuMuon",
						CommandType.StoredProcedure,
						"@option",opt,
						"@maphieu",txtMaPhieu.Text.Trim(),
						"@mssach",item.SubItems[1].Text,
						"@hantra",item.SubItems[3].Text);
						
					
						UpdateSL(2,item.SubItems[1].Text.Trim());		
				}

					
				txtMaPhieu.ReadOnly=false;	
				HienThiPhieuMuon();
				SetControlVisible(false);
				cboNhanVien.Enabled=false;
				btnMuon.Enabled=true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnTimMaPhieu_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			if(txtMaPhieu.Text=="") return;
			try
			{
				int i=Int32.Parse(txtMaPhieu.Text);
			}
			catch
			{
				MessageBox.Show(this,"Bạn chỉ được nhập số");
				txtMaPhieu.Text="";
				txtMaPhieu.Focus();
				return;
			}
			HienThiPhieuMuon(txtMaPhieu.Text.Trim());
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			

		}

		private void cboDocGia_Click(object sender, System.EventArgs e)
		{
			
		}

		private void lvSach_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			
				if(lvSach.SelectedItems.Count==0)return;
			
				txtMaSach.Text=lvSach.SelectedItems[0].SubItems[1].Text;
				txtTenSach.Text=lvSach.SelectedItems[0].SubItems[2].Text;
				txtHanTra.Value=DateTime.Parse(lvSach.SelectedItems[0].SubItems[3].Text);
			
			
		}

		private void btnBoQuaChiTiet_Click(object sender, System.EventArgs e)
		{
			groupChiTiet.Visible=false;
			SetControlChiTiet(false);
		}

		private void btnSuaChiTiet_Click(object sender, System.EventArgs e)
		{
			SetControlChiTiet(true);
			
		}

		private void lvSach_Click(object sender, System.EventArgs e)
		{
			if(btnThem.Enabled==false)return;
			if(lvSach.Items.Count>=0)
			groupChiTiet.Visible=true;
		}

		private void btnLuuChiTiet_Click(object sender, System.EventArgs e)
		{
			try
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_InsertChiTietPhieuMuon",
					CommandType.StoredProcedure,
					"@option",2,
					"@maphieu",txtMaPhieu.Text.Trim(),
					"@mssach",txtMaSach.Text.Trim(),
					"@hantra",txtHanTra.Value);
					
			}
			catch{}
			groupChiTiet.Visible=false;
			SetControlChiTiet(false);

			HienThiPhieuMuon(txtMaPhieu.Text.Trim());
		}


		private void btnSave_Click(object sender, System.EventArgs e)
		{
			//try{
				foreach(ListViewItem item in lvSach.Items)
				{
					SqlHelper.ExecuteNonQuery(
						"Pro_InsertChiTietPhieuMuon",
						CommandType.StoredProcedure,
						"@option",1,
						"@maphieu",txtMaPhieu.Text.Trim(),
						"@mssach",item.SubItems[1].Text,
						"@hantra",item.SubItems[3].Text);
						
					
					
					UpdateSL(2,item.SubItems[1].Text.Trim());
		
				}
			//}
			/*catch{
			 return;
			}*/
			btnSave.Visible=false;
			btnBo.Visible=false;
			btnMuon.Enabled=true;
		}

		private void btnBo_Click(object sender, System.EventArgs e)
		{
			btnBo.Visible=false;
			btnSave.Visible=false;
			btnMuon.Enabled=true;
			HienThiPhieuMuon(txtMaPhieu.Text);
		}

		private void cboDocGia_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dtdg=SqlHelper.ExecuteDataTable(
					"Pro_SelectDocGia",
					CommandType.StoredProcedure,"@msdg",cboDocGia.SelectedValue.ToString());
				txtNgaySinhDG.Text=dtdg.Rows[0]["NGAYSINH"].ToString();
				txtDCDG.Text=dtdg.Rows[0]["DIACHI"].ToString();
			}
			catch{}
		}

		
		private void btnDong_Click(object sender, System.EventArgs e)
		{
			groupChiTiet.Visible=false;
		}

		private void chkLoaiSach_CheckedChanged(object sender, System.EventArgs e)
		{
		cboLoaiSach.Visible=chkLoaiSach.Checked;
		}

		private void chkNXB_CheckedChanged(object sender, System.EventArgs e)
		{
			cboNXB.Visible=chkNXB.Checked;
		}

		private void groupSach_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void btnTimSach_Click(object sender, System.EventArgs e)
		{
			if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=1;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=2;
			else if(txtMssach.Text!="" && txtTimTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=3;
			else if(txtMssach.Text!="" && txtTimTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=4;
			else if(txtMssach.Text!="" && txtTimTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=5;
			else if(txtMssach.Text!="" && txtTimTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==true)
				opt=6;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=7;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=8;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=9;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==true)
				opt=10;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text!="" 
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=11;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=12;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==true)
				opt=13;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=14;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==true)
				opt=15;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==false)
				opt=16;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=17;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==true)
				opt=18;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=19;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==true)
				opt=20;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==false)
				opt=21;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==true && chkNXB.Checked==true)
				opt=22;
			else if(txtMssach.Text=="" && txtTimTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==true)
				opt=23;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==true)
				opt=24;
			else if(txtMssach.Text=="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==true)
				opt=25;
			else if(txtMssach.Text!="" && txtTimTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoaiSach.Checked==false && chkNXB.Checked==true)
				opt=26;


			HienThiSach();
		}
		
	}
}
