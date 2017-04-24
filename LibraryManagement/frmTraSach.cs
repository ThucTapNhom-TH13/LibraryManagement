using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmTraSach.
	/// </summary>
	public class frmTraSach : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtNgayMuon;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaPhieu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvSach;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboDocGia;
		private System.Windows.Forms.ComboBox cboNhanVien;
		private System.Windows.Forms.DateTimePicker dtNgayTra;
		private DotNetSkin.SkinControls.SkinButton btnTimMaPhieu;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		private DotNetSkin.SkinControls.SkinButton btnSave;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTraSach()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			HienThiDocGia();
			HienThiNhanVien();
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
				DataTable dtDocGia=SqlHelper.ExecuteDataTable(
					"Pro_DocGia",
					CommandType.StoredProcedure);
				cboDocGia.Items.Clear();
				cboDocGia.DataSource=dtDocGia;
				cboDocGia.DisplayMember="TENDG";
				cboDocGia.ValueMember="MSDG";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		void HienThiNhanVien()
		{
			try
			{
				DataTable dtNhanVien=SqlHelper.ExecuteDataTable(
					"Pro_NhanVien",
					CommandType.StoredProcedure);

				cboNhanVien.Items.Clear();
				cboNhanVien.DataSource=dtNhanVien;
				cboNhanVien.DisplayMember="HOTENNV";
				cboNhanVien.ValueMember="MSNV";

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
					btnSave.Enabled=true;
					
				}
				else
				{
					MessageBox.Show(this,"Mã phiếu mượn không có","Thong bao");
					btnSave.Enabled=false;
					
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
		

		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTraSach));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.cboNhanVien = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboDocGia = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaPhieu = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvSach = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.btnTimMaPhieu = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.btnSave = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.btnTimMaPhieu);
			this.groupBox1.Controls.Add(this.dtNgayTra);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dtNgayMuon);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.cboNhanVien);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboDocGia);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtMaPhieu);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lvSach);
			this.groupBox1.Location = new System.Drawing.Point(96, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 392);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// dtNgayTra
			// 
			this.dtNgayTra.Enabled = false;
			this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgayTra.Location = new System.Drawing.Point(104, 160);
			this.dtNgayTra.Name = "dtNgayTra";
			this.dtNgayTra.Size = new System.Drawing.Size(104, 20);
			this.dtNgayTra.TabIndex = 25;
			this.dtNgayTra.ValueChanged += new System.EventHandler(this.dtNgayTra_ValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Ngày trả";
			// 
			// dtNgayMuon
			// 
			this.dtNgayMuon.Enabled = false;
			this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgayMuon.Location = new System.Drawing.Point(104, 120);
			this.dtNgayMuon.Name = "dtNgayMuon";
			this.dtNgayMuon.Size = new System.Drawing.Size(104, 20);
			this.dtNgayMuon.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Ngày mượn";
			// 
			// cboNhanVien
			// 
			this.cboNhanVien.Enabled = false;
			this.cboNhanVien.ItemHeight = 13;
			this.cboNhanVien.Location = new System.Drawing.Point(104, 88);
			this.cboNhanVien.Name = "cboNhanVien";
			this.cboNhanVien.Size = new System.Drawing.Size(144, 21);
			this.cboNhanVien.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Nhân viên";
			// 
			// cboDocGia
			// 
			this.cboDocGia.Enabled = false;
			this.cboDocGia.ItemHeight = 13;
			this.cboDocGia.Location = new System.Drawing.Point(104, 56);
			this.cboDocGia.Name = "cboDocGia";
			this.cboDocGia.Size = new System.Drawing.Size(144, 21);
			this.cboDocGia.TabIndex = 14;
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
			this.txtMaPhieu.Size = new System.Drawing.Size(120, 20);
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
			// lvSach
			// 
			this.lvSach.BackColor = System.Drawing.Color.White;
			this.lvSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvSach.CheckBoxes = true;
			this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader3,
																					 this.columnHeader4});
			this.lvSach.FullRowSelect = true;
			this.lvSach.GridLines = true;
			this.lvSach.Location = new System.Drawing.Point(8, 184);
			this.lvSach.Name = "lvSach";
			this.lvSach.Size = new System.Drawing.Size(472, 200);
			this.lvSach.TabIndex = 10;
			this.lvSach.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
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
			// btnTimMaPhieu
			// 
			this.btnTimMaPhieu.BackColor = System.Drawing.Color.Transparent;
			this.btnTimMaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimMaPhieu.Image")));
			this.btnTimMaPhieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTimMaPhieu.Location = new System.Drawing.Point(232, 8);
			this.btnTimMaPhieu.Name = "btnTimMaPhieu";
			this.btnTimMaPhieu.Size = new System.Drawing.Size(48, 40);
			this.btnTimMaPhieu.TabIndex = 26;
			this.btnTimMaPhieu.Text = "Tìm";
			this.btnTimMaPhieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTimMaPhieu.Click += new System.EventHandler(this.btnTimMaPhieu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoat.Location = new System.Drawing.Point(368, 408);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(72, 40);
			this.btnThoat.TabIndex = 18;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSave.Location = new System.Drawing.Point(288, 408);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(72, 40);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmTraSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmTraSach";
			this.Text = "frmTraSach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTraSach_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTraSach_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnTimMaPhieu_Click(object sender, System.EventArgs e)
		{
			
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

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			
				
				foreach(ListViewItem item in lvSach.Items)
				{
					if(item.Checked==true)
					{
					
						SqlHelper.ExecuteNonQuery(
							"Pro_LuuPhieuTra",
							CommandType.StoredProcedure,
							"@maphieu",txtMaPhieu.Text.Trim(),
							"@mssach",item.SubItems[1].Text.Trim(),
							"@msnv",cboNhanVien.SelectedValue.ToString(),
							"@ngaytra",dtNgayTra.Value);
						
							SqlHelper.ExecuteNonQuery(
								"Pro_DeleteChiTietPhieuMuon",
								CommandType.StoredProcedure,
								"@maphieu",txtMaPhieu.Text.Trim(),
								"@mssach",item.SubItems[1].Text.Trim());
								
						
						UpdateSL(1,item.SubItems[1].Text.Trim());
					}
				}
				
			
			
			MessageBox.Show(this,"Sách Đã trả","Thong bao");
			HienThiPhieuMuon(txtMaPhieu.Text);
			btnSave.Enabled=false;
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void dtNgayTra_ValueChanged(object sender, System.EventArgs e)
		{
			if(dtNgayTra.Value<=dtNgayMuon.Value)
			{
				MessageBox.Show(this,"Ngày trả phải sau ngày mượn","Thong bao");
				dtNgayTra.Value=DateTime.Now;
				return;
			}
		}

		
	}
}
