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
	public class frmNXB : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView lvNXB;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
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
		private System.Windows.Forms.TextBox txtThongTinNXB;
		private System.Windows.Forms.TextBox txtWSNXB;
		private System.Windows.Forms.TextBox txtDCNXB;
		private System.Windows.Forms.TextBox txtTenNXB;
		private System.Windows.Forms.TextBox txtMaNXB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private int opt=0;
		public frmNXB()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiNXB();
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
				int i=1;
				lvNXB.Items.Clear();
				txtMaNXB.Text=dtNXB.Rows[0]["MSNHAXB"].ToString();
				txtTenNXB.Text=dtNXB.Rows[0]["TENNXB"].ToString();
				txtDCNXB.Text=dtNXB.Rows[0]["DIACHINXB"].ToString();
				txtWSNXB.Text=dtNXB.Rows[0]["WEBSITENXB"].ToString();
				txtThongTinNXB.Text=dtNXB.Rows[0]["THONGTINKHACNXB"].ToString();
				

				foreach(DataRow row in dtNXB.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["MSNHAXB"].ToString());
					item.SubItems.Add(row["TENNXB"].ToString());
					item.SubItems.Add(row["DIACHINXB"].ToString());
					item.SubItems.Add(row["WEBSITENXB"].ToString());
					item.SubItems.Add(row["THONGTINKHACNXB"].ToString());
				
				
					lvNXB.Items.Add(item);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		
		void SetControlVisible(bool b)
		{
			txtMaNXB.ReadOnly=!b;
			txtTenNXB.ReadOnly=!b;
			txtDCNXB.ReadOnly=!b;
			txtWSNXB.ReadOnly=!b;
			txtThongTinNXB.ReadOnly=!b;
			
			btnThem.Enabled=!b;
			btnXoa.Enabled=!b;
			btnSua.Enabled=!b;
			btnLuu.Enabled=b;
			btnBoqua.Enabled=b;
			
			
		}
		void SetNull()
		{
			txtMaNXB.Text="";
			txtTenNXB.Text="";
			txtDCNXB.Text="";
			txtWSNXB.Text="";
			txtThongTinNXB.Text="";			
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmNXB));
			this.lvNXB = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnThem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoát = new DotNetSkin.SkinControls.SkinButton();
			this.btnBoqua = new DotNetSkin.SkinControls.SkinButton();
			this.btnLuu = new DotNetSkin.SkinControls.SkinButton();
			this.btnSua = new DotNetSkin.SkinControls.SkinButton();
			this.btnXoa = new DotNetSkin.SkinControls.SkinButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtThongTinNXB = new System.Windows.Forms.TextBox();
			this.txtWSNXB = new System.Windows.Forms.TextBox();
			this.txtDCNXB = new System.Windows.Forms.TextBox();
			this.txtTenNXB = new System.Windows.Forms.TextBox();
			this.txtMaNXB = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvNXB
			// 
			this.lvNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvNXB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					this.columnHeader1,
																					this.columnHeader2,
																					this.columnHeader3,
																					this.columnHeader4,
																					this.columnHeader5,
																					this.columnHeader6});
			this.lvNXB.FullRowSelect = true;
			this.lvNXB.GridLines = true;
			this.lvNXB.Location = new System.Drawing.Point(160, 208);
			this.lvNXB.Name = "lvNXB";
			this.lvNXB.Size = new System.Drawing.Size(464, 168);
			this.lvNXB.TabIndex = 4;
			this.lvNXB.View = System.Windows.Forms.View.Details;
			this.lvNXB.SelectedIndexChanged += new System.EventHandler(this.lvNXB_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã NXB";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên NXB";
			this.columnHeader3.Width = 300;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "DC";
			this.columnHeader4.Width = 0;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "WS";
			this.columnHeader5.Width = 0;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "TT";
			this.columnHeader6.Width = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnThoát);
			this.groupBox3.Controls.Add(this.btnBoqua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Location = new System.Drawing.Point(184, 376);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 64);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThem.Location = new System.Drawing.Point(48, 16);
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
			this.btnThoát.Location = new System.Drawing.Point(328, 16);
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
			this.btnBoqua.Location = new System.Drawing.Point(272, 16);
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
			this.btnLuu.Location = new System.Drawing.Point(216, 16);
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
			this.btnSua.Location = new System.Drawing.Point(160, 16);
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
			this.btnXoa.Location = new System.Drawing.Point(104, 16);
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
			this.panel1.Controls.Add(this.txtThongTinNXB);
			this.panel1.Controls.Add(this.txtWSNXB);
			this.panel1.Controls.Add(this.txtDCNXB);
			this.panel1.Controls.Add(this.txtTenNXB);
			this.panel1.Controls.Add(this.txtMaNXB);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(160, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(464, 200);
			this.panel1.TabIndex = 14;
			// 
			// txtThongTinNXB
			// 
			this.txtThongTinNXB.Location = new System.Drawing.Point(88, 144);
			this.txtThongTinNXB.MaxLength = 1000;
			this.txtThongTinNXB.Multiline = true;
			this.txtThongTinNXB.Name = "txtThongTinNXB";
			this.txtThongTinNXB.Size = new System.Drawing.Size(352, 48);
			this.txtThongTinNXB.TabIndex = 22;
			this.txtThongTinNXB.Text = "";
			// 
			// txtWSNXB
			// 
			this.txtWSNXB.Location = new System.Drawing.Point(88, 96);
			this.txtWSNXB.MaxLength = 50;
			this.txtWSNXB.Name = "txtWSNXB";
			this.txtWSNXB.Size = new System.Drawing.Size(256, 20);
			this.txtWSNXB.TabIndex = 20;
			this.txtWSNXB.Text = "";
			// 
			// txtDCNXB
			// 
			this.txtDCNXB.Location = new System.Drawing.Point(88, 64);
			this.txtDCNXB.MaxLength = 100;
			this.txtDCNXB.Name = "txtDCNXB";
			this.txtDCNXB.Size = new System.Drawing.Size(360, 20);
			this.txtDCNXB.TabIndex = 18;
			this.txtDCNXB.Text = "";
			// 
			// txtTenNXB
			// 
			this.txtTenNXB.Location = new System.Drawing.Point(88, 32);
			this.txtTenNXB.MaxLength = 200;
			this.txtTenNXB.Name = "txtTenNXB";
			this.txtTenNXB.Size = new System.Drawing.Size(176, 20);
			this.txtTenNXB.TabIndex = 16;
			this.txtTenNXB.Text = "";
			// 
			// txtMaNXB
			// 
			this.txtMaNXB.Location = new System.Drawing.Point(88, 8);
			this.txtMaNXB.MaxLength = 9;
			this.txtMaNXB.Name = "txtMaNXB";
			this.txtMaNXB.Size = new System.Drawing.Size(112, 20);
			this.txtMaNXB.TabIndex = 14;
			this.txtMaNXB.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Thông tin khác NXB";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 24);
			this.label3.TabIndex = 19;
			this.label3.Text = "Website NXB";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 17;
			this.label4.Text = "Địa chỉ NXB";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "Tên NXB";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Mã NXB";
			// 
			// frmNXB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.lvNXB);
			this.Name = "frmNXB";
			this.Text = "NXB";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmNXB_Load);
			this.groupBox3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmNXB_Load(object sender, System.EventArgs e)
		{
		
		}

		private void lvNXB_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvNXB.SelectedItems.Count==0)
				return;
			txtMaNXB.Text=lvNXB.SelectedItems[0].SubItems[1].Text;
			txtTenNXB.Text=lvNXB.SelectedItems[0].SubItems[2].Text;
			txtDCNXB.Text=lvNXB.SelectedItems[0].SubItems[3].Text;
			txtWSNXB.Text=lvNXB.SelectedItems[0].SubItems[4].Text;
			txtThongTinNXB.Text=lvNXB.SelectedItems[0].SubItems[5].Text;
		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			SetNull();
			lvNXB.Enabled=false;
			txtMaNXB.Focus();
			opt=1;
		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			if (txtMaNXB.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc xóa NXB này không?",
				"Delete NXB",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"Pro_DeleteNXB",
					CommandType.StoredProcedure,
					"@manxb",txtMaNXB.Text);

				MessageBox.Show("Thông tin NXB này đã bị xóa");
				HienThiNXB();
			}
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(true);
			txtMaNXB.ReadOnly=true;
			txtTenNXB.Focus();
			opt=2;
		}

		private void btnBoqua_Click(object sender, System.EventArgs e)
		{
			SetControlVisible(false);
			lvNXB.Enabled=true;
			HienThiNXB();
		}

		private void btnLuu_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(txtMaNXB.Text==""||txtTenNXB.Text=="")
				{
					MessageBox.Show(this,"Bạn chưa nhập thông tin","Thong bao");
					return;
				}

				SqlHelper.ExecuteNonQuery(
					"Pro_InsertNXB",
					CommandType.StoredProcedure,
					"@option",opt,
					"@manxb",txtMaNXB.Text.Trim(),
					"@tennxb",txtTenNXB.Text.Trim(),
					"@diachinxb",txtDCNXB.Text.Trim(),
					"@websitenxb",txtWSNXB.Text.Trim(),
					"@thongtinkhacnxb",txtThongTinNXB.Text.Trim());
					
					
				HienThiNXB();
				SetControlVisible(false);
				lvNXB.Enabled=true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
