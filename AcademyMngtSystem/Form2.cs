using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademyMngtSystem.Model;

namespace AcademyMngtSystem
{
    public partial class AddInformationfrm : Form
    {
        int selectedId;
        public AddInformationfrm()
        {
            InitializeComponent();FillComboBox();
        }
        private void FillComboBox()
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                var data = aem.Educations.Select(g => new { g.Id, g.Name }).ToList();

                fmr_tchr_edctn_cb.DisplayMember = "Name";
                fmr_tchr_edctn_cb.ValueMember = "Id";
                fmr_tchr_edctn_cb.DataSource = data;

                //var dataspeciality = aem.Educations.Where(x => x.Teachers.Name == "Mentor")
                //           .Select(g => new { g.Id, g.Name }).ToList();


            }
        }
        private void Btn_teacher_show_Click(object sender, EventArgs e)
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                teacher_datagridview.DataSource = aem.Teachers.ToList();
            }
        }

        private void Btn_teacher_save_Click(object sender, EventArgs e)
        {
            AcademyMngtSystem.Model.Teacher tch = new AcademyMngtSystem.Model.Teacher();
            Regex regexName = new Regex("[A-z]");
            Regex regexSurname = new Regex("[A-z]");           
            //Regex regexSpeciality = new Regex("[A-z]");
            Regex regexEmail = new Regex(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$");            
            //Regex regexPhone = new Regex(@"(\+[0-9]{3})([0-9]{9})");


            if (!regexEmail.IsMatch(frm2txtbx_email.Text))
            {
                MessageBox.Show("Email is not true !");
            }
            else if (!regexName.IsMatch(frm2txtbx_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else if (!regexSurname.IsMatch(frm2txtbx_surname.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            //else if (!regexSpeciality.IsMatch(frm2cmbbx_spclty.Text))
            //{
            //    MessageBox.Show("Fill in the form");
            //}
          
            //else if (!regexPhone.IsMatch(frm2txtbx_phn.Text))
            //{
            //    MessageBox.Show("Please Enter Correct Phone Number !");
            //}
            else {
                using (AcademyEntities aem = new AcademyEntities())
                {
                    AcademyMngtSystem.Model.Education edctn = aem.Educations.FirstOrDefault(x => x.Id == selectedId);
                    
                    tch.Education = edctn;
                    tch.Name = frm2txtbx_name.Text;
                    tch.Surname = frm2txtbx_surname.Text;                   
                    tch.Email = frm2txtbx_email.Text;
                    tch.Phone = frm2txtbx_phn.Text;               
                    aem.Teachers.Add(tch);
                    teacher_datagridview.DataSource = aem.Teachers.ToList();
                    aem.SaveChanges();
                }
            }                      
        }

        private void Frm2txtbx_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                //AcademyMngtSystem.Model.ClassRoom clsrm = new AcademyMngtSystem.Model.ClassRoom();
                //AddInformationfrm afrm = new AddInformationfrm();
                //afrm.Name = tcht_combo.Text;
            }
        }

        private void Teacher_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_teacher_delete_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm2txtbx_clsrm_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm2txtbx_grp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm2txtbx_phn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm2txtbx_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm2txtbx_speciality_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm2txtbx_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm2txtbxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_teacher_update_Click(object sender, EventArgs e)
        {

        }

        private void AddInformationfrm_Load(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                teacher_datagridview.DataSource = aem.Teachers.ToList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Fmr_tchr_edctn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = (int)fmr_tchr_edctn_cb.SelectedValue;
        }
    }
}
