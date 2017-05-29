using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmLoaiSach.
	/// </summary>
	public class frmLoaiSach : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView lvLoai;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox3;
		private DotNetSkin.SkinControls.SkinButton btnThem;
		private DotNetSkin.SkinControls.SkinButton btnThoát;
		private DotNetSkin.SkinControls.SkinButton btnBoqua;
		private DotNetSkin.SkinControls.SkinButton btnLuu;
		private DotNetSkin.SkinControls.SkinButton btnSua;
		private DotNetSkin.SkinControls.SkinButton btnXoa;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtLoai;
		private System.Windows.Forms.TextBox txtMaLoai;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private int opt=0;

		public frmLoaiSach()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiLoaiSach();
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
		void HienThiLoaiSach()
		{
			try
			{
				DataTable dtLoaiSach=SqlHelper.ExecuteDataTable(
					"Pro_LoaiSach",
					CommandType.StoredProcedure);
				int i=1;
				lvLoai.Items.Clear();
				txtMaLoai.Text=dtLoaiSach.Rows[0]["MALOAISACH"].ToString();
				txtLoai.Text=dtLoaiSach.Rows[0]["LOAISACH"].ToString();
				
				foreach(DataRow row in dtLoaiSach.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["MALOAISACH"].ToString());
					item.SubItems.Add(row["LOAISACH"].ToString());
					lvLoai.Items.Add(item);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void SetControlVisible(bool b)
		{
			txtMaLoai.ReadOnly=!b;
			txtLoai.ReadOnly=!b;
			
			btnThem.Enabled=!b;
			btnXoa.Enabled=!b;
			btnSua.Enabled=!b;
			btnLuu.Enabled=b;
			btnBoqua.Enabled=b;
			
		}
		void SetNull()
		{
			txtMaLoai.Text="";
			txtLoai.Text="";
			
		}
		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLoaiSach));
			this.lvLoai = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnThem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.btnBoqua = new DotNetSkin.SkinControls.SkinButton();
			this.btnLuu = new DotNetSkin.SkinControls.SkinButton();
			this.btnSua = new DotNetSkin.SkinControls.SkinButton();
			this.btnXoa = new DotNetSkin.SkinControls.SkinButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtLoai = new System.Windows.Forms.TextBox();
			this.txtMaLoai = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvLoai
			// 
			this.lvLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader3});
			this.lvLoai.FullRowSelect = true;
			this.lvLoai.GridLines = true;
			this.lvLoai.Location = new System.Drawing.Point(160, 120);
			this.lvLoai.Name = "lvLoai";
			this.lvLoai.Size = new System.Drawing.Size(384, 272);
			this.lvLoai.TabIndex = 11;
			this.lvLoai.View = System.Windows.Forms.View.Details;
			this.lvLoai.SelectedIndexChanged += new System.EventHandler(this.lvLoai_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Loại sách";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Loại sách";
			this.columnHeader3.Width = 200;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnThoát);
			this.groupBox3.Controls.Add(this.btnBoqua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Location = new System.Drawing.Point(160, 392);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(384, 56);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThem.Location = new System.Drawing.Point(24, 8);
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
			this.btnThoát.Location = new System.Drawing.Point(304, 8);
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
			this.btnBoqua.Location = new System.Drawing.Point(248, 8);
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
			this.btnLuu.Location = new System.Drawing.Point(192, 8);
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
			this.btnSua.Location = new System.Drawing.Point(136, 8);
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
			this.btnXoa.Location = new System.Drawing.Point(80, 8);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(48, 40);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.txtLoai);
			this.panel1.Controls.Add(this.txtMaLoai);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(160, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(384, 80);
			this.panel1.TabIndex = 13;
			// 
			// txtLoai
			// 
			this.txtLoai.Location = new System.Drawing.Point(96, 48);
			this.txtLoai.MaxLength = 50;
			this.txtLoai.Name = "txtLoai";
			this.txtLoai.Size = new System.Drawing.Size(176, 20);
			this.txtLoai.TabIndex = 14;
			this.txtLoai.Text = "";
			// 
			// txtMaLoai
			// 
			this.txtMaLoai.Location = new System.Drawing.Point(96, 8);
			this.txtMaLoai.MaxLength = 10;
			this.txtMaLoai.Name = "txtMaLoai";
			this.txtMaLoai.Size = new System.Drawing.Size(112, 20);
			this.txtMaLoai.TabIndex = 12;
			this.txtMaLoai.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "Mã loại sách";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 13;
			this.label2.Text = "Loại sách";
			// 
			// frmLoaiSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.lvLoai);
			this.Name = "frmLoaiSach";
			this.Text = "Loai Sach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmLoaiSach_Load);
			this.groupBox3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmLoaiSach_Load(object sender, System.EventArgs e)
		{
		
		}

		private void lvLoai_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvLoai.SelectedItems.Count==0)
				return;
			txtMaLoai.Text=lvLoai.SelectedItems[0].SubItems[1].Text;
			txtLoai.Text=lvLoai.SelectedItems[0].SubItems[2].Text;
		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			SetNull();
			lvLoai.Enabled=false;
			txtMaLoai.Focus();
			opt=1;
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			txtMaLoai.ReadOnly=true;
			txtLoai.Focus();
			opt=2;
		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			if (txtMaLoai.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc xóa loại sách này không?",
				"Delete Book type",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_DeleteLoaiSach",
					CommandType.StoredProcedure,
					"@maloai",txtMaLoai.Text);

				MessageBox.Show("Thông tin loại sách này đã bị xóa");
				HienThiLoaiSach();
			}
		}

		private void btnLuu_Click(object sender, System.EventArgs e)
		{
			int chk=0;
			if(txtMaLoai.Text=="" || txtLoai.Text=="") 
			{
				MessageBox.Show(this,"Bạn chưa nhập đủ thông tin","Thong bao");	
				return;
			}
			try
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_InsertLoaiSach",
					CommandType.StoredProcedure,
					"@option",opt,
					"@maloai",txtMaLoai.Text.Trim(),
					"@loai",txtLoai.Text.Trim(),
					"@msg",chk);
				
				if(chk==1)
				{
					MessageBox.Show(this,"Loại sách này đã có","Thong bao");
					return;
				}

				HienThiLoaiSach();
				SetControlVisible(false);
				lvLoai.Enabled=true;
				txtLoai.Text=chk.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBoqua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			lvLoai.Enabled=true;
			HienThiLoaiSach();
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
