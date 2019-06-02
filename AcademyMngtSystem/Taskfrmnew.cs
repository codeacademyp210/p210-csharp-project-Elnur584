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
    public partial class Taskfrmnew : Form
    {
        public Taskfrmnew()
        {
            InitializeComponent();
        }

        private void Taskfrmnew_Load(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                frm_task_datagridview.DataSource = aem.Tasks.ToList();
            }
        }

        private void Btn_task_save_Click(object sender, EventArgs e)
        {
            AcademyMngtSystem.Model.Task tsk = new AcademyMngtSystem.Model.Task();
           
            Regex rgxName = new Regex("[A-z]");
            Regex rgxDeadline = new Regex(@"\[0\-9\]\{2\}\.\[0\-9\]\{2\}\.\[0\-9\]\{4\}");
            Regex rgxGroup = new Regex("[A-z]");
            
            if (!rgxName.IsMatch(task_txbx_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else if (!rgxGroup.IsMatch(task_txbx_grp.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            using(AcademyEntities aem = new AcademyEntities())
            {
                
                tsk.Name = task_txbx_name.Text;
                tsk.Deadline =Convert.ToDateTime(task_txbx_deadline.Text);
                //tsk.Groups = task_txbx_grp.Text;
                aem.Tasks.Add(tsk);
                aem.SaveChanges();
                frm_task_datagridview.DataSource = aem.Tasks.ToList();
            }



        }

       
    }
}
