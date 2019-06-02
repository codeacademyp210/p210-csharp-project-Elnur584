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
using System.Text.RegularExpressions;

namespace AcademyMngtSystem
{
    public partial class ClassRoom : Form
    {
        int selectedId;
        public ClassRoom()
        {
            InitializeComponent();FillComboBox();
        }
        private void FillComboBox()
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                var data = aem.Groups.Select(g => new { g.Id, g.Name }).ToList();

                clsrm_cmbbx_group.DisplayMember = "Name";
                clsrm_cmbbx_group.ValueMember = "Id";

                clsrm_cmbbx_group.DataSource = data;
            }

        }

        private void Btn_teacher_show_Click(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                clsrmdatagrid.DataSource = aem.ClassRooms.ToList();
            }
        }

        private void Btn_teacher_save_Click(object sender, EventArgs e)
        {
            AcademyMngtSystem.Model.ClassRoom clsrm = new AcademyMngtSystem.Model.ClassRoom();
          
            
            Regex rgxName = new Regex("[A-z]");
            Regex rgxCapacity = new Regex("[0-9A-z]");
            if (!rgxCapacity.IsMatch(clsrm_grp_capacity.Text))
            {
                MessageBox.Show("Not enter Letters");
            }
            if (!rgxName.IsMatch(clsrm_stdnt_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else
            {
                
                using (AcademyEntities aem = new AcademyEntities())
                {

                    AcademyMngtSystem.Model.Group group = aem.Groups.FirstOrDefault(c => c.Id == selectedId);
                    if (group != null)
                    {
                        clsrm.Groups.Add(group);
                    }
                    clsrm.Name = clsrm_stdnt_name.Text;
                    clsrm.Capacity = clsrm_grp_capacity.Text;                   
                    aem.ClassRooms.Add(clsrm);
                    aem.SaveChanges();
                    clsrmdatagrid.DataSource = aem.ClassRooms.ToList();
                }
            }
            
        }

        private void ClassRoom_Load(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                clsrmdatagrid.DataSource = aem.ClassRooms.ToList();
            }
        }

        private void Clsrm_cmbbx_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = (int)clsrm_cmbbx_group.SelectedValue;
        }
    }
}
