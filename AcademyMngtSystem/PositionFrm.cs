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
    public partial class PositionFrm : Form
    {
        int selectedId;
        public PositionFrm()
        {
            InitializeComponent();FillCombobox();
        }
        private void FillCombobox()
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                var data = aem.Employees.Select(g => new { g.Id, g.Name }).ToList();
                pstn_cmbx_emplye.DisplayMember = "Name";
                pstn_cmbx_emplye.ValueMember = "Id";
                pstn_cmbx_emplye.DataSource = data;
            }
        }
        private void Btn_positionfrm_save_Click(object sender, EventArgs e)
        {
            Position pstn = new Position();
            Regex rgxName = new Regex("[A-z]");
            //Regex rgxEmployee = new Regex("[A-z]"); 
            if (!rgxName.IsMatch(pstntxtbxemplote_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            //else if (!rgxEmployee.IsMatch(pstntxtbxemplote.Text))
            //{
            //    MessageBox.Show("Not enter Letters");
            //}
            else
            {
                using (AcademyEntities aem = new AcademyEntities())
                {
                    Employee employe = aem.Employees.FirstOrDefault(g => g.Id == selectedId);
                    //pstn.Employees = employe;
                    if (employe != null)
                    {
                       pstn.Employees.Add(employe);
                    }
                    pstn.Name = pstntxtbxemplote_name.Text;
                    //pstn.PositionId =Convert.ToInt32(pstntxtbxemploteId.Text);
                    aem.Positions.Add(pstn);
                    position_datagridview.DataSource = aem.Positions.ToList();
                    aem.SaveChanges();
                }
            }
        }

        private void PositionFrm_Load(object sender, EventArgs e)
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                position_datagridview.DataSource = aem.Positions.ToList();
            }
        }

        private void Btn_positionfrm_delete_Click(object sender, EventArgs e)
        {

        }

        private void Pstn_cmbx_emplye_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = (int)pstn_cmbx_emplye.SelectedValue;
        }
    }
    }
