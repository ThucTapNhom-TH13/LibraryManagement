using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmTKDG.
	/// </summary>
	public class frmTKDG : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DotNetSkin.SkinControls.SkinButton btnLogin;
		private DotNetSkin.SkinControls.SkinButton btnThoat;
		private System.Windows.Forms.RadioButton optMuon;
		private System.Windows.Forms.RadioButton optTra;
		private System.Windows.Forms.DateTimePicker dtTuNgay;
		private System.Windows.Forms.DateTimePicker dtDenNgay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTKDG()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTKDG));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
			this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
			this.optTra = new System.Windows.Forms.RadioButton();
			this.optMuon = new System.Windows.Forms.RadioButton();
			this.btnLogin = new DotNetSkin.SkinControls.SkinButton();
			this.btnThoat = new DotNetSkin.SkinControls.SkinButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtDenNgay);
			this.groupBox1.Controls.Add(this.dtTuNgay);
			this.groupBox1.Controls.Add(this.optTra);
			this.groupBox1.Controls.Add(this.optMuon);
			this.groupBox1.Location = new System.Drawing.Point(24, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 184);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "đến ngày";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Từ ngày";
			// 
			// dtDenNgay
			// 
			this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDenNgay.Location = new System.Drawing.Point(144, 144);
			this.dtDenNgay.Name = "dtDenNgay";
			this.dtDenNgay.Size = new System.Drawing.Size(104, 20);
			this.dtDenNgay.TabIndex = 3;
			// 
			// dtTuNgay
			// 
			this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtTuNgay.Location = new System.Drawing.Point(32, 144);
			this.dtTuNgay.Name = "dtTuNgay";
			this.dtTuNgay.Size = new System.Drawing.Size(104, 20);
			this.dtTuNgay.TabIndex = 2;
			// 
			// optTra
			// 
			this.optTra.Location = new System.Drawing.Point(16, 56);
			this.optTra.Name = "optTra";
			this.optTra.Size = new System.Drawing.Size(184, 32);
			this.optTra.TabIndex = 1;
			this.optTra.Text = "Số độc giả trể hạn trả sách";
			// 
			// optMuon
			// 
			this.optMuon.Checked = true;
			this.optMuon.Location = new System.Drawing.Point(16, 24);
			this.optMuon.Name = "optMuon";
			this.optMuon.Size = new System.Drawing.Size(192, 24);
			this.optMuon.TabIndex = 0;
			this.optMuon.TabStop = true;
			this.optMuon.Text = "Số độc giả mượn sách";
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLogin.Location = new System.Drawing.Point(88, 224);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(72, 40);
			this.btnLogin.TabIndex = 23;
			this.btnLogin.Text = "Xem";
			this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoat.Location = new System.Drawing.Point(168, 224);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(80, 40);
			this.btnThoat.TabIndex = 24;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmTKDG
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(336, 270);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTKDG";
			this.Text = "Thong ke doc gia";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			SqlHelper.dTuNgay=dtTuNgay.Value;
			SqlHelper.dDenNgay=dtDenNgay.Value;
			if(optMuon.Checked==true)
			{
				frmRptTKDGMuon fMuon=new frmRptTKDGMuon();
				fMuon.MdiParent=frmMain.ActiveForm;
				fMuon.Show();
			}
			else if(optTra.Checked==true)
			{
				frmTKDGTre fTre=new frmTKDGTre();
				fTre.MdiParent=frmMain.ActiveForm;
				fTre.Show();
			}
		}
	}
}
