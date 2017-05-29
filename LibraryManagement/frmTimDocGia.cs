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
	/// Summary description for Form1.
	/// </summary>
	public class frmTimDocGia : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Panel panel1;
		private DotNetSkin.SkinControls.SkinButton btnXem;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		private DotNetSkin.SkinControls.SkinButton btnTim;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaDG;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvDocgia;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private int opt=0;
		public frmTimDocGia()
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
		#region Methods
		public SqlDataAdapter HienThiDocGia()
		{
			try
			{
				SqlDataAdapter dt=SqlHelper.ExecuteDataAdapter(
					"Pro_TimDocGia",
					CommandType.StoredProcedure,
					"@option",opt,
					"@msdg",txtMaDG.Text.Trim(),
					"@tendg",txtHoTen.Text.Trim(),
					"@diachi",txtDiaChi.Text,
					"@email",txtEmail.Text);

				int i=1;
				lvDocgia.Items.Clear();
				DataSet dtSet=new DataSet();
				dt.Fill(dtSet);
				DataTable dtDocgia=dtSet.Tables[0];
				
				foreach(DataRow row in dtDocgia.Rows)
				{
					ListViewItem item=new ListViewItem();
					item.Text=""+i++;
					item.SubItems.Add(row["MSDG"].ToString());
					item.SubItems.Add(row["TENDG"].ToString());
					item.SubItems.Add(row["DIACHI"].ToString());
					item.SubItems.Add(row["NGAYSINH"].ToString());
					
				
					lvDocgia.Items.Add(item);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTimDocGia));
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.lvDocgia = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnXem = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.btnTim = new DotNetSkin.SkinControls.SkinButton();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaDG = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Năm sinh";
			this.columnHeader5.Width = 100;
			// 
			// lvDocgia
			// 
			this.lvDocgia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvDocgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2,
																					   this.columnHeader3,
																					   this.columnHeader4,
																					   this.columnHeader5});
			this.lvDocgia.FullRowSelect = true;
			this.lvDocgia.GridLines = true;
			this.lvDocgia.Location = new System.Drawing.Point(16, 184);
			this.lvDocgia.Name = "lvDocgia";
			this.lvDocgia.Size = new System.Drawing.Size(760, 256);
			this.lvDocgia.TabIndex = 5;
			this.lvDocgia.View = System.Windows.Forms.View.Details;
			this.lvDocgia.DoubleClick += new System.EventHandler(this.lvDocgia_DoubleClick);
			this.lvDocgia.SelectedIndexChanged += new System.EventHandler(this.lvDocgia_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã DG";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Họ tên";
			this.columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Đia chỉ";
			this.columnHeader4.Width = 300;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnXem);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Controls.Add(this.btnTim);
			this.panel1.Controls.Add(this.txtDiaChi);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtHoTen);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtMaDG);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(16, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 168);
			this.panel1.TabIndex = 4;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(112, 104);
			this.txtEmail.MaxLength = 2000;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(192, 20);
			this.txtEmail.TabIndex = 49;
			this.txtEmail.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 48;
			this.label4.Text = "Email";
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
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(112, 72);
			this.txtDiaChi.MaxLength = 2000;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(192, 20);
			this.txtDiaChi.TabIndex = 40;
			this.txtDiaChi.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 39;
			this.label3.Text = "Địa chỉ";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(112, 40);
			this.txtHoTen.MaxLength = 1000;
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(176, 20);
			this.txtHoTen.TabIndex = 38;
			this.txtHoTen.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 37;
			this.label2.Text = "Họ Tên";
			// 
			// txtMaDG
			// 
			this.txtMaDG.Location = new System.Drawing.Point(112, 8);
			this.txtMaDG.MaxLength = 10;
			this.txtMaDG.Name = "txtMaDG";
			this.txtMaDG.Size = new System.Drawing.Size(88, 20);
			this.txtMaDG.TabIndex = 36;
			this.txtMaDG.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 35;
			this.label1.Text = "Mã độc giả";
			// 
			// frmTimDocGia
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.lvDocgia);
			this.Controls.Add(this.panel1);
			this.Name = "frmTimDocGia";
			this.Text = "Tim doc gia";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
		}

		private void btnTim_Click(object sender, System.EventArgs e)
		{

            if (txtMaDG.Text == "" && txtHoTen.Text == "" && txtDiaChi.Text == "" &&
                txtEmail.Text == "")
                opt = 1;
            else if (txtMaDG.Text != "" && txtHoTen.Text == "" && txtDiaChi.Text == "" &&
                txtEmail.Text == "")
                opt = 2;
            else if (txtMaDG.Text != "" && txtHoTen.Text == "" && txtDiaChi.Text == ""
                && txtEmail.Text == "")
                opt = 2;
            else if (txtMaDG.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text == ""
                && txtEmail.Text == "")
                opt = 3;
            else if (txtMaDG.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != ""
                && txtEmail.Text == "")
                opt = 4;
            else if (txtMaDG.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != ""
                && txtEmail.Text != "")
                opt = 5;
            else if (txtMaDG.Text == "" && txtHoTen.Text != "" && txtDiaChi.Text == ""
                && txtEmail.Text == "")
                opt = 6;
            else if (txtMaDG.Text == "" && txtHoTen.Text != "" && txtDiaChi.Text != ""
                && txtEmail.Text == "")
                opt = 7;
            else if (txtMaDG.Text == "" && txtHoTen.Text != "" && txtDiaChi.Text != ""
                && txtEmail.Text != "")
                opt = 8;
            else if (txtMaDG.Text == "" && txtHoTen.Text == "" && txtDiaChi.Text != ""
                && txtEmail.Text == "")
                opt = 9;
            else if (txtMaDG.Text == "" && txtHoTen.Text == "" && txtDiaChi.Text != ""
                && txtEmail.Text != "")
                opt = 10;
            else if (txtMaDG.Text == "" && txtHoTen.Text == "" && txtDiaChi.Text == ""
                && txtEmail.Text != "")
                opt = 11;
            else if (txtMaDG.Text != "" && txtHoTen.Text == "" && txtDiaChi.Text != ""
                && txtEmail.Text == "")
                opt = 12;
            else if (txtMaDG.Text != "" && txtHoTen.Text == "" && txtDiaChi.Text != ""
                && txtEmail.Text != "")
                opt = 13;
            else if (txtMaDG.Text != "" && txtHoTen.Text == "" && txtDiaChi.Text == ""
                && txtEmail.Text != "")
                opt = 14;
            else if (txtMaDG.Text == "" && txtHoTen.Text != "" && txtDiaChi.Text == ""
                && txtEmail.Text != "")
                opt = 15;
            SqlHelper.ADAPTER = null;
            SqlHelper.ADAPTER = HienThiDocGia();

        }

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void lvDocgia_SelectedIndexChanged(object sender, System.EventArgs e)
		{
           
        }

		private void lvDocgia_DoubleClick(object sender, System.EventArgs e)
		{

            if (lvDocgia.SelectedItems.Count == 0)
                return;
            SqlHelper.strMaDG = lvDocgia.SelectedItems[0].SubItems[1].Text.Trim();
            frmChiTietDG fDG = new frmChiTietDG();
            fDG.ShowDialog();
        }

		private void btnXem_Click(object sender, System.EventArgs e)
		{
            frmRptDG rptdg = new frmRptDG();
            rptdg.MdiParent = frmMain.ActiveForm;
            rptdg.Show();
        }
	}
}
