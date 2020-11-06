using BaiTap1_3_Lap4.DAL;
using BaiTap1_3_Lap4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_3_Lap4.BLL
{
    class StudentBLL
    {
        StudentDAL studentDal;
        public StudentBLL()
        {
            studentDal = new StudentDAL();
        }
        public DataTable getALLStudent()
        {
            return studentDal.getAllSinhvien();
        }
        public bool insertStudent(Student st)
        {
            return studentDal.InsertSinhVien(st);
        }
        public bool updateStudent(Student st)
        {
            return studentDal.UpdateSinVien(st);
        }
        public bool deleteStudent(Student st)
        {
            return studentDal.DeleteSinVien(st);
        }
    }
}
