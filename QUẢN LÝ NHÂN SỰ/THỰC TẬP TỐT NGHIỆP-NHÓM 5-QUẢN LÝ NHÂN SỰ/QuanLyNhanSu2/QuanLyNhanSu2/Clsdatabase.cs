using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Configuration;

namespace QuanLyNhanSu2
{
    class Clsdatabase
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();
        void Ketnoi()
        {
            sqlcon = new SqlConnection(strCon);
            sqlcon.Open();
        }
        void NgatKetnoi()
        {
            sqlcon.Close();
        }
        public void Thucthiketnoi(string strsql)
        {
            Ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqlcom.ExecuteNonQuery();
            NgatKetnoi();
        }
        public void LoadDatagridview(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, strCon);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }
        public void loaddatagridview1(DataGridView dg, DataSet ds1, string strselect)
        {
            ds1.Clear();
            sqlda = new SqlDataAdapter(strselect, strCon);
            sqlda.Fill(ds1, "tenbang");
            dg.DataSource = ds1.Tables[0];
        }
        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            Ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            NgatKetnoi();
        }
        public void loadtextbox(TextBox cb, string strselect)
        {
            Ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[0].ToString();
            }
            NgatKetnoi();
        }
        public void loaddatetime(DateTimePicker cb, string strselect, byte chiso)
        {
            Ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            NgatKetnoi();
        }
        public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        {
            Ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            NgatKetnoi();
        }
        public string getdata(string dauvao, string strsql)
        {
            string strketqua = "";
            Ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[1].ToString();
            }
            NgatKetnoi();
            return strketqua;
        }
        public bool kt(string dauvao, string strsql, byte chiso)
        {
            bool ok = false;
            Ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[chiso].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            NgatKetnoi();
            return ok;
        }

        public string thu(string dauvao, string strsql)
        {
            string strketqua = "";
            Ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[0].ToString();
            }
            NgatKetnoi();
            return strketqua;
        }

        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool ok = false;
            Ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            NgatKetnoi();
            return ok;
        }

        public void loatextbox(TextBox tb, string strselect, byte chiso)
        {
            Ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                tb.Lines[0] = (sqldr[chiso].ToString());
            }
            NgatKetnoi();
        }
    }
}
