using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using OfficeMenu;

namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem mnuDMDG;
		private System.Windows.Forms.MenuItem mnuDMSach;
		private System.Windows.Forms.MenuItem mnuDMNXB;
		private System.Windows.Forms.MenuItem mnuDMLoaiSach;
		private System.Windows.Forms.MenuItem mnuDMNV;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem mnuMuon;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem mnuTimSach;
		private System.Windows.Forms.MenuItem mnuLogin;
		private System.Windows.Forms.MenuItem mnuBK;
		private System.Windows.Forms.MenuItem mnuRST;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ToolBar toolBar;
		private System.Windows.Forms.MenuItem menuHeThong;
		private System.Windows.Forms.MenuItem mnuDanhMuc;
		private System.Windows.Forms.MenuItem mnuQuanLy;
		private System.Windows.Forms.MenuItem mnuTimKiem;
		private System.Windows.Forms.MenuItem mnuThongKe;
		private System.Windows.Forms.ToolBarButton tbLogout;
		private System.Windows.Forms.ToolBarButton tbDanhMuc;
		private System.Windows.Forms.ToolBarButton tbMuon;
		private System.Windows.Forms.ToolBarButton tbTra;
		private System.Windows.Forms.ToolBarButton tbTim;
		private System.Windows.Forms.ToolBarButton tbTK;
		private System.Windows.Forms.ContextMenu ctMenu;
		private System.Windows.Forms.MenuItem mnuNhanVien;
		private System.Windows.Forms.MenuItem mnuDocGia;
		private System.Windows.Forms.MenuItem mnuNXB;
		private System.Windows.Forms.MenuItem mnuLoai;
		private System.Windows.Forms.MenuItem mnuSach;
		private System.Windows.Forms.MenuItem mnuTimDocGia;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbThoat;
		private System.Windows.Forms.MenuItem mnuTimSachMuon;
		private System.Windows.Forms.ContextMenu ctMnuTim;
		private System.Windows.Forms.MenuItem ctMnuTimDG;
		private System.Windows.Forms.MenuItem ctMnuTimSach;
		private System.Windows.Forms.MenuItem ctMnuTimMuon;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.ComponentModel.IContainer components;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Methods
		public void EnableControl(bool b)
		{
			menuHeThong.Enabled=b;
			mnuDanhMuc.Enabled=b;
			mnuQuanLy.Enabled=b;
			mnuTimKiem.Enabled=b;
			mnuThongKe.Enabled=b;
			toolBar.Enabled=b;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuHeThong = new System.Windows.Forms.MenuItem();
			this.mnuLogin = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mnuBK = new System.Windows.Forms.MenuItem();
			this.mnuRST = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.mnuDanhMuc = new System.Windows.Forms.MenuItem();
			this.mnuDMDG = new System.Windows.Forms.MenuItem();
			this.mnuDMNV = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuDMNXB = new System.Windows.Forms.MenuItem();
			this.mnuDMSach = new System.Windows.Forms.MenuItem();
			this.mnuDMLoaiSach = new System.Windows.Forms.MenuItem();
			this.mnuQuanLy = new System.Windows.Forms.MenuItem();
			this.mnuMuon = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.mnuTimKiem = new System.Windows.Forms.MenuItem();
			this.mnuTimDocGia = new System.Windows.Forms.MenuItem();
			this.mnuTimSach = new System.Windows.Forms.MenuItem();
			this.mnuTimSachMuon = new System.Windows.Forms.MenuItem();
			this.mnuThongKe = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBar = new System.Windows.Forms.ToolBar();
			this.tbLogout = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.tbDanhMuc = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.tbMuon = new System.Windows.Forms.ToolBarButton();
			this.tbTra = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.tbTim = new System.Windows.Forms.ToolBarButton();
			this.ctMnuTim = new System.Windows.Forms.ContextMenu();
			this.ctMnuTimDG = new System.Windows.Forms.MenuItem();
			this.ctMnuTimSach = new System.Windows.Forms.MenuItem();
			this.ctMnuTimMuon = new System.Windows.Forms.MenuItem();
			this.tbTK = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbThoat = new System.Windows.Forms.ToolBarButton();
			this.ctMenu = new System.Windows.Forms.ContextMenu();
			this.mnuNhanVien = new System.Windows.Forms.MenuItem();
			this.mnuDocGia = new System.Windows.Forms.MenuItem();
			this.mnuNXB = new System.Windows.Forms.MenuItem();
			this.mnuLoai = new System.Windows.Forms.MenuItem();
			this.mnuSach = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuHeThong,
																					  this.mnuDanhMuc,
																					  this.mnuQuanLy,
																					  this.mnuTimKiem,
																					  this.mnuThongKe});
			// 
			// menuHeThong
			// 
			this.menuHeThong.Index = 0;
			this.menuHeThong.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.mnuLogin,
																						this.menuItem4,
																						this.mnuBK,
																						this.mnuRST,
																						this.menuItem8,
																						this.mnuExit});
			this.menuHeThong.Text = "Quản lý Hệ thống";
			// 
			// mnuLogin
			// 
			this.mnuLogin.Index = 0;
			this.mnuLogin.Text = "Đăng xuất";
			this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// mnuBK
			// 
			this.mnuBK.Index = 2;
			this.mnuBK.Text = "Sao lưu dữ liệu";
			// 
			// mnuRST
			// 
			this.mnuRST.Index = 3;
			this.mnuRST.Text = "Phục hồi dữ liệu";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.Text = "-";
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 5;
			this.mnuExit.Text = "Thoát chương trình";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuDanhMuc
			// 
			this.mnuDanhMuc.Index = 1;
			this.mnuDanhMuc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.mnuDMDG,
																					   this.mnuDMNV,
																					   this.menuItem3,
																					   this.mnuDMNXB,
																					   this.mnuDMSach,
																					   this.mnuDMLoaiSach});
			this.mnuDanhMuc.Text = "Quản lý Danh mục";
			// 
			// mnuDMDG
			// 
			this.mnuDMDG.Index = 0;
			this.mnuDMDG.Text = "Danh mục Độc giả";
			this.mnuDMDG.Click += new System.EventHandler(this.mnuDMDG_Click);
			// 
			// mnuDMNV
			// 
			this.mnuDMNV.Index = 1;
			this.mnuDMNV.Text = "Danh mục Nhân viên";
			this.mnuDMNV.Click += new System.EventHandler(this.mnuDMNV_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// mnuDMNXB
			// 
			this.mnuDMNXB.Index = 3;
			this.mnuDMNXB.Text = "Danh mục Nhà xuất bản";
			this.mnuDMNXB.Click += new System.EventHandler(this.mnuDMNXB_Click);
			// 
			// mnuDMSach
			// 
			this.mnuDMSach.Index = 4;
			this.mnuDMSach.Text = "Quản lý Sách";
			this.mnuDMSach.Click += new System.EventHandler(this.mnuDMSach_Click);
			// 
			// mnuDMLoaiSach
			// 
			this.mnuDMLoaiSach.Index = 5;
			this.mnuDMLoaiSach.Text = "Danh mục Loại sách";
			this.mnuDMLoaiSach.Click += new System.EventHandler(this.mnuDMLoaiSach_Click);
			// 
			// mnuQuanLy
			// 
			this.mnuQuanLy.Index = 2;
			this.mnuQuanLy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuMuon,
																					  this.menuItem15});
			this.mnuQuanLy.Text = "Quản lý mượn trả sách";
			// 
			// mnuMuon
			// 
			this.mnuMuon.Index = 0;
			this.mnuMuon.Text = "Muợn sách";
			this.mnuMuon.Click += new System.EventHandler(this.mnuMuon_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "Trả sách";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// mnuTimKiem
			// 
			this.mnuTimKiem.Index = 3;
			this.mnuTimKiem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.mnuTimDocGia,
																					   this.mnuTimSach,
																					   this.mnuTimSachMuon});
			this.mnuTimKiem.Text = "Tìm kiếm";
			// 
			// mnuTimDocGia
			// 
			this.mnuTimDocGia.Index = 0;
			this.mnuTimDocGia.Text = "Tìm độc giả";
			this.mnuTimDocGia.Click += new System.EventHandler(this.mnuTimDocGia_Click);
			// 
			// mnuTimSach
			// 
			this.mnuTimSach.Index = 1;
			this.mnuTimSach.Text = "Tìm sách";
			this.mnuTimSach.Click += new System.EventHandler(this.mnuTimSach_Click);
			// 
			// mnuTimSachMuon
			// 
			this.mnuTimSachMuon.Index = 2;
			this.mnuTimSachMuon.Text = "Tìm sách đã cho mượn";
			this.mnuTimSachMuon.Click += new System.EventHandler(this.mnuTimSachMuon_Click);
			// 
			// mnuThongKe
			// 
			this.mnuThongKe.Index = 4;
			this.mnuThongKe.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem1,
																					   this.menuItem2});
			this.mnuThongKe.Text = "Thống kê";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Thống kê Độc giả";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "Thống kê sách";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// toolBar
			// 
			this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.tbLogout,
																					   this.toolBarButton9,
																					   this.tbDanhMuc,
																					   this.toolBarButton10,
																					   this.tbMuon,
																					   this.tbTra,
																					   this.toolBarButton11,
																					   this.tbTim,
																					   this.tbTK,
																					   this.toolBarButton1,
																					   this.tbThoat});
			this.toolBar.DropDownArrows = true;
			this.toolBar.ImageList = this.imageList1;
			this.toolBar.Location = new System.Drawing.Point(0, 0);
			this.toolBar.Name = "toolBar";
			this.toolBar.ShowToolTips = true;
			this.toolBar.Size = new System.Drawing.Size(488, 42);
			this.toolBar.TabIndex = 1;
			this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
			// 
			// tbLogout
			// 
			this.tbLogout.ImageIndex = 0;
			this.tbLogout.Text = "Logout";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbDanhMuc
			// 
			this.tbDanhMuc.ImageIndex = 2;
			this.tbDanhMuc.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbDanhMuc.Text = "Danh mục";
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 0;
			this.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbMuon
			// 
			this.tbMuon.ImageIndex = 3;
			this.tbMuon.Text = "Mượn sách";
			// 
			// tbTra
			// 
			this.tbTra.ImageIndex = 4;
			this.tbTra.Text = "Trả sách";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbTim
			// 
			this.tbTim.DropDownMenu = this.ctMnuTim;
			this.tbTim.ImageIndex = 5;
			this.tbTim.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbTim.Text = "Tìm kiếm";
			// 
			// ctMnuTim
			// 
			this.ctMnuTim.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.ctMnuTimDG,
																					 this.ctMnuTimSach,
																					 this.ctMnuTimMuon});
			// 
			// ctMnuTimDG
			// 
			this.ctMnuTimDG.Index = 0;
			this.ctMnuTimDG.Text = "Tìm Độc giả";
			this.ctMnuTimDG.Click += new System.EventHandler(this.ctMnuTimDG_Click);
			// 
			// ctMnuTimSach
			// 
			this.ctMnuTimSach.Index = 1;
			this.ctMnuTimSach.Text = "Tìm Sách";
			this.ctMnuTimSach.Click += new System.EventHandler(this.ctMnuTimSach_Click);
			// 
			// ctMnuTimMuon
			// 
			this.ctMnuTimMuon.Index = 2;
			this.ctMnuTimMuon.Text = "Tìm Sách mượn";
			this.ctMnuTimMuon.Click += new System.EventHandler(this.ctMnuTimMuon_Click);
			// 
			// tbTK
			// 
			this.tbTK.ImageIndex = 6;
			this.tbTK.Text = "Thống kê";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbThoat
			// 
			this.tbThoat.ImageIndex = 9;
			this.tbThoat.Text = "Thoát";
			// 
			// ctMenu
			// 
			this.ctMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.mnuNhanVien,
																				   this.mnuDocGia,
																				   this.mnuNXB,
																				   this.mnuLoai,
																				   this.mnuSach});
			// 
			// mnuNhanVien
			// 
			this.mnuNhanVien.Index = 0;
			this.mnuNhanVien.Text = "Nhân viên";
			this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
			// 
			// mnuDocGia
			// 
			this.mnuDocGia.Index = 1;
			this.mnuDocGia.Text = "Độc giả";
			this.mnuDocGia.Click += new System.EventHandler(this.mnuDocGia_Click);
			// 
			// mnuNXB
			// 
			this.mnuNXB.Index = 2;
			this.mnuNXB.Text = "Nhà xuất bản";
			this.mnuNXB.Click += new System.EventHandler(this.mnuNXB_Click);
			// 
			// mnuLoai
			// 
			this.mnuLoai.Index = 3;
			this.mnuLoai.Text = "Loại sách";
			this.mnuLoai.Click += new System.EventHandler(this.mnuLoai_Click);
			// 
			// mnuSach
			// 
			this.mnuSach.Index = 4;
			this.mnuSach.Text = "Sách";
			this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(488, 237);
			this.ControlBox = false;
			this.Controls.Add(this.toolBar);
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "frmMain";
			this.Text = "Quan ly thu vien";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Closed += new System.EventHandler(this.frmMain_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			SetStyle(ControlStyles.ResizeRedraw,true);
			OfficeMenus ofm=new OfficeMenus();
			ofm.ImageList=imageList1;
			ofm.AddPicture(mnuLogin,0);
			ofm.AddPicture(mnuBK,1);
			ofm.AddPicture(mnuDMDG,7);
			ofm.AddPicture(mnuDMSach,8);
			ofm.AddPicture(mnuDMNXB,9);
			
			ofm.Start(this);
			frmScreen fscreen=new frmScreen();
			fscreen.MdiParent=this;
			tbDanhMuc.DropDownMenu=ctMenu;
			fscreen.Show();
		}

		private void mnuDMDG_Click(object sender, System.EventArgs e)
		{
			frmDocgia frmdg=new frmDocgia();
			frmdg.MdiParent=this;
			frmdg.Show();
			
		}

		private void mnuDMSach_Click(object sender, System.EventArgs e)
		{
			frmSach frmsach=new frmSach();
			frmsach.MdiParent=this;
			frmsach.Show();
		}

		private void mnuDMNXB_Click(object sender, System.EventArgs e)
		{
			frmNXB frmnxb=new frmNXB();
			frmnxb.MdiParent=this;
			frmnxb.Show();

		}

		private void mnuDMLoaiSach_Click(object sender, System.EventArgs e)
		{
			frmLoaiSach loaisach=new frmLoaiSach();
			loaisach.MdiParent=this;
			loaisach.Show();
		}

		private void mnuDMNV_Click(object sender, System.EventArgs e)
		{
			frmNhanVien frmnv=new frmNhanVien();
			frmnv.MdiParent=this;
			frmnv.Show();
		}

		private void mnuMuon_Click(object sender, System.EventArgs e)
		{
			frmMuonSach frmmuon=new frmMuonSach();
			frmmuon.MdiParent=this;
			frmmuon.Show();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
				frmTraSach frmtra=new frmTraSach();
				frmtra.MdiParent=this;
				frmtra.Show();
		}

		private void mnuTimSach_Click(object sender, System.EventArgs e)
		{
			frmTimSach timsach=new frmTimSach();
			timsach.MdiParent=this;
			timsach.Show();
		}

		private void mnuLogin_Click(object sender, System.EventArgs e)
		{
			new frmLogin().Show();
			this.Close();
		}

		private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			
			if(e.Button==tbLogout)
			{
				new frmLogin().Show();
				this.Close();

			}
			else if(e.Button==tbMuon)
			{
				frmMuonSach frmmuon=new frmMuonSach();
				frmmuon.MdiParent=this;
				frmmuon.Show();
			}
			else if(e.Button==tbTra)
			{
				
				frmTraSach fTra=new frmTraSach();
				fTra.MdiParent=this;
				fTra.Show();
			}
			else if(e.Button==tbThoat)
			{
				DialogResult rs=MessageBox.Show(this,"Bạn có chắc thoát chương trình chưa","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				if(rs==DialogResult.Yes)
				Application.Exit();
			}

		}

		private void frmMain_Closed(object sender, System.EventArgs e)
		{
		
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void mnuNhanVien_Click(object sender, System.EventArgs e)
		{
			mnuDMNV_Click(sender,e);
		}

		private void mnuDocGia_Click(object sender, System.EventArgs e)
		{
			mnuDMDG_Click(sender,e);
		}

		private void mnuNXB_Click(object sender, System.EventArgs e)
		{
			mnuDMNXB_Click(sender,e);
		}

		private void mnuLoai_Click(object sender, System.EventArgs e)
		{
			mnuDMLoaiSach_Click(sender,e);
		}

		private void mnuSach_Click(object sender, System.EventArgs e)
		{
			mnuDMSach_Click(sender,e);
		}

		private void mnuTimDocGia_Click(object sender, System.EventArgs e)
		{
			frmTimDocGia fTimDG=new frmTimDocGia();
			fTimDG.MdiParent=this;
			fTimDG.Show();
		}

		private void mnuTimSachMuon_Click(object sender, System.EventArgs e)
		{
			frmTimSachMuon fMuon=new frmTimSachMuon();
			fMuon.MdiParent=this;
			fMuon.Show();
		}

		private void ctMnuTimDG_Click(object sender, System.EventArgs e)
		{
			mnuTimDocGia_Click(sender,e);
		}

		private void ctMnuTimSach_Click(object sender, System.EventArgs e)
		{
			mnuTimSach_Click(sender,e);
		}

		private void ctMnuTimMuon_Click(object sender, System.EventArgs e)
		{
			mnuTimSachMuon_Click(sender,e);
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			frmTKDG fTKDG=new frmTKDG();
			fTKDG.MdiParent=this;
			fTKDG.Show();

		}

		
			

		
	}
}
