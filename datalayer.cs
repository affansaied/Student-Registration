using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Projectsms
{
    class datalayer
    {
        SqlConnection conn_;
        SqlCommand cmd_;
        SqlDataReader reader_;
        SqlDataAdapter adptr_;
        System.Data.DataSet dset_;
        System.Data.DataTable dt_;
        static string getmessage { get; set; }

        public datalayer()
        {
            string cs = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            conn_ = new SqlConnection(cs);
            cmd_ = new SqlCommand();
            adptr_ = new SqlDataAdapter();
            dset_ = new System.Data.DataSet();
           
        }

        public bool Connect()
        {
            try
            {
                conn_.Open();
                getmessage = "Connection established!";
                return true;
            }
            catch (Exception exp)
            {
                getmessage = "error while opening connection (Datalayer=>Connect()) : " + exp.Message;
                return false;

            }


        }

        public bool Disconnect()
        {

            try
            {
                conn_.Close();
                getmessage = "Connection Closed Successfully!";
                return true;
            }
            catch (Exception exp)
            {
                getmessage = "error while Closing connection (Datalayer=>Disconnect()) : " + exp.Message;
                return false;

            }

        }

        public string insertUpdateCreateOrDelete(string query)
        {
            string ret = "";
            string allqueries = query.ToLower();
            try
            {
                cmd_.CommandText = query;
                cmd_.Connection = conn_;
                Connect();

                cmd_.ExecuteNonQuery();
                if (allqueries.Contains("insert into "))
                {
                    ret = getmessage = "inserted Successfully!";
                }
                else if (allqueries.Contains("delete from "))
                {
                    ret = getmessage = "Deleted Successfully!";
                }
                else if (allqueries.Contains("create table "))
                {
                    ret = getmessage = "Table Created Successfully!";
                }
                else if (allqueries.Contains("update ") && allqueries.Contains("set= "))
                {
                    ret = getmessage = "Updated Successfully";
                }


            }
            catch (Exception exp)
            {

                ret = getmessage = "Failed to execute " + query + " \n Reason : " + exp.Message;
            }
            finally { Disconnect(); }
            return ret;
        }

        public string fillgridView(string query, System.Web.UI.WebControls.GridView dgv)
        {
            dt_ = new System.Data.DataTable();
            string stret;
            try
            {
                cmd_.Connection = conn_;
                cmd_.CommandText = query.ToLower();
                Connect();
                adptr_.SelectCommand = cmd_;

                adptr_.Fill(dt_);

                dgv.DataSource = dt_;
                dgv.DataBind();
     

                stret = "Code Executed Successfully (filldatagridView()=> datalayer.cs)";

            }
            catch (Exception exp)
            {

                stret = "Failed (filldatagridView()=> datalayer.cs) : " + exp.Message;

            }
            finally
            {
                Disconnect();
                dt_ = null;
            }
            return stret;

        } 
    }

}
