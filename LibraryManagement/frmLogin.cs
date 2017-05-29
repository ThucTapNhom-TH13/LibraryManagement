using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		private DotNetSkin.SkinControls.SkinButton btnLogin;
		private DotNetSkin.SkinControls.SkinImage skinImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtMaNV;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string loginID="";
		private string pass="";
		public frmLogin()
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
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region methods
		void getValueNhanVien()
		{
			
				try
				{
					DataTable dtNhanVien=SqlHelper.ExecuteDataTable(
						"Pro_SelectNV",
						CommandType.StoredProcedure,
						"@manv",txtMaNV.Text.Trim());
					if(dtNhanVien.Rows.Count>0)
					{
						loginID=dtNhanVien.Rows[0]["MSNV"].ToString();
						pass=dtNhanVien.Rows[0]["MATMA"].ToString();
					}
					
					
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.btnLogin = new DotNetSkin.SkinControls.SkinButton();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.skinImage = new DotNetSkin.SkinControls.SkinImage();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.txtMatKhau);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtMaNV);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(16, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(216, 144);
			this.panel1.TabIndex = 0;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoat.Location = new System.Drawing.Point(112, 96);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(80, 40);
			this.btnThoat.TabIndex = 23;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLogin.Location = new System.Drawing.Point(32, 96);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(72, 40);
			this.btnLogin.TabIndex = 22;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(64, 56);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(136, 20);
			this.txtMatKhau.TabIndex = 21;
			this.txtMatKhau.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Mật mã";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(64, 16);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(136, 20);
			this.txtMaNV.TabIndex = 19;
			this.txtMaNV.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Mã NV";
			// 
			// skinImage
			// 
			this.skinImage.Scheme = DotNetSkin.SkinControls.Schemes.MacOs;
			// 
			// frmLogin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(250, 176);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		static void Main() 
		{
			Application.Run(new frmLogin());
		}
		private void frmLogin_Load(object sender, System.EventArgs e)
		{
		skinImage.Scheme=DotNetSkin.SkinControls.Schemes.Plex;
		}

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			if(txtMaNV.Text=="")
			{
				MessageBox.Show(this,"Bạn chưa nhập Mã số Nhân Viên","Thông báo");
				return;
			}
			getValueNhanVien();
			if(loginID=="")
			{
				MessageBox.Show(this,"Nhân Viên không tồn tại","Thông báo");
				return;
			}
			else if(!pass.Equals(txtMatKhau.Text))
			{
				MessageBox.Show(this,"Sai mật mã","Thông báo");
				return;
			}
			SqlHelper.strMaNV=txtMaNV.Text.Trim();
			new frmMain().Show();
			this.Hide();
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
