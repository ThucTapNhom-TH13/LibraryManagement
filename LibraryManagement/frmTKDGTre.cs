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
	/// Summary description for frmTKDGTre.
	/// </summary>
	public class frmTKDGTre : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer;
		private Quanlythuvien.rptTKDGTre rptTKDGTre1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTKDGTre()
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
			this.rptTKDGTre1 = new Quanlythuvien.rptTKDGTre();
			this.SuspendLayout();
			// 
			// ReportViewer
			// 
			this.ReportViewer.ActiveViewIndex = -1;
			this.ReportViewer.DisplayGroupTree = false;
			this.ReportViewer.Location = new System.Drawing.Point(0, 0);
			this.ReportViewer.Name = "ReportViewer";
			this.ReportViewer.ReportSource = null;
			this.ReportViewer.Size = new System.Drawing.Size(800, 600);
			this.ReportViewer.TabIndex = 0;
			// 
			// rptTKDGTre1
			// 
			this.rptTKDGTre1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation;
			this.rptTKDGTre1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;
			this.rptTKDGTre1.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper;
			this.rptTKDGTre1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default;
			// 
			// frmTKDGTre
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.ReportViewer);
			this.Name = "frmTKDGTre";
			this.Text = "frmTKDGTre";
			this.Load += new System.EventHandler(this.frmTKDGTre_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTKDGTre_Load(object sender, System.EventArgs e)
		{
		
			dtTKDGTre myDataSet=new dtTKDGTre();
						
			string sql="select * from docgia";
			SqlConnection con=new SqlConnection(SqlHelper.ConnectString);
			SqlDataAdapter adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"docgia");
			

			sql="select * from muonsach where ngaymuon>='"+
				SqlHelper.dTuNgay+"' and ngaymuon<='"+SqlHelper.dDenNgay+"'";
			con=new SqlConnection(SqlHelper.ConnectString);
			adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"muonsach");

			sql="select * from chitietphieumuon"+
				" inner join muonsach on chitietphieumuon.sophieumuon=muonsach.sophieumuon"+
				" where hantra<'"+DateTime.Now+"'";
			con=new SqlConnection(SqlHelper.ConnectString);
			adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"chitietphieumuon");

				
			rptTKDGTre1=new rptTKDGTre();
				
			
			rptTKDGTre1.SetDataSource(myDataSet);
			ReportViewer.ReportSource=rptTKDGTre1;
			
		}
	}
}
