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
    public partial class EducationFrm : Form
    {
        private Button btn_edctn_search;
        private TextBox edctn_txtbx_search;
        private ComboBox edctn_cmbbx_teacher;
        private ComboBox edctn_cmbbx_group;
        private Button btn_edctn_update;
        private Button btn_edctn_save;
        private Button btn_edctn_delete;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label2;
        private TextBox frm_edctn_price;
        private TextBox frm_edctn_name;
        private DataGridView edctn_datagridview;

        public EducationFrm()
        {
            InitializeComponent();FillComboBox();
        }
        int selectedId;
        private void FillComboBox()
        {
            using (AcademyEntities aem = new AcademyEntities())
            {
                var data = aem.Positions.Select(g => new { g.Id, g.Name }).ToList();
                var data2 = aem.Teachers.Select(c => new { c.Id, c.Name }).ToList();
                edctn_cmbbx_teacher.DisplayMember = "Name";
                edctn_cmbbx_teacher.ValueMember = "Id";
               
                edctn_cmbbx_group.DisplayMember = "Name";
                edctn_cmbbx_group.ValueMember = "Id";

                edctn_cmbbx_group.DataSource = data;
                edctn_cmbbx_teacher.DataSource = data2;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationFrm));
            this.btn_edctn_search = new System.Windows.Forms.Button();
            this.edctn_txtbx_search = new System.Windows.Forms.TextBox();
            this.edctn_cmbbx_teacher = new System.Windows.Forms.ComboBox();
            this.edctn_cmbbx_group = new System.Windows.Forms.ComboBox();
            this.btn_edctn_update = new System.Windows.Forms.Button();
            this.btn_edctn_save = new System.Windows.Forms.Button();
            this.btn_edctn_delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frm_edctn_price = new System.Windows.Forms.TextBox();
            this.frm_edctn_name = new System.Windows.Forms.TextBox();
            this.edctn_datagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.edctn_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edctn_search
            // 
            this.btn_edctn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edctn_search.BackgroundImage")));
            this.btn_edctn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_edctn_search.FlatAppearance.BorderSize = 0;
            this.btn_edctn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edctn_search.Location = new System.Drawing.Point(604, 2);
            this.btn_edctn_search.Name = "btn_edctn_search";
            this.btn_edctn_search.Size = new System.Drawing.Size(56, 44);
            this.btn_edctn_search.TabIndex = 72;
            this.btn_edctn_search.UseVisualStyleBackColor = true;
            // 
            // edctn_txtbx_search
            // 
            this.edctn_txtbx_search.Location = new System.Drawing.Point(352, 15);
            this.edctn_txtbx_search.Multiline = true;
            this.edctn_txtbx_search.Name = "edctn_txtbx_search";
            this.edctn_txtbx_search.Size = new System.Drawing.Size(246, 20);
            this.edctn_txtbx_search.TabIndex = 71;
            // 
            // edctn_cmbbx_teacher
            // 
            this.edctn_cmbbx_teacher.FormattingEnabled = true;
            this.edctn_cmbbx_teacher.Location = new System.Drawing.Point(94, 161);
            this.edctn_cmbbx_teacher.Name = "edctn_cmbbx_teacher";
            this.edctn_cmbbx_teacher.Size = new System.Drawing.Size(148, 21);
            this.edctn_cmbbx_teacher.TabIndex = 70;
            // 
            // edctn_cmbbx_group
            // 
            this.edctn_cmbbx_group.FormattingEnabled = true;
            this.edctn_cmbbx_group.Location = new System.Drawing.Point(94, 123);
            this.edctn_cmbbx_group.Name = "edctn_cmbbx_group";
            this.edctn_cmbbx_group.Size = new System.Drawing.Size(148, 21);
            this.edctn_cmbbx_group.TabIndex = 69;
            this.edctn_cmbbx_group.SelectedIndexChanged += new System.EventHandler(this.Edctn_cmbbx_group_SelectedIndexChanged);
            // 
            // btn_edctn_update
            // 
            this.btn_edctn_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_edctn_update.FlatAppearance.BorderSize = 0;
            this.btn_edctn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_edctn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edctn_update.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edctn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edctn_update.Location = new System.Drawing.Point(15, 303);
            this.btn_edctn_update.Name = "btn_edctn_update";
            this.btn_edctn_update.Size = new System.Drawing.Size(275, 33);
            this.btn_edctn_update.TabIndex = 68;
            this.btn_edctn_update.Text = "Update";
            this.btn_edctn_update.UseVisualStyleBackColor = false;
            // 
            // btn_edctn_save
            // 
            this.btn_edctn_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_edctn_save.FlatAppearance.BorderSize = 0;
            this.btn_edctn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_edctn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edctn_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edctn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edctn_save.Location = new System.Drawing.Point(15, 206);
            this.btn_edctn_save.Name = "btn_edctn_save";
            this.btn_edctn_save.Size = new System.Drawing.Size(275, 33);
            this.btn_edctn_save.TabIndex = 67;
            this.btn_edctn_save.Text = "Save";
            this.btn_edctn_save.UseVisualStyleBackColor = false;
            // 
            // btn_edctn_delete
            // 
            this.btn_edctn_delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_edctn_delete.FlatAppearance.BorderSize = 0;
            this.btn_edctn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_edctn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edctn_delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edctn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edctn_delete.Location = new System.Drawing.Point(15, 254);
            this.btn_edctn_delete.Name = "btn_edctn_delete";
            this.btn_edctn_delete.Size = new System.Drawing.Size(275, 33);
            this.btn_edctn_delete.TabIndex = 66;
            this.btn_edctn_delete.Text = "Delete";
            this.btn_edctn_delete.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 65;
            this.label9.Text = "Include Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "by_hasanzada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Teachers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(11, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Groups";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(11, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Name";
            // 
            // frm_edctn_price
            // 
            this.frm_edctn_price.Location = new System.Drawing.Point(94, 87);
            this.frm_edctn_price.Name = "frm_edctn_price";
            this.frm_edctn_price.Size = new System.Drawing.Size(148, 20);
            this.frm_edctn_price.TabIndex = 59;
            // 
            // frm_edctn_name
            // 
            this.frm_edctn_name.Location = new System.Drawing.Point(94, 51);
            this.frm_edctn_name.Name = "frm_edctn_name";
            this.frm_edctn_name.Size = new System.Drawing.Size(148, 20);
            this.frm_edctn_name.TabIndex = 58;
            // 
            // edctn_datagridview
            // 
            this.edctn_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edctn_datagridview.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.edctn_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edctn_datagridview.Location = new System.Drawing.Point(352, 51);
            this.edctn_datagridview.Name = "edctn_datagridview";
            this.edctn_datagridview.Size = new System.Drawing.Size(318, 330);
            this.edctn_datagridview.TabIndex = 57;
            // 
            // EducationFrm
            // 
            this.ClientSize = new System.Drawing.Size(672, 383);
            this.Controls.Add(this.btn_edctn_search);
            this.Controls.Add(this.edctn_txtbx_search);
            this.Controls.Add(this.edctn_cmbbx_teacher);
            this.Controls.Add(this.edctn_cmbbx_group);
            this.Controls.Add(this.btn_edctn_update);
            this.Controls.Add(this.btn_edctn_save);
            this.Controls.Add(this.btn_edctn_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frm_edctn_price);
            this.Controls.Add(this.frm_edctn_name);
            this.Controls.Add(this.edctn_datagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EducationFrm";
            this.Text = "Education";
            this.Load += new System.EventHandler(this.Educationfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edctn_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void Btn_edctn_save_Click(object sender, EventArgs e)
        {
            Education edctn = new Education();
            Regex rgxName = new Regex("[A-z]");
            Regex rgxPrice = new Regex(@"\[0\-9\]\{0,15\}");
            if (!rgxName.IsMatch(frm_edctn_name.Text))
            {
                MessageBox.Show("Fill in the form");
            }
            else if (!rgxPrice.IsMatch(frm_edctn_price.Text))
            {
                MessageBox.Show("Not enter Letters");
            }
            else
            {
                using(AcademyEntities aem = new AcademyEntities())
                {
                AcademyMngtSystem.Model.Group grp = aem.Groups.FirstOrDefault(x => x.Id == selectedId);
                    AcademyMngtSystem.Model.Teacher tchr = aem.Teachers.FirstOrDefault(t => t.Id == selectedId);
                    if (grp != null)
                    {
                        edctn.Groups.Add(grp);
                    }
                    if(tchr != null)
                    {
                        edctn.Teachers.Add(tchr);
                    }
                    edctn.Name = frm_edctn_name.Text;
                    edctn.Price = Convert.ToInt32(frm_edctn_price.Text);
                    aem.Educations.Add(edctn);
                    edctn_datagridview.DataSource = aem.Educations.ToList();
                    aem.SaveChanges();
                }
            }
        }

        

        private void Educationfrm_Load(object sender, EventArgs e)
        {
           using(AcademyEntities aem = new AcademyEntities())
            {
                edctn_datagridview.DataSource = aem.Educations.ToList();
            }
        }

        private void Edctn_cmbbx_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = (int)edctn_cmbbx_group.SelectedValue;

        }
    }
}
