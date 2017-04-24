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
	/// Summary description for frmRptSachTra.
	/// </summary>
	public class frmRptSachTra : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Quanlythuvien.rptSachTra rptSachTra1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRptSachTra()
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
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.rptSachTra1 = new Quanlythuvien.rptSachTra();
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
			this.ReportViewer.Load += new System.EventHandler(this.ReportViewer_Load);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "MUONSACH", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("SOPHIEUMUON", "SOPHIEUMUON"),
																																																					new System.Data.Common.DataColumnMapping("MSDG", "MSDG"),
																																																					new System.Data.Common.DataColumnMapping("MSNV", "MSNV"),
																																																					new System.Data.Common.DataColumnMapping("NGAYMUON", "NGAYMUON"),
																																																					new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
																																																					new System.Data.Common.DataColumnMapping("MSSACH", "MSSACH"),
																																																					new System.Data.Common.DataColumnMapping("Expr2", "Expr2"),
																																																					new System.Data.Common.DataColumnMapping("NGAYTRA", "NGAYTRA")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT MUONSACH.SOPHIEUMUON, MUONSACH.MSDG, MUONSACH.MSNV, MUONSACH.NGAYMUON, TRA" +
				"SACH.SOPHIEUMUON AS Expr1, TRASACH.MSSACH, TRASACH.MSNV AS Expr2, TRASACH.NGAYTR" +
				"A FROM MUONSACH INNER JOIN TRASACH ON MUONSACH.SOPHIEUMUON = TRASACH.SOPHIEUMUON" +
				"";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Integrated Security=SSPI;Packet Size=4096;Data Source=THANH;Tag with column collation when possible=False;Initial Catalog=Thuvien;Use Procedure for Prepare=1;Auto Translate=True;Persist Security Info=False;Provider=""SQLOLEDB.1"";Workstation ID=THANH;Use Encryption for Data=False";
			// 
			// rptSachTra1
			// 
			this.rptSachTra1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation;
			this.rptSachTra1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;
			this.rptSachTra1.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper;
			this.rptSachTra1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default;
			// 
			// frmRptSachTra
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.ReportViewer);
			this.Name = "frmRptSachTra";
			this.Text = "frmRptSachTra";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRptSachTra_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRptSachTra_Load(object sender, System.EventArgs e)
		{
			dtSachTra myDataSet=new dtSachTra();
						
			string sql="select * from docgia";
			SqlConnection con=new SqlConnection(SqlHelper.ConnectString);
			SqlDataAdapter adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"docgia");
			
			sql="select * from quyensach";
			con=new SqlConnection(SqlHelper.ConnectString);
			adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"quyensach");

			sql="select * from muonsach";
			con=new SqlConnection(SqlHelper.ConnectString);
			adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"muonsach");

			sql="select * from trasach";
			con=new SqlConnection(SqlHelper.ConnectString);
			adapter=new SqlDataAdapter(sql,con);
			adapter.Fill(myDataSet,"trasach");

				
			rptSachTra1=new rptSachTra();
				
			
			rptSachTra1.SetDataSource(myDataSet);
			ReportViewer.ReportSource=rptSachTra1;
			
			
		}

		private void ReportViewer_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
