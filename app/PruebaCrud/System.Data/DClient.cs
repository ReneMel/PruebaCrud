using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Entities;

namespace System.DData
{
    public class DClient
    {

        public DataTable listClients() {

            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("client_list", cn);
                command.CommandType = CommandType.StoredProcedure;

                cn.Open();

                result = command.ExecuteReader();

                table.Load(result);
                return table;


            }
            catch (Exception) {
                throw;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }


        }
        //delete
        public bool deleteClient (int id)
        {

            bool deleted = false;
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                new SqlParameter("@id", SqlDbType.Int) {
                    Value = id
                }
            };

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("client_delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                deleted = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception)
            {
                throw;
            }


            return deleted;
        }

        //update

        public bool updateClient(string name, string lastname, string dui, DateTime bd, int id) {
            bool updated = false;
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                new SqlParameter("@clientName", SqlDbType.VarChar) {
                    Value = name
                },
                new SqlParameter("@clientLastname", SqlDbType.VarChar) {
                    Value = lastname
                },
                new SqlParameter("@dui", SqlDbType.VarChar) {
                    Value = dui
                },
                new SqlParameter("@date", SqlDbType.Date) {
                    Value = bd
                },
                new SqlParameter("@id", SqlDbType.Int) {
                    Value = id
                },
            };


            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("client_update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                updated = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception)
            {
                throw;
            }


            return updated;


        }

        //insert

        public bool InsertClient(string name, string lastname, string dui, DateTime bd)
        {
            bool inserted = false;
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                new SqlParameter("@clientName", SqlDbType.VarChar) {
                    Value = name
                },
                new SqlParameter("@clientLastname", SqlDbType.VarChar) {
                    Value = lastname
                },
                new SqlParameter("@dui", SqlDbType.VarChar) {
                    Value = dui
                },
                new SqlParameter("@date", SqlDbType.Date) {
                    Value = bd
                },
            };


            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("client_create", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                inserted = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception)
            {
                throw;
            }


            return inserted;


        }


    }
}
