using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmTimSach.
	/// </summary>
	public class frmTimSach : System.Windows.Forms.Form
	{
		
		private System.Windows.Forms.Panel panel1;
		private DotNetSkin.SkinControls.SkinButton btnXem;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		private DotNetSkin.SkinControls.SkinButton btnTim;
		private System.Windows.Forms.CheckBox chkNXB;
		private System.Windows.Forms.CheckBox chkLoai;
		private System.Windows.Forms.ComboBox cboLoaiSach;
		private System.Windows.Forms.ComboBox cboNXB;
		private System.Windows.Forms.TextBox txtTacGia;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenSach;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaSach;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ListView lvDMSach;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	
		private int opt=0;
		public frmTimSach()
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
		
		public SqlDataAdapter HienThiSach()
		{
			
			try
			{
				SqlDataAdapter dt=SqlHelper.ExecuteDataAdapter(
					"Pro_TimSach",
					CommandType.StoredProcedure,
					"@option",opt,
					"@masach",txtMaSach.Text.Trim(),
					"@tensach",txtTenSach.Text,
					"@tacgia",txtTacGia.Text,
					"@loai",cboLoaiSach.SelectedValue.ToString().Trim(),
					"@manxb",cboNXB.SelectedValue.ToString().Trim());
				DataSet dtSet=new DataSet();
				dt.Fill(dtSet);
				DataTable dtSach=dtSet.Tables[0];
				
				int i=1;
				lvDMSach.Items.Clear();
				//if(dtSach.Rows.Count<=0) return;
				foreach(DataRow row in dtSach.Rows)
				{
						ListViewItem item=new ListViewItem();
						item.Text=""+i++;
						item.SubItems.Add(row["MSSACH"].ToString());
						item.SubItems.Add(row["TENSACH"].ToString());
						item.SubItems.Add(row["TACGIA"].ToString());

						item.SubItems.Add(row["SOLUONG"].ToString());
					
						lvDMSach.Items.Add(item);
					
				}
				
			return dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTimSach));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.btnTim = new DotNetSkin.SkinControls.SkinButton();
			this.chkNXB = new System.Windows.Forms.CheckBox();
			this.chkLoai = new System.Windows.Forms.CheckBox();
			this.cboLoaiSach = new System.Windows.Forms.ComboBox();
			this.cboNXB = new System.Windows.Forms.ComboBox();
			this.txtTacGia = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenSach = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaSach = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvDMSach = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnXem);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Controls.Add(this.btnTim);
			this.panel1.Controls.Add(this.chkNXB);
			this.panel1.Controls.Add(this.chkLoai);
			this.panel1.Controls.Add(this.cboLoaiSach);
			this.panel1.Controls.Add(this.cboNXB);
			this.panel1.Controls.Add(this.txtTacGia);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtTenSach);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtMaSach);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(16, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 168);
			this.panel1.TabIndex = 2;
			// 
			// btnXem
			// 
			this.btnXem.BackColor = System.Drawing.Color.Transparent;
			this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
			this.btnXem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnXem.Location = new System.Drawing.Point(392, 120);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(72, 40);
			this.btnXem.TabIndex = 46;
			this.btnXem.Text = "In kết quả";
			this.btnXem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoat.Location = new System.Drawing.Point(472, 120);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(56, 40);
			this.btnThoat.TabIndex = 45;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.Transparent;
			this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
			this.btnTim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTim.Location = new System.Drawing.Point(328, 120);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(56, 40);
			this.btnTim.TabIndex = 47;
			this.btnTim.Text = "Tìm";
			this.btnTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// chkNXB
			// 
			this.chkNXB.Location = new System.Drawing.Point(16, 136);
			this.chkNXB.Name = "chkNXB";
			this.chkNXB.Size = new System.Drawing.Size(72, 16);
			this.chkNXB.TabIndex = 44;
			this.chkNXB.Text = "Nhà XB";
			this.chkNXB.CheckedChanged += new System.EventHandler(this.chkNXB_CheckedChanged);
			// 
			// chkLoai
			// 
			this.chkLoai.Location = new System.Drawing.Point(16, 104);
			this.chkLoai.Name = "chkLoai";
			this.chkLoai.Size = new System.Drawing.Size(72, 16);
			this.chkLoai.TabIndex = 43;
			this.chkLoai.Text = "Loại sách";
			this.chkLoai.CheckedChanged += new System.EventHandler(this.chkLoai_CheckedChanged);
			// 
			// cboLoaiSach
			// 
			this.cboLoaiSach.Location = new System.Drawing.Point(112, 104);
			this.cboLoaiSach.Name = "cboLoaiSach";
			this.cboLoaiSach.Size = new System.Drawing.Size(112, 21);
			this.cboLoaiSach.TabIndex = 42;
			this.cboLoaiSach.Visible = false;
			// 
			// cboNXB
			// 
			this.cboNXB.Location = new System.Drawing.Point(112, 136);
			this.cboNXB.Name = "cboNXB";
			this.cboNXB.Size = new System.Drawing.Size(176, 21);
			this.cboNXB.TabIndex = 41;
			this.cboNXB.Visible = false;
			// 
			// txtTacGia
			// 
			this.txtTacGia.Location = new System.Drawing.Point(112, 72);
			this.txtTacGia.MaxLength = 2000;
			this.txtTacGia.Name = "txtTacGia";
			this.txtTacGia.Size = new System.Drawing.Size(192, 20);
			this.txtTacGia.TabIndex = 40;
			this.txtTacGia.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 39;
			this.label3.Text = "Tác giả";
			// 
			// txtTenSach
			// 
			this.txtTenSach.Location = new System.Drawing.Point(112, 40);
			this.txtTenSach.MaxLength = 1000;
			this.txtTenSach.Name = "txtTenSach";
			this.txtTenSach.Size = new System.Drawing.Size(176, 20);
			this.txtTenSach.TabIndex = 38;
			this.txtTenSach.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 37;
			this.label2.Text = "Tên sách";
			// 
			// txtMaSach
			// 
			this.txtMaSach.Location = new System.Drawing.Point(112, 8);
			this.txtMaSach.MaxLength = 10;
			this.txtMaSach.Name = "txtMaSach";
			this.txtMaSach.Size = new System.Drawing.Size(88, 20);
			this.txtMaSach.TabIndex = 36;
			this.txtMaSach.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 35;
			this.label1.Text = "Mã sách";
			// 
			// lvDMSach
			// 
			this.lvDMSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvDMSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2,
																					   this.columnHeader3,
																					   this.columnHeader4,
																					   this.columnHeader5});
			this.lvDMSach.FullRowSelect = true;
			this.lvDMSach.GridLines = true;
			this.lvDMSach.Location = new System.Drawing.Point(16, 176);
			this.lvDMSach.Name = "lvDMSach";
			this.lvDMSach.Size = new System.Drawing.Size(760, 232);
			this.lvDMSach.TabIndex = 3;
			this.lvDMSach.View = System.Windows.Forms.View.Details;
			this.lvDMSach.DoubleClick += new System.EventHandler(this.lvDMSach_DoubleClick);
			this.lvDMSach.SelectedIndexChanged += new System.EventHandler(this.lvDMSach_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã sách";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên sách";
			this.columnHeader3.Width = 300;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tác giả";
			this.columnHeader4.Width = 200;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Số lượng";
			this.columnHeader5.Width = 100;
			// 
			// frmTimSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.lvDMSach);
			this.Controls.Add(this.panel1);
			this.Name = "frmTimSach";
			this.Text = "Tim Sach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTimSach_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTimSach_Load(object sender, System.EventArgs e)
		{
		
		}

		

		private void btnTim_Click(object sender, System.EventArgs e)
		{
		   if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text==""
			   && chkLoai.Checked==false && chkNXB.Checked==false)
			   opt=1;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==false && chkNXB.Checked==false)
				opt=2;
			else if(txtMaSach.Text!="" && txtTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoai.Checked==false && chkNXB.Checked==false)
				opt=3;
			else if(txtMaSach.Text!="" && txtTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoai.Checked==false && chkNXB.Checked==false)
				opt=4;
			else if(txtMaSach.Text!="" && txtTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=5;
			else if(txtMaSach.Text!="" && txtTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==true)
				opt=6;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoai.Checked==false && chkNXB.Checked==false)
				opt=7;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoai.Checked==false && chkNXB.Checked==false)
				opt=8;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=9;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text!=""
				&& chkLoai.Checked==false && chkNXB.Checked==true)
				opt=10;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text!="" 
			   && chkLoai.Checked==false && chkNXB.Checked==false)
				opt=11;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=12;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==true)
				opt=13;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=14;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==true && chkNXB.Checked==true)
				opt=15;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoai.Checked==false && chkNXB.Checked==false)
				opt=16;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=17;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoai.Checked==true && chkNXB.Checked==true)
				opt=18;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=19;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==true && chkNXB.Checked==true)
				opt=20;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoai.Checked==true && chkNXB.Checked==false)
				opt=21;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoai.Checked==true && chkNXB.Checked==true)
				opt=22;
			else if(txtMaSach.Text=="" && txtTenSach.Text!="" && txtTacGia.Text==""
				&& chkLoai.Checked==false && chkNXB.Checked==true)
				opt=23;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text!=""
				&& chkLoai.Checked==false && chkNXB.Checked==true)
				opt=24;
			else if(txtMaSach.Text=="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==false && chkNXB.Checked==true)
				opt=25;
			else if(txtMaSach.Text!="" && txtTenSach.Text=="" && txtTacGia.Text==""
				&& chkLoai.Checked==false && chkNXB.Checked==true)
				opt=26;


			SqlHelper.ADAPTER=null;
		   SqlHelper.ADAPTER=HienThiSach();
		}

		private void btnXem_Click(object sender, System.EventArgs e)
		{
			
			frmRptSach frpt=new frmRptSach();
			frpt.MdiParent=frmMain.ActiveForm;
			frpt.Show();
			
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void chkLoai_CheckedChanged(object sender, System.EventArgs e)
		{
			cboLoaiSach.Visible=chkLoai.Checked;
			

		}

		private void chkNXB_CheckedChanged(object sender, System.EventArgs e)
		{
			cboNXB.Visible=chkNXB.Checked;
			
		}

		private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}

		private void lvDMSach_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvDMSach.SelectedItems.Count==0)
				return;
			SqlHelper.strMaSach=lvDMSach.SelectedItems[0].SubItems[1].Text;
		}

		private void lvDMSach_DoubleClick(object sender, System.EventArgs e)
		{
			if (lvDMSach.SelectedItems.Count==0)
				return;
			SqlHelper.strMaSach=lvDMSach.SelectedItems[0].SubItems[1].Text;
			frmChiTietSach fChiTiet=new frmChiTietSach();
			fChiTiet.ShowDialog();
		
		}

		

		
	}
}
