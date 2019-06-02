namespace AcademyMngtSystem
{
    partial class EmployeeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFrm));
            this.btn_employee_update = new System.Windows.Forms.Button();
            this.btn_employee_save = new System.Windows.Forms.Button();
            this.btn_employee_delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frm_employee_slry = new System.Windows.Forms.TextBox();
            this.frm_employee_sttime = new System.Windows.Forms.TextBox();
            this.frm_employee_phn = new System.Windows.Forms.TextBox();
            this.frm_employee_email = new System.Windows.Forms.TextBox();
            this.frm_employee_srnm = new System.Windows.Forms.TextBox();
            this.frm_employee_name = new System.Windows.Forms.TextBox();
            this.employe_datagridview = new System.Windows.Forms.DataGridView();
            this.employee_btn_search = new System.Windows.Forms.Button();
            this.emplye_txtbx_search = new System.Windows.Forms.TextBox();
            this.frm_emply_cb_pstn = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employe_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_employee_update
            // 
            this.btn_employee_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_employee_update.FlatAppearance.BorderSize = 0;
            this.btn_employee_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_employee_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee_update.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_employee_update.Location = new System.Drawing.Point(17, 391);
            this.btn_employee_update.Name = "btn_employee_update";
            this.btn_employee_update.Size = new System.Drawing.Size(275, 33);
            this.btn_employee_update.TabIndex = 29;
            this.btn_employee_update.Text = "Update";
            this.btn_employee_update.UseVisualStyleBackColor = false;
            // 
            // btn_employee_save
            // 
            this.btn_employee_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_employee_save.FlatAppearance.BorderSize = 0;
            this.btn_employee_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_employee_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_employee_save.Location = new System.Drawing.Point(17, 313);
            this.btn_employee_save.Name = "btn_employee_save";
            this.btn_employee_save.Size = new System.Drawing.Size(275, 33);
            this.btn_employee_save.TabIndex = 28;
            this.btn_employee_save.Text = "Save";
            this.btn_employee_save.UseVisualStyleBackColor = false;
            this.btn_employee_save.Click += new System.EventHandler(this.Btn_employee_save_Click);
            // 
            // btn_employee_delete
            // 
            this.btn_employee_delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_employee_delete.FlatAppearance.BorderSize = 0;
            this.btn_employee_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_employee_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee_delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_employee_delete.Location = new System.Drawing.Point(17, 352);
            this.btn_employee_delete.Name = "btn_employee_delete";
            this.btn_employee_delete.Size = new System.Drawing.Size(275, 33);
            this.btn_employee_delete.TabIndex = 26;
            this.btn_employee_delete.Text = "Delete";
            this.btn_employee_delete.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Include Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "by_hasanzada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(13, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(13, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "StartTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(13, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // frm_employee_slry
            // 
            this.frm_employee_slry.Location = new System.Drawing.Point(96, 268);
            this.frm_employee_slry.Name = "frm_employee_slry";
            this.frm_employee_slry.Size = new System.Drawing.Size(148, 20);
            this.frm_employee_slry.TabIndex = 13;
            // 
            // frm_employee_sttime
            // 
            this.frm_employee_sttime.Location = new System.Drawing.Point(96, 230);
            this.frm_employee_sttime.Name = "frm_employee_sttime";
            this.frm_employee_sttime.Size = new System.Drawing.Size(148, 20);
            this.frm_employee_sttime.TabIndex = 12;
            // 
            // frm_employee_phn
            // 
            this.frm_employee_phn.Location = new System.Drawing.Point(96, 193);
            this.frm_employee_phn.Name = "frm_employee_phn";
            this.frm_employee_phn.Size = new System.Drawing.Size(148, 20);
            this.frm_employee_phn.TabIndex = 11;
            // 
            // frm_employee_email
            // 
            this.frm_employee_email.Location = new System.Drawing.Point(96, 155);
            this.frm_employee_email.Name = "frm_employee_email";
            this.frm_employee_email.Size = new System.Drawing.Size(148, 20);
            this.frm_employee_email.TabIndex = 10;
            // 
            // frm_employee_srnm
            // 
            this.frm_employee_srnm.Location = new System.Drawing.Point(96, 81);
            this.frm_employee_srnm.Name = "frm_employee_srnm";
            this.frm_employee_srnm.Size = new System.Drawing.Size(148, 20);
            this.frm_employee_srnm.TabIndex = 8;
            // 
            // frm_employee_name
            // 
            this.frm_employee_name.Location = new System.Drawing.Point(96, 45);
            this.frm_employee_name.Name = "frm_employee_name";
            this.frm_employee_name.Size = new System.Drawing.Size(148, 20);
            this.frm_employee_name.TabIndex = 7;
            // 
            // employe_datagridview
            // 
            this.employe_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employe_datagridview.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.employe_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employe_datagridview.Location = new System.Drawing.Point(340, 45);
            this.employe_datagridview.Name = "employe_datagridview";
            this.employe_datagridview.Size = new System.Drawing.Size(311, 406);
            this.employe_datagridview.TabIndex = 6;
            // 
            // employee_btn_search
            // 
            this.employee_btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_btn_search.BackgroundImage")));
            this.employee_btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.employee_btn_search.FlatAppearance.BorderSize = 0;
            this.employee_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_btn_search.Location = new System.Drawing.Point(592, -1);
            this.employee_btn_search.Name = "employee_btn_search";
            this.employee_btn_search.Size = new System.Drawing.Size(56, 44);
            this.employee_btn_search.TabIndex = 32;
            this.employee_btn_search.UseVisualStyleBackColor = true;
            // 
            // emplye_txtbx_search
            // 
            this.emplye_txtbx_search.Location = new System.Drawing.Point(340, 12);
            this.emplye_txtbx_search.Multiline = true;
            this.emplye_txtbx_search.Name = "emplye_txtbx_search";
            this.emplye_txtbx_search.Size = new System.Drawing.Size(246, 20);
            this.emplye_txtbx_search.TabIndex = 31;
            // 
            // frm_emply_cb_pstn
            // 
            this.frm_emply_cb_pstn.FormattingEnabled = true;
            this.frm_emply_cb_pstn.Location = new System.Drawing.Point(96, 115);
            this.frm_emply_cb_pstn.Name = "frm_emply_cb_pstn";
            this.frm_emply_cb_pstn.Size = new System.Drawing.Size(148, 21);
            this.frm_emply_cb_pstn.TabIndex = 33;
            this.frm_emply_cb_pstn.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // EmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 451);
            this.Controls.Add(this.frm_emply_cb_pstn);
            this.Controls.Add(this.employee_btn_search);
            this.Controls.Add(this.emplye_txtbx_search);
            this.Controls.Add(this.btn_employee_update);
            this.Controls.Add(this.btn_employee_save);
            this.Controls.Add(this.btn_employee_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frm_employee_slry);
            this.Controls.Add(this.frm_employee_sttime);
            this.Controls.Add(this.frm_employee_phn);
            this.Controls.Add(this.frm_employee_email);
            this.Controls.Add(this.frm_employee_srnm);
            this.Controls.Add(this.frm_employee_name);
            this.Controls.Add(this.employe_datagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeFrm";
            this.Text = "EmployeeFrm";
            this.Load += new System.EventHandler(this.EmployeeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employe_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_employee_update;
        private System.Windows.Forms.Button btn_employee_save;
        private System.Windows.Forms.Button btn_employee_delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frm_employee_slry;
        private System.Windows.Forms.TextBox frm_employee_sttime;
        private System.Windows.Forms.TextBox frm_employee_phn;
        private System.Windows.Forms.TextBox frm_employee_email;
        private System.Windows.Forms.TextBox frm_employee_srnm;
        private System.Windows.Forms.TextBox frm_employee_name;
        private System.Windows.Forms.DataGridView employe_datagridview;
        private System.Windows.Forms.Button employee_btn_search;
        private System.Windows.Forms.TextBox emplye_txtbx_search;
        private System.Windows.Forms.ComboBox frm_emply_cb_pstn;
    }
}