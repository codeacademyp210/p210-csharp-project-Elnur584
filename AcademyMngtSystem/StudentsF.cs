using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AcademyMngtSystem.Model;

namespace AcademyMngtSystem
{
    
    public partial class StudentsF : Form

    {
        int selectedGroupId;
        public StudentsF()
        {
            InitializeComponent();FillComboBox();
        }
        private void FillComboBox()
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                var dataGroups = aem.Groups.Where(x => x.Education.Name == "Group")
                             .Select(g => new { g.Id, g.Name }).ToList();

                stdnt_cmbx_groups.DisplayMember = "Name";
                stdnt_cmbx_groups.ValueMember = "Id";

                stdnt_cmbx_groups.DataSource = dataGroups;
            }
        }
        private void Btn_stndt_save_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            Regex rgxName = new Regex("[A-z]");
            Regex rgxSurname = new Regex("[A-z]");
            Regex rgxEmail = new Regex(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$");
            Regex rgxPhone = new Regex(@"\(\\\+\[0\-9\]\{3\}\)\(\[0\-9\]\{9\}\)");
            Regex rgxGroups = new Regex("[A-z]");
            Regex rgxTask = new Regex("[A-z]");
            if (!rgxName.IsMatch(stdntfrm_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else if (!rgxSurname.IsMatch(stdntfrm_surname.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else if (!rgxEmail.IsMatch(stdntfrm_email.Text))
            {
                MessageBox.Show("Email is not true !");
            }
            else if (!rgxPhone.IsMatch(stdntfrm_phn.Text))
            {
                MessageBox.Show("Format Is Not True !");
            }
            else
            {
                using (AcademyEntities aem = new AcademyEntities())
                {
                 AcademyMngtSystem.Model.Student stdnt = aem.Students.FirstOrDefault(x => x.Id == selectedGroupId);
                   
                    
                    st.Name = stdntfrm_name.Text;
                    st.Surname = stdntfrm_surname.Text;
                    st.Email = stdntfrm_email.Text;
                    st.Phone = stdntfrm_phn.Text;
                    st.Groups = selectedGroupId;
                    //st.Groups = stdntfrm_grp.Text;
                    //st.Tasks = stdntfrm_task.Text;
                    aem.Students.Add(st);
                    student_datagridview.DataSource = aem.Students.ToList();
                    aem.SaveChanges();

                }
            }
           
        }

        private void StudentsF_Load(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                student_datagridview.DataSource = aem.Students.ToList();
            }
        }

        private void Stdnt_cmbx_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGroupId = (int)stdnt_cmbx_groups.SelectedValue;
        }
    }
}
