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
    class FacultyBLL
    {
        FalcultyDAL falcultyDAL;
        public FacultyBLL()
        {
            falcultyDAL = new FalcultyDAL();
        }
        public DataTable getAllFaculty()
        {
            return falcultyDAL.getAllFaculty();
        }
        public DataTable getFacultyID(string facultyName)
        {
            return falcultyDAL.getFacultyID(facultyName);
        }
        public bool insertFaculty(Falculty fal)
        {
            return falcultyDAL.insertFaculty(fal);
        }
        public bool updateFaculty(Falculty fal)
        {
            return falcultyDAL.updateFaculty(fal);
        }
        public bool deleteFaculty(Falculty fal)
        {
            return falcultyDAL.deleteFaculty(fal);
        }
    }
}
