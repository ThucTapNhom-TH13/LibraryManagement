using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmRptDG.
	/// </summary>
	public class frmRptDG : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer;
		private Quanlythuvien.rptDocGia rptDocGia1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRptDG()
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
			this.ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.rptDocGia1 = new Quanlythuvien.rptDocGia();
			this.SuspendLayout();
			// 
			// ReportViewer
			// 
			this.ReportViewer.ActiveViewIndex = -1;
			this.ReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ReportViewer.DisplayGroupTree = false;
			this.ReportViewer.Location = new System.Drawing.Point(0, 0);
			this.ReportViewer.Name = "ReportViewer";
			this.ReportViewer.ReportSource = null;
			this.ReportViewer.Size = new System.Drawing.Size(800, 600);
			this.ReportViewer.TabIndex = 0;
			// 
			// rptDocGia1
			// 
			this.rptDocGia1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation;
			this.rptDocGia1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;
			this.rptDocGia1.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper;
			this.rptDocGia1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default;
			// 
			// frmRptDG
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.ReportViewer);
			this.Name = "frmRptDG";
			this.Text = "frmRptDG";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRptDG_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRptDG_Load(object sender, System.EventArgs e)
		{
			if(SqlHelper.ADAPTER!=null)
			{
				dtDocGia myDataSet=new dtDocGia();
				SqlHelper.ADAPTER.Fill(myDataSet,"DOCGIA");
			

				rptDocGia1=new rptDocGia();
			
			
				rptDocGia1.SetDataSource(myDataSet);
				ReportViewer.ReportSource=rptDocGia1;
			}
			else
			{
				MessageBox.Show(this,"Không có dữ liệu","Thong bao");
			}
		}
	}
}
