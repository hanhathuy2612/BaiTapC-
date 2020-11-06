using BaiTap1_3_Lap4.BLL;
using BaiTap1_3_Lap4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1_3_Lap4
{
    public partial class frmFalculty : Form
    {
        FacultyBLL facultyBLL;
        public frmFalculty()
        {
            InitializeComponent();
            facultyBLL = new FacultyBLL();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showAllFaculty()
        {
            DataTable data = facultyBLL.getAllFaculty();
            dataGridView1.DataSource = data;
        }
        private void frmFalculty_Load(object sender, EventArgs e)
        {
            showAllFaculty();
        }
        public bool FacultyIDIsEmpty(int facultyID)
        {
            DataTable data = facultyBLL.getAllFaculty();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["FacultyID"].ToString().Equals(facultyID.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnAddUpdateFal_Click(object sender, EventArgs e)
        {
            Falculty fal = new Falculty();
            fal.FacultyID = int.Parse(txtFacultyID.Text);
            fal.FacultyName = txtFacultyName.Text;
            if (FacultyIDIsEmpty(fal.FacultyID))
            {
                if (facultyBLL.insertFaculty(fal))
                {
                    showAllFaculty();
                    MessageBox.Show("Đã thêm");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, vui lòng thử lại sau");
                }
            }
            else
            {

                if (facultyBLL.updateFaculty(fal))
                {
                    showAllFaculty();
                    MessageBox.Show("Đã update");
                }
                else
                {
                    MessageBox.Show("Update thất bại, vui lòng thử lại sau");
                }
            }
        }

        private void btnDeleteFal_Click(object sender, EventArgs e)
        {
            Falculty fal = new Falculty();
            fal.FacultyID = int.Parse(txtFacultyID.Text);
            if (facultyBLL.deleteFaculty(fal))
            {
                showAllFaculty();
                MessageBox.Show("Đã xóa");
            }
            else
            {
                MessageBox.Show("Xóa không thành công, vui lòng thử lại sau");
            }
        }
    }
}
