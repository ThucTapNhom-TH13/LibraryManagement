using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
using System.Data.SqlClient;

namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for frmRptSach.
	/// </summary>
	public class frmRptSach : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer1;
		private Quanlythuvien.rptSach rptSach1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRptSach()
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
			this.ReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.rptSach1 = new Quanlythuvien.rptSach();
			this.SuspendLayout();
			// 
			// ReportViewer1
			// 
			this.ReportViewer1.ActiveViewIndex = -1;
			this.ReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ReportViewer1.DisplayGroupTree = false;
			this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.ReportSource = null;
			this.ReportViewer1.Size = new System.Drawing.Size(800, 600);
			this.ReportViewer1.TabIndex = 0;
			this.ReportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
			// 
			// rptSach1
			// 
			this.rptSach1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation;
			this.rptSach1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;
			this.rptSach1.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper;
			this.rptSach1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default;
			// 
			// frmRptSach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.ReportViewer1);
			this.Name = "frmRptSach";
			this.Text = "frmRptSach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRptSach_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRptSach_Load(object sender, System.EventArgs e)
		{
			if(SqlHelper.ADAPTER!=null)
			{
				dtSach myDataSet=new dtSach();
				SqlHelper.ADAPTER.Fill(myDataSet,"QUYENSACH");
			

				rptSach1=new rptSach();
			
			
				rptSach1.SetDataSource(myDataSet);
				ReportViewer1.ReportSource=rptSach1;
			}
			else
			{
				MessageBox.Show(this,"Không có dữ liệu","Thong bao");
			}
			
		}

		private void ReportViewer1_Load(object sender, System.EventArgs e)
		{
			
		}
	}
}
