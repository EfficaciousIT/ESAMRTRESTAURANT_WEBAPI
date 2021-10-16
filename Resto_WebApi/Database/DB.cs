using System;
using System.Data;
using Resto_WebApi.Models;
using System.Data.SqlClient;

namespace Resto_WebApi.Database
{
    public class DB
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        // To show users login details
        public DataSet LoginDetails(string Command, Login Login)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "Login_SP";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@Username", Login.User_Name);
                    com.Parameters.AddWithValue("@Password", Login.Password);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "LoginDetails");
                    return (ds);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }

        // To show food menus category
        public DataSet MenuCategotyDetails(string Command, Category Category)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "Menu_SP";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@Res_Id", Category.Res_Id);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "MenuCategoryDetails");
                    return (ds);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }

    }

}