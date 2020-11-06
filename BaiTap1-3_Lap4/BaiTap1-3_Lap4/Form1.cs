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
    public partial class Form1 : Form
    {
        
        StudentBLL studentBLL;
        FacultyBLL facultyBLL;
        public Form1()
        {
            InitializeComponent();
            studentBLL = new StudentBLL();
            facultyBLL = new FacultyBLL();
        }
        public void showAllStudent()
        {
            DataTable studentData = studentBLL.getALLStudent();
            dataGridView1.DataSource = studentData;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*StudentContextDB conText = new StudentContextDB();
            List<Student> list = conText.Students.ToList();
            dataGridView1.DataSource =list;*/
            showAllStudent();
            DataTable facultyData = facultyBLL.getAllFaculty();
            cmbKhoa.DataSource = facultyData;
            cmbKhoa.ValueMember = "FacultyID";
            cmbKhoa.DisplayMember = "FacultyName";
            lbTest.Text = facultyBLL.getFacultyID(cmbKhoa.Text).Rows[0]["FacultyID"].ToString();
        }
        public bool StudentIDIsEmpty(int studentID)
        {
            DataTable data = studentBLL.getALLStudent();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if(data.Rows[i]["StudentID"].ToString().Equals(studentID.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        

        public bool checkKhoa(string khoa)
        {
            DataTable data = facultyBLL.getAllFaculty();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["FacultyName"].ToString().Equals(khoa))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAddUpate_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            
            st.StudentID = int.Parse(txtMaSV.Text);
            st.FullName = txtHoTen.Text;
            st.AverageScore =float.Parse(txtDiemTB.Text);
            
            
            if(!checkKhoa(cmbKhoa.Text))
            {
                DialogResult result = MessageBox.Show("Không tồn tại Khoa '" + cmbKhoa.Text + "'. \nBạn có muốn thêm vào danh sách Khoa hay không", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    frmFalculty frm = new frmFalculty();
                    frm.Visible = true;
                }
                
            }
            else
            {
                st.FacultyID = int.Parse(facultyBLL.getFacultyID(cmbKhoa.Text).Rows[0]["FacultyID"].ToString());
                if (StudentIDIsEmpty(st.StudentID))
                {
                    
                    if (studentBLL.insertStudent(st))
                    {
                        showAllStudent();
                        MessageBox.Show("Đã thêm");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công, vui lòng thử lại sau");
                    }
                }
                else
                {
                    if (studentBLL.updateStudent(st))
                    {
                        showAllStudent();
                        MessageBox.Show("Đã Update");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công, vui lòng thử lại sau");
                    }
                }
            }
                 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                txtMaSV.Text = dgvRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvRow.Cells[1].Value.ToString();
                txtDiemTB.Text = dgvRow.Cells[2].Value.ToString();
                cmbKhoa.SelectedValue = dgvRow.Cells[3].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.StudentID = int.Parse(txtMaSV.Text);
            if (studentBLL.deleteStudent(st))
            {
                showAllStudent();
            }
            else
            {
                MessageBox.Show("Xóa không thành công, vui lòng thử lại sau");
            }
        }
    }
}
