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

        // To show food menus cateogory wise
        public DataSet MenuDetails(string Command, Menu Menu)
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
                    com.Parameters.AddWithValue("@Cat_Id", Menu.Cat_Id);
                    com.Parameters.AddWithValue("@Res_Id", Menu.Res_Id);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "MenuDetails");
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

        // To show table status
        public DataSet TableStatusDetails(string Command, TableStatus TableStatus)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "usp_Mob_Table";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@Res_Id", TableStatus.Res_Id);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TableStatusDetails");
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

        public DataSet TakeOrderDetails(string Command, TakeOrder takeOrder)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "usp_Mob_Order";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@TableName", takeOrder.TableName);
                    com.Parameters.AddWithValue("@RegisterId", takeOrder.RegisterId);
                    com.Parameters.AddWithValue("@EmployeeId", takeOrder.EmployeeId);
                    com.Parameters.AddWithValue("@DeviceId", takeOrder.DeviceId);
                    com.Parameters.AddWithValue("@IsActive", takeOrder.IsActive);
                    com.Parameters.AddWithValue("@intPersonCOunt", takeOrder.intPersonCOunt);
                    com.Parameters.AddWithValue("@ResId", takeOrder.ResId);
                    com.Parameters.AddWithValue("@vchSplitTableName", takeOrder.vchSplitTableName);
                    com.Parameters.AddWithValue("@vchSplit_status", takeOrder.vchSplit_status);
                    com.Parameters.AddWithValue("@Status", takeOrder.Status);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TakeOrderDetails");
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

        public DataSet OrderDetails(string Command, OrderDetails orderDetails)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "usp_Mob_OrderTrasaction";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@OrderId", orderDetails.OrderId);
                    com.Parameters.AddWithValue("@CategoryName", orderDetails.CategoryName);
                    com.Parameters.AddWithValue("@MenuName", orderDetails.MenuName);
                    com.Parameters.AddWithValue("@TableName", orderDetails.TableName);
                    com.Parameters.AddWithValue("@RegisterId", orderDetails.RegisterId);
                    com.Parameters.AddWithValue("@EmployeeId", orderDetails.EmployeeId);
                    com.Parameters.AddWithValue("@Price", orderDetails.Price);
                    com.Parameters.AddWithValue("@Qty", orderDetails.Qty);
                    com.Parameters.AddWithValue("@vchFoodDescription", orderDetails.vchFoodDescription);
                    com.Parameters.AddWithValue("@Kitchen_status", orderDetails.Kitchen_status);
                    com.Parameters.AddWithValue("@status", orderDetails.status);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "OrderDetails");
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

        public DataSet GetOrderId(string Command, TakeOrder takeOrder)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "usp_Mob_Order";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@ResId", takeOrder.ResId);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "GetOrderId");
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

        public DataSet GetKitchenOrder(string Command, TakeOrder takeOrder)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String query = "usp_Mob_GetKitchenOrderList";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Command", Command);
                    com.Parameters.AddWithValue("@ResId", takeOrder.ResId);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "GetKitchenOrderList");
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