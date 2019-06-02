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
    public partial class GroupForm : Form
    {
        private Button btn_grpfrm_update;
        private Button btn_grpfrm_save;
        private Button btn_grpfrm_delete;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox frm_txtbox_edcprg;
        private TextBox frm_txtbox_Capacity;
        private TextBox frm_txtbox_Teacher;
        private TextBox frm_txtbox_Name;
        private Label label1;
        private Button grp_btn_search;
        private TextBox grp_txtbx_search;
        private ComboBox grp_cb_clsrm;
        private ComboBox comboBox_mentor;
        private DataGridView frm_grp_datagrid;

        public GroupForm()
        {
            InitializeComponent(); FillComboBox();
        }
        int selectedClassRoomId;
        int selectedMentorId;

        private void FillComboBox()
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                var dataClassRoom = aem.ClassRooms.Select(g => new { g.Id, g.Name }).ToList();
                var dataMentor = aem.Employees.Where(x=>x.Position1.Name=="Mentor")
                            .Select(g => new { g.Id, g.Name }).ToList();



                //add classroom info
                grp_cb_clsrm.DisplayMember = "Name";
                grp_cb_clsrm.ValueMember = "Id";

                grp_cb_clsrm.DataSource = dataClassRoom;


                //add mentor info
                comboBox_mentor.DisplayMember = "Name";
                comboBox_mentor.ValueMember = "Id";

                comboBox_mentor.DataSource = dataMentor;
            }

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this.btn_grpfrm_update = new System.Windows.Forms.Button();
            this.btn_grpfrm_save = new System.Windows.Forms.Button();
            this.btn_grpfrm_delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frm_txtbox_edcprg = new System.Windows.Forms.TextBox();
            this.frm_txtbox_Capacity = new System.Windows.Forms.TextBox();
            this.frm_txtbox_Teacher = new System.Windows.Forms.TextBox();
            this.frm_txtbox_Name = new System.Windows.Forms.TextBox();
            this.frm_grp_datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_btn_search = new System.Windows.Forms.Button();
            this.grp_txtbx_search = new System.Windows.Forms.TextBox();
            this.grp_cb_clsrm = new System.Windows.Forms.ComboBox();
            this.comboBox_mentor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.frm_grp_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_grpfrm_update
            // 
            this.btn_grpfrm_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_grpfrm_update.FlatAppearance.BorderSize = 0;
            this.btn_grpfrm_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_grpfrm_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grpfrm_update.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grpfrm_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_grpfrm_update.Location = new System.Drawing.Point(17, 378);
            this.btn_grpfrm_update.Name = "btn_grpfrm_update";
            this.btn_grpfrm_update.Size = new System.Drawing.Size(285, 33);
            this.btn_grpfrm_update.TabIndex = 52;
            this.btn_grpfrm_update.Text = "Update";
            this.btn_grpfrm_update.UseVisualStyleBackColor = false;
            // 
            // btn_grpfrm_save
            // 
            this.btn_grpfrm_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_grpfrm_save.FlatAppearance.BorderSize = 0;
            this.btn_grpfrm_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_grpfrm_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grpfrm_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grpfrm_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_grpfrm_save.Location = new System.Drawing.Point(17, 283);
            this.btn_grpfrm_save.Name = "btn_grpfrm_save";
            this.btn_grpfrm_save.Size = new System.Drawing.Size(285, 33);
            this.btn_grpfrm_save.TabIndex = 51;
            this.btn_grpfrm_save.Text = "Save";
            this.btn_grpfrm_save.UseVisualStyleBackColor = false;
            this.btn_grpfrm_save.Click += new System.EventHandler(this.Btn_grpfrm_save_Click);
            // 
            // btn_grpfrm_delete
            // 
            this.btn_grpfrm_delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_grpfrm_delete.FlatAppearance.BorderSize = 0;
            this.btn_grpfrm_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_grpfrm_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grpfrm_delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grpfrm_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_grpfrm_delete.Location = new System.Drawing.Point(17, 331);
            this.btn_grpfrm_delete.Name = "btn_grpfrm_delete";
            this.btn_grpfrm_delete.Size = new System.Drawing.Size(285, 33);
            this.btn_grpfrm_delete.TabIndex = 49;
            this.btn_grpfrm_delete.Text = "Delete";
            this.btn_grpfrm_delete.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 47;
            this.label9.Text = "Include Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-4, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "by_hasanzada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(13, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "EducationProgram";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(13, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Teacher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "ClassRoom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name";
            // 
            // frm_txtbox_edcprg
            // 
            this.frm_txtbox_edcprg.Location = new System.Drawing.Point(154, 243);
            this.frm_txtbox_edcprg.Name = "frm_txtbox_edcprg";
            this.frm_txtbox_edcprg.Size = new System.Drawing.Size(148, 20);
            this.frm_txtbox_edcprg.TabIndex = 38;
            // 
            // frm_txtbox_Capacity
            // 
            this.frm_txtbox_Capacity.Location = new System.Drawing.Point(154, 205);
            this.frm_txtbox_Capacity.Name = "frm_txtbox_Capacity";
            this.frm_txtbox_Capacity.Size = new System.Drawing.Size(148, 20);
            this.frm_txtbox_Capacity.TabIndex = 37;
            // 
            // frm_txtbox_Teacher
            // 
            this.frm_txtbox_Teacher.Location = new System.Drawing.Point(154, 128);
            this.frm_txtbox_Teacher.Name = "frm_txtbox_Teacher";
            this.frm_txtbox_Teacher.Size = new System.Drawing.Size(148, 20);
            this.frm_txtbox_Teacher.TabIndex = 36;
            // 
            // frm_txtbox_Name
            // 
            this.frm_txtbox_Name.Location = new System.Drawing.Point(154, 52);
            this.frm_txtbox_Name.Name = "frm_txtbox_Name";
            this.frm_txtbox_Name.Size = new System.Drawing.Size(148, 20);
            this.frm_txtbox_Name.TabIndex = 34;
            // 
            // frm_grp_datagrid
            // 
            this.frm_grp_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frm_grp_datagrid.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.frm_grp_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frm_grp_datagrid.Location = new System.Drawing.Point(379, 52);
            this.frm_grp_datagrid.Name = "frm_grp_datagrid";
            this.frm_grp_datagrid.Size = new System.Drawing.Size(310, 391);
            this.frm_grp_datagrid.TabIndex = 31;
            this.frm_grp_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Frm_grp_datagrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(14, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mentor";
            // 
            // grp_btn_search
            // 
            this.grp_btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grp_btn_search.BackgroundImage")));
            this.grp_btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grp_btn_search.FlatAppearance.BorderSize = 0;
            this.grp_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_btn_search.Location = new System.Drawing.Point(631, 2);
            this.grp_btn_search.Name = "grp_btn_search";
            this.grp_btn_search.Size = new System.Drawing.Size(56, 44);
            this.grp_btn_search.TabIndex = 56;
            this.grp_btn_search.UseVisualStyleBackColor = true;
            // 
            // grp_txtbx_search
            // 
            this.grp_txtbx_search.Location = new System.Drawing.Point(379, 15);
            this.grp_txtbx_search.Multiline = true;
            this.grp_txtbx_search.Name = "grp_txtbx_search";
            this.grp_txtbx_search.Size = new System.Drawing.Size(246, 20);
            this.grp_txtbx_search.TabIndex = 55;
            // 
            // grp_cb_clsrm
            // 
            this.grp_cb_clsrm.FormattingEnabled = true;
            this.grp_cb_clsrm.Location = new System.Drawing.Point(154, 87);
            this.grp_cb_clsrm.Name = "grp_cb_clsrm";
            this.grp_cb_clsrm.Size = new System.Drawing.Size(148, 21);
            this.grp_cb_clsrm.TabIndex = 57;
            this.grp_cb_clsrm.SelectedIndexChanged += new System.EventHandler(this.Grp_cb_clsrm_SelectedIndexChanged);
            // 
            // comboBox_mentor
            // 
            this.comboBox_mentor.FormattingEnabled = true;
            this.comboBox_mentor.Location = new System.Drawing.Point(154, 165);
            this.comboBox_mentor.Name = "comboBox_mentor";
            this.comboBox_mentor.Size = new System.Drawing.Size(148, 21);
            this.comboBox_mentor.TabIndex = 58;
            this.comboBox_mentor.SelectedIndexChanged += new System.EventHandler(this.ComboBox_mentor_SelectedIndexChanged);
            // 
            // GroupForm
            // 
            this.ClientSize = new System.Drawing.Size(692, 443);
            this.Controls.Add(this.comboBox_mentor);
            this.Controls.Add(this.grp_cb_clsrm);
            this.Controls.Add(this.grp_btn_search);
            this.Controls.Add(this.grp_txtbx_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_grpfrm_update);
            this.Controls.Add(this.btn_grpfrm_save);
            this.Controls.Add(this.btn_grpfrm_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frm_txtbox_edcprg);
            this.Controls.Add(this.frm_txtbox_Capacity);
            this.Controls.Add(this.frm_txtbox_Teacher);
            this.Controls.Add(this.frm_txtbox_Name);
            this.Controls.Add(this.frm_grp_datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GroupForm";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm_grp_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btn_grpfrm_save_Click(object sender, EventArgs e)
        {
            Model.Group grp = new Model.Group();

            
            Regex rgxName = new Regex("[A-z]");
            //Regex rgxClassroom = new Regex("[A-z]");
            Regex rgxTeacher = new Regex("[A-z]");
            Regex rgxMentor = new Regex("[A-z]");
            //Regex rgxCapacity = new Regex(@"\[0\-9\]\{0,15\}");

           
            if (!rgxName.IsMatch(frm_txtbox_Name.Text))
            {
                MessageBox.Show("Enter Name");
            }
            //else if (!rgxClassroom.IsMatch(frm_txtbox_ClassRoom.Text))
            //{
            //    MessageBox.Show("Enter ClassRoom");
            //}
            else if (!rgxTeacher.IsMatch(frm_txtbox_Teacher.Text))
            {
                MessageBox.Show("Fill in the form");
            }
          
            //else if (!rgxCapacity.IsMatch(frm_txtbox_Capacity.Text))
            //{
            //    MessageBox.Show("Enter Capactiy");
            //}
            else
            {
                using (AcademyEntities aem = new AcademyEntities())
                {
                    AcademyMngtSystem.Model.ClassRoom classrm = aem.ClassRooms.FirstOrDefault(c => c.Id == selectedClassRoomId);


                    //if (classrm != null)
                    //{
                    //    grp.ClassRoom.Add(classrm);
                    //}
                    grp.ClassRoom1 = classrm;
                    //grp.Classroom = frm_txtbox_ClassRoom.Text;
                    grp.Teacher = frm_txtbox_Teacher.Text;
                    grp.Mentor = selectedMentorId;

                    //grp.Teacher = new i

                    grp.ClassRoom1 = classrm;
                    grp.Name = frm_txtbox_Name.Text;                
                    grp.Capacity = Convert.ToInt32(frm_txtbox_Capacity.Text);
                    aem.Groups.Add(grp);
                    frm_grp_datagrid.DataSource = aem.Groups.ToList();
                    //grp.Employee
                    aem.SaveChanges();
                }

            }
           



        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            using(AcademyEntities aem = new AcademyEntities())
            {
                frm_grp_datagrid.DataSource = aem.Groups.ToList();
            }
        }

        private void Frm_grp_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grp_cb_clsrm_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClassRoomId = (int)grp_cb_clsrm.SelectedValue;
        }

        private void ComboBox_mentor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMentorId = (int)comboBox_mentor.SelectedValue;
        }
    }
}
