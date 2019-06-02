using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademyMngtSystem.Model;

namespace AcademyMngtSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void TeachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddInformationfrm aff = new AddInformationfrm();
            aff.ShowDialog();

        }
        private void stdnt_mainbtn_Click(object sender, EventArgs e)
        {
            StudentsF stnd = new StudentsF();
            stnd.ShowDialog();
        }

        private void TeachersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddInformationfrm aff = new AddInformationfrm();
            aff.ShowDialog();
        }

        private void ClassRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassRoom clsForm = new ClassRoom();
            clsForm.ShowDialog();
        }

        

        private void Btn_main_Student_Click(object sender, EventArgs e)
        {
            StudentsF sdtnfrm = new StudentsF();
            sdtnfrm.ShowDialog();
        }

        private void AcademyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcademyInfoFrm aif = new AcademyInfoFrm();
            aif.ShowDialog();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            AcademyInfoFrm aif = new AcademyInfoFrm();
            aif.ShowDialog();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsF sdtnfrm = new StudentsF();
            sdtnfrm.ShowDialog();
        }

       

        private void Btn_man_Employee_Click(object sender, EventArgs e)
        {
            EmployeeFrm employefrmpath = new EmployeeFrm();
            employefrmpath.ShowDialog();
        }

        private void Btn_main_Task_Click(object sender, EventArgs e)
        {
            Taskfrmnew tsknw = new Taskfrmnew();
            tsknw.ShowDialog();
        }

        private void TasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taskfrmnew tsknw = new Taskfrmnew();
            tsknw.ShowDialog();
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupForm grpfrm = new GroupForm();
            grpfrm.ShowDialog();
        }

        private void TeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EmployeeFrm employefrmpath = new EmployeeFrm();
            employefrmpath.ShowDialog();
        }

        private void GroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupFrm grpfrm = new GroupFrm();
            grpfrm.ShowDialog();
        }

        private void ClassRoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassRoom clsForm = new ClassRoom();
            clsForm.ShowDialog();
        }

       

        private void PositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                PositionFrm pstnfrm = new PositionFrm();
                pstnfrm.ShowDialog();
            }
        }

        private void Btn_main_education_Click(object sender, EventArgs e)
        {
            EducationFrm edctfrm = new EducationFrm();
            edctfrm.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void AcademyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationFrm edcfrm = new EducationFrm();
            edcfrm.Show();
        }
    }
}
