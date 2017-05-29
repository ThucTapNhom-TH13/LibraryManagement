using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmChiTietSach.
	/// </summary>
	public class frmChiTietSach : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSL;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtLanXB;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNamXB;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboLoaiSach;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboNXB;
		private System.Windows.Forms.TextBox txtNoiDungSL;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTacGia;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenSach;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaSach;
		private System.Windows.Forms.Label label1;
		private DotNetSkin.SkinControls.SkinButton btnThoát;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChiTietSach()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiLoaiSach();
			HienThiNXB();
			HienThiSach();
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
					"Pro_SelectSach",
					CommandType.StoredProcedure,
					"@mssach",SqlHelper.strMaSach.Trim());
				
				txtMaSach.Text=dtSach.Rows[0]["MSSACH"].ToString();
				txtTenSach.Text=dtSach.Rows[0]["TENSACH"].ToString();
				txtTacGia.Text=dtSach.Rows[0]["TACGIA"].ToString();
				cboNXB.SelectedValue=dtSach.Rows[0]["MSNHAXB"].ToString();
				cboLoaiSach.SelectedValue=dtSach.Rows[0]["MALOAISACH"].ToString();
				txtNamXB.Text=dtSach.Rows[0]["NAMXB"].ToString();
				txtLanXB.Text=dtSach.Rows[0]["LANXB"].ToString();
				txtSL.Text=dtSach.Rows[0]["SOLUONG"].ToString();
				txtNoiDungSL.Text=dtSach.Rows[0]["NOIDUNGTOMLUOC"].ToString();

				
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChiTietSach));
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
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(392, 352);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
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
			this.txtNoiDungSL.Location = new System.Drawing.Point(16, 264);
			this.txtNoiDungSL.MaxLength = 4000;
			this.txtNoiDungSL.Multiline = true;
			this.txtNoiDungSL.Name = "txtNoiDungSL";
			this.txtNoiDungSL.Size = new System.Drawing.Size(360, 80);
			this.txtNoiDungSL.TabIndex = 13;
			this.txtNoiDungSL.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 240);
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
			// btnThoát
			// 
			this.btnThoát.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThoát.Image = ((System.Drawing.Image)(resources.GetObject("btnThoát.Image")));
			this.btnThoát.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoát.Location = new System.Drawing.Point(208, 368);
			this.btnThoát.Name = "btnThoát";
			this.btnThoát.Size = new System.Drawing.Size(48, 40);
			this.btnThoát.TabIndex = 17;
			this.btnThoát.Text = "Thoát";
			this.btnThoát.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
			// 
			// frmChiTietSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(424, 430);
			this.ControlBox = false;
			this.Controls.Add(this.btnThoát);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChiTietSach";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiet";
			this.Load += new System.EventHandler(this.frmChiTietSach_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmChiTietSach_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnThoát_Click(object sender, System.EventArgs e)
		{
			SqlHelper.strMaSach="";
			this.Close();
		}
	}
}
