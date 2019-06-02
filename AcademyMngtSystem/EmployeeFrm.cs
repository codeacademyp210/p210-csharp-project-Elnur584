using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AcademyMngtSystem.Model;

namespace AcademyMngtSystem
{
    public partial class EmployeeFrm : Form
    {
        
        int selectedId;

        public EmployeeFrm()
        {
            InitializeComponent(); FillComboBox();
        }
        private void FillComboBox()
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                var data = aem.Positions.Select(g => new { g.Id, g.Name }).ToList();

                frm_emply_cb_pstn.DisplayMember = "Name";
                frm_emply_cb_pstn.ValueMember = "Id";

                frm_emply_cb_pstn.DataSource = data;
            }
        }
        private void Btn_employee_show_Click(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                employe_datagridview.DataSource = aem.Employees.ToList();
            }
        }

        private void Btn_employee_save_Click(object sender, EventArgs e)
        {
            AcademyMngtSystem.Model.Employee emfrm = new AcademyMngtSystem.Model.Employee();
            Regex regexName = new Regex("[A-z]");
            Regex regexSurname = new Regex("[A-z]");
            //Regex regexPosition = new Regex("[A-z]");
            Regex regexEmail = new Regex(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$");
            
            Regex regexStartTime = new Regex(@"(\d{1,2})/(\d{1,2})/(\d{4})");
            //Regex regexsalary = new Regex(@" ^\d{9}$");
            //Regex regexPhone = new Regex("^\\+[1-9]{3}[1 - 9]{ 3}[0-9]{3}[0-9]{3}[0-9]{2}[0-9]{2}$");
            
            if (!regexName.IsMatch(frm_employee_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else if (!regexSurname.IsMatch(frm_employee_srnm.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            //else if (!regexPosition.IsMatch(frm_employee_pstn.Text))
            //{
            //    MessageBox.Show("Fill in the form");
            //}
            else if (!regexEmail.IsMatch(frm_employee_email.Text))
            {
                MessageBox.Show("Email is not true !");
            }
            //else if (!regexStartTime.IsMatch(frm_employee_sttime.Text))
            //{
            //    MessageBox.Show("DateTime Format Is Not True !");
            //}
            //else if (!regexsalary.IsMatch(frm_employee_slry.Text))
            //{
            //    MessageBox.Show("Not enter Letters");
            //}
            //else if (!regexPhone.IsMatch(frm_employee_phn.Text))
            //{
            //    MessageBox.Show("Not enter Letters");
            //}
            else
            {
                using (AcademyEntities aem = new AcademyEntities())
                {
                    Position position = aem.Positions.FirstOrDefault(x => x.Id == selectedId);
                   
                    emfrm.Name = frm_employee_name.Text;
                    emfrm.Surname = frm_employee_srnm.Text;
                    //emfrm.Position = frm_employee_pstn.Text;
                    emfrm.Email = frm_employee_email.Text;
                    emfrm.Phone = frm_employee_phn.Text;
                    //emfrm.StartTime = Convert.ToDateTime(frm_employee_sttime.Text);
                    emfrm.Position1 = position;
                    emfrm.Salary = Convert.ToInt32(frm_employee_slry.Text);
                    aem.Employees.Add(emfrm);
                    employe_datagridview.DataSource = aem.Employees.ToList();
                    aem.SaveChanges();
                }
            }
           

        }

        private void EmployeeFrm_Load(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                employe_datagridview.DataSource = aem.Employees.ToList();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           selectedId =  (int)frm_emply_cb_pstn.SelectedValue;

            
        }

    }
}
