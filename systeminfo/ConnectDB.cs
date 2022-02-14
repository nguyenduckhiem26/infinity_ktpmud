using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace systeminfo
{
    public class CLSconnect 
    {
        SqlConnection con;
        string connect = @"Data Source=HOANG-HOI\SQLEXPRESS;Initial Catalog=pm ban lk;Integrated Security=True";
                         
        DataTable dt;

        public SqlConnection OpenConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;

        }
        public SqlConnection CloseConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
        public DataTable LoadDataram()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("ram_loaddl", con);
            
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        public DataTable LoadDataSSD()
        {
            dt = new DataTable();
            OpenConnect();
           
            SqlCommand cmd = new SqlCommand("ssd_load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        public DataTable LoadDataAdmin()
        {
            dt = new DataTable();
            OpenConnect();

            SqlCommand cmd = new SqlCommand("load_bang_admin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        public DataTable LoadDataLaptop()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LOAD_LAPTOP", con);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        DataTable dtRam;
        public DataTable timKiemRam(string stringkey)
        {
            OpenConnect();
            dtRam = new DataTable();
            SqlCommand cmdram = new SqlCommand("ram_timkiemBRAND1", con);
            cmdram.CommandType = CommandType.StoredProcedure;
            cmdram.Parameters.Add(new SqlParameter("Brand", SqlDbType.NVarChar)).Value = stringkey;
            SqlDataAdapter daram = new SqlDataAdapter(cmdram);
            daram.Fill(dtRam);
            CloseConnect();
            return dtRam;

        }
        public DataTable Timkiemssd(string chuoitimkiemssd)
        {
            OpenConnect();
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("ssd_timkiembrand", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Brand", SqlDbType.NVarChar)).Value = chuoitimkiemssd;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        
    }
}
