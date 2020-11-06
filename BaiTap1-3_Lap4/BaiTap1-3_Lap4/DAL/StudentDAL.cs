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
    class StudentDAL
    {
       
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public StudentDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllSinhvien()
        {
            string sql = "SELECT * FROM Student";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertSinhVien(Student sv)
        {
            string sql = "INSERT INTO Student(StudentID,FullName,AverageScore,FacultyID) VALUES(@StudentID,@FullName,@AverageScore,@FacultyID)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = sv.StudentID;
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar).Value = sv.FullName;
                cmd.Parameters.Add("@AverageScore", SqlDbType.Float).Value = sv.AverageScore;
                cmd.Parameters.Add("@FacultyID", SqlDbType.VarChar).Value = sv.FacultyID;

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
        public bool UpdateSinVien(Student sv)
        {
            string sql = "UPDATE Student SET FullName=@FullName,AverageScore=@AverageScore,FacultyID=@FacultyID WHERE StudentID=@StudentID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = sv.StudentID;
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar).Value = sv.FullName;
                cmd.Parameters.Add("@AverageScore", SqlDbType.Float).Value = sv.AverageScore;
                cmd.Parameters.Add("@FacultyID", SqlDbType.VarChar).Value = sv.FacultyID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteSinVien(Student sv)
        {
            string sql = "DELETE Student WHERE StudentID=@StudentID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = sv.StudentID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
