using BaiTap1_3_Lap4.Connection;
using BaiTap1_3_Lap4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_3_Lap4.DAL
{
    class FalcultyDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public FalcultyDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllFaculty()
        {
            string sql = "SELECT * FROM Falculty";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getFacultyID(String facultyName)
        {
            string sql = "SELECT * FROM Falculty where FacultyName='" + facultyName+"'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertFaculty(Falculty fal)
        {
            string sql = "insert into Falculty values(@FacultyID,@FacultyName)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@FacultyID", SqlDbType.Int).Value = fal.FacultyID;
                cmd.Parameters.Add("@FacultyName", SqlDbType.NVarChar).Value = fal.FacultyName;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        public bool updateFaculty(Falculty fal)
        {
            string sql = "update Falculty set FacultyName=@FacultyName where FacultyID=@FacultyID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@FacultyID", SqlDbType.Int).Value = fal.FacultyID;
                cmd.Parameters.Add("@FacultyName", SqlDbType.NVarChar).Value = fal.FacultyName;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        public bool deleteFaculty(Falculty fal)
        {
            string sql = "detete Falculty where FacultyID=@FacultyID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@FacultyID", SqlDbType.Int).Value = fal.FacultyID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
