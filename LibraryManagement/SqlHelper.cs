using System;
using System.Data;
using System.Data.SqlClient;

namespace Quanlythuvien
{
	/// <summary>
	/// Summary description for SqlHelper.
	/// </summary>
	public class SqlHelper
	{
		
		public static string ConnectString = @"Data Source=LINH\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True";
		public static string strMaSach="";
		public static string strMaNV="";
		public static string strMaDG="";
		public static SqlDataAdapter ADAPTER;
		public static DateTime dTuNgay=DateTime.Now;
		public static DateTime dDenNgay=DateTime.Now;
		//public static string ConnectString="data source=.;database=quanlithuvien;uid=sa;password=";
		public SqlHelper()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static DataTable ExecuteDataTable(
			string sql,
			CommandType commandType,
			params object[] pars)
		{
			SqlConnection con=new SqlConnection(ConnectString);
			
			SqlCommand com=new SqlCommand(sql,con);
			com.CommandType=commandType;

			for (int i=0;i<pars.Length;i+=2)
			{
				SqlParameter par=new SqlParameter(pars[i].ToString(),pars[i+1]);
				com.Parameters.Add(par);
			}

			SqlDataAdapter dad=new SqlDataAdapter(com);

			DataSet dst=new DataSet();
			dad.Fill(dst);
			
			return dst.Tables[0];
		}

		public static void ExecuteNonQuery(
			string sql,
			CommandType commandType,
			params object[] pars)
		{
			SqlConnection con=new SqlConnection(ConnectString);
			con.Open();
			
			SqlCommand com=new SqlCommand(sql,con);
			com.CommandType=commandType;

			for (int i=0;i<pars.Length;i+=2)
			{
				SqlParameter par=new SqlParameter(pars[i].ToString(),pars[i+1]);
				com.Parameters.Add(par);
			}

			com.ExecuteNonQuery();
		}


		public static SqlDataAdapter ExecuteDataAdapter(
			string sql,
			CommandType commandType,
			params object[] pars)
		{
			SqlConnection con=new SqlConnection(ConnectString);	
			SqlCommand com=new SqlCommand(sql,con);
			com.CommandType=commandType;

			for (int i=0;i<pars.Length;i+=2)
			{
				SqlParameter par=new SqlParameter(pars[i].ToString(),pars[i+1]);
				com.Parameters.Add(par);
			}

			SqlDataAdapter dad=new SqlDataAdapter(com);

			//DataSet dst=new DataSet();
			//dad.Fill(dst);
			
			return dad;
		}

	}
}
