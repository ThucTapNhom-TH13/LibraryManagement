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
	/// Summary description for frmTimSachMuon.
	/// </summary>
	public class frmTimSachMuon : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Panel panel1;
		private DotNetSkin.SkinControls.SkinButton btnXem;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		private DotNetSkin.SkinControls.SkinButton btnTim;
		private System.Windows.Forms.RadioButton optSachMuon;
		private System.Windows.Forms.RadioButton optSachTre;
		private System.Windows.Forms.RadioButton optSachTra;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ListView lvSachMuon;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private int opt=0;
		public  SqlDataAdapter HienThiPhieuMuon()
		{
			try
			{
				SqlDataAdapter dt=SqlHelper.ExecuteDataAdapter(
					"Pro_TimPhieuMuon",
					CommandType.StoredProcedure,
					"@opt",opt);
				DataSet dtSet=new DataSet();
				dt.Fill(dtSet);
				DataTable dtCTPhieuMuon=dtSet.Tables[0];
				int i=1;
				lvSachMuon.Items.Clear();
				
				foreach(DataRow row in dtCTPhieuMuon.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["SOPHIEUMUON"].ToString());

					DataTable dtTenDG=SqlHelper.ExecuteDataTable(
						"Pro_SelectTenDG",
						CommandType.StoredProcedure,"@msdg",row["MSDG"].ToString().Trim());
					item.SubItems.Add(dtTenDG.Rows[0]["TENDG"].ToString());	

					DataTable dtTenSach=SqlHelper.ExecuteDataTable(
						"Pro_SelectSach",
						CommandType.StoredProcedure,"@mssach",row["MSSACH"].ToString().Trim());
					item.SubItems.Add(dtTenSach.Rows[0]["TENSACH"].ToString());	
					item.SubItems.Add(row["NGAYMUON"].ToString());	
					if(opt!=3)
					{
						item.SubItems.Add(row["HANTRA"].ToString());	
						lvSachMuon.Columns[5].Text="Hạn trả";
					}
					else
					{
						item.SubItems.Add(row["NGAYTRA"].ToString());	
						lvSachMuon.Columns[5].Text="Ngày trả";
					}

					lvSachMuon.Items.Add(item);
					
				}
				return dt;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}


		}
		public frmTimSachMuon()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTimSachMuon));
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.lvSachMuon = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.optSachTra = new System.Windows.Forms.RadioButton();
			this.optSachTre = new System.Windows.Forms.RadioButton();
			this.optSachMuon = new System.Windows.Forms.RadioButton();
			this.btnXem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.btnTim = new DotNetSkin.SkinControls.SkinButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số phiếu";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày mượn";
			this.columnHeader5.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tên sách";
			this.columnHeader4.Width = 220;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// lvSachMuon
			// 
			this.lvSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvSachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader1,
																						 this.columnHeader2,
																						 this.columnHeader3,
																						 this.columnHeader4,
																						 this.columnHeader5,
																						 this.columnHeader6});
			this.lvSachMuon.FullRowSelect = true;
			this.lvSachMuon.GridLines = true;
			this.lvSachMuon.Location = new System.Drawing.Point(8, 152);
			this.lvSachMuon.Name = "lvSachMuon";
			this.lvSachMuon.Size = new System.Drawing.Size(736, 288);
			this.lvSachMuon.TabIndex = 7;
			this.lvSachMuon.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Họ tên DG";
			this.columnHeader3.Width = 200;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Hạn trả";
			this.columnHeader6.Width = 100;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.optSachTra);
			this.panel1.Controls.Add(this.optSachTre);
			this.panel1.Controls.Add(this.optSachMuon);
			this.panel1.Controls.Add(this.btnXem);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Controls.Add(this.btnTim);
			this.panel1.Location = new System.Drawing.Point(8, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(736, 136);
			this.panel1.TabIndex = 6;
			// 
			// optSachTra
			// 
			this.optSachTra.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optSachTra.Location = new System.Drawing.Point(24, 88);
			this.optSachTra.Name = "optSachTra";
			this.optSachTra.Size = new System.Drawing.Size(128, 32);
			this.optSachTra.TabIndex = 50;
			this.optSachTra.Text = "Số sách đã trả";
			// 
			// optSachTre
			// 
			this.optSachTre.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optSachTre.Location = new System.Drawing.Point(24, 56);
			this.optSachTre.Name = "optSachTre";
			this.optSachTre.Size = new System.Drawing.Size(128, 32);
			this.optSachTre.TabIndex = 49;
			this.optSachTre.Text = "Số sách trả trể hạn";
			// 
			// optSachMuon
			// 
			this.optSachMuon.Checked = true;
			this.optSachMuon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optSachMuon.Location = new System.Drawing.Point(24, 16);
			this.optSachMuon.Name = "optSachMuon";
			this.optSachMuon.Size = new System.Drawing.Size(128, 32);
			this.optSachMuon.TabIndex = 48;
			this.optSachMuon.TabStop = true;
			this.optSachMuon.Text = "Số sách đang mượn";
			// 
			// btnXem
			// 
			this.btnXem.BackColor = System.Drawing.Color.Transparent;
			this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
			this.btnXem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnXem.Location = new System.Drawing.Point(352, 80);
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
			this.btnThoat.Location = new System.Drawing.Point(432, 80);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(56, 40);
			this.btnThoat.TabIndex = 45;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.Transparent;
			this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
			this.btnTim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTim.Location = new System.Drawing.Point(288, 80);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(56, 40);
			this.btnTim.TabIndex = 47;
			this.btnTim.Text = "Tìm";
			this.btnTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// frmTimSachMuon
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.lvSachMuon);
			this.Controls.Add(this.panel1);
			this.Name = "frmTimSachMuon";
			this.Text = "frmTimSachMuon";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnTim_Click(object sender, System.EventArgs e)
		{
			if(optSachMuon.Checked==true)
			{
				opt=1;
				SqlHelper.ADAPTER=HienThiPhieuMuon();
			}
			if(optSachTre.Checked==true)
			{
				opt=2;
				HienThiPhieuMuon();
			}
			if(optSachTra.Checked==true)
			{
				opt=3;
				HienThiPhieuMuon();
			}
			
		}

		private void btnXem_Click(object sender, System.EventArgs e)
		{
			if(opt==1)
			{
				frmRptSachMuon fMuon=new frmRptSachMuon();
				fMuon.MdiParent=frmMain.ActiveForm;
				fMuon.Show();
			}
			else if(opt==2)
			{
				frmRptSachTre fTre=new frmRptSachTre();
				fTre.MdiParent=frmMain.ActiveForm;
				fTre.Show();
			}
			else if(opt==3)
			{
				frmRptSachTra fTra=new frmRptSachTra();
				fTra.MdiParent=frmMain.ActiveForm;
				fTra.Show();
			}

		}
	}
}
