using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MenuService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        string constring = "Data Source = (LocalDB)\\MsSqlLocalDb;Initial Catalog = Menu; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string AddItem(Item item)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(constring);
                string query = @"INSERT INTO Menu(Name,Description,Price,Type,Category,Status) Values(@name,@desc,@price,@type,@category,@status)";
                SqlCommand com = new SqlCommand(query,con);
                com.Parameters.AddWithValue("@name", item.Name);
                com.Parameters.AddWithValue("@desc", item.Description);
                com.Parameters.AddWithValue("@price", item.Price);
                com.Parameters.AddWithValue("@type", item.Type);
                com.Parameters.AddWithValue("@category", item.Category);
                com.Parameters.AddWithValue("@status", item.Status);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                result = "Item added successfully!!";

            }
            catch(FaultException fex)
            {
                result = "Error";
            }
            return result;
        }

        public string DeleteItem(Item item)
        {
            SqlConnection con = new SqlConnection(constring);
            string query = "DELETE FROM Menu WHERE Id=@id";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@id", item.Id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            return "Item deleted!!";
        }

        public DataSet getItems()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                string query = "SELECT * from Menu";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return ds;
        }

        public DataSet SearchItem(Item item)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                string Query = "SELECT * FROM Menu WHERE Id=@id";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@id", item.Id);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }

        public string UpdateItem(Item item)
        {
            string res = "";
            SqlConnection con = new SqlConnection(constring);
            string q = "UPDATE Menu SET Name = @name,Description=@desc,Price=@price,Type=@type,Category=@cg,Status=@st WHERE Id=@id";
            SqlCommand com = new SqlCommand(q, con);
            com.Parameters.AddWithValue("@name", item.Name);
            com.Parameters.AddWithValue("@desc", item.Description);
            com.Parameters.AddWithValue("@price", item.Price);
            com.Parameters.AddWithValue("@type", item.Type);
            com.Parameters.AddWithValue("@cg", item.Category);
            com.Parameters.AddWithValue("@st", item.Status);
            com.Parameters.AddWithValue("@id", item.Id);
            con.Open();
            com.ExecuteNonQuery();
            res = "Item updated!!";
            con.Close();
            return res;
        }
    }
}
