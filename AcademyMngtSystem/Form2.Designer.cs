namespace AcademyMngtSystem
{
    partial class AddInformationfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInformationfrm));
            this.teacher_datagridview = new System.Windows.Forms.DataGridView();
            this.frm2txtbx_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frm2txtbx_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frm2txtbx_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.frm2txtbx_phn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_teacher_delete = new System.Windows.Forms.Button();
            this.btn_teacher_save = new System.Windows.Forms.Button();
            this.btn_teacher_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frm2cmbbx_spclty = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fmr_tchr_edctn_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_datagridview
            // 
            this.teacher_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacher_datagridview.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.teacher_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_datagridview.Location = new System.Drawing.Point(338, 58);
            this.teacher_datagridview.Name = "teacher_datagridview";
            this.teacher_datagridview.Size = new System.Drawing.Size(375, 369);
            this.teacher_datagridview.TabIndex = 0;
            this.teacher_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Teacher_datagridview_CellContentClick);
            // 
            // frm2txtbx_name
            // 
            this.frm2txtbx_name.Location = new System.Drawing.Point(93, 58);
            this.frm2txtbx_name.Name = "frm2txtbx_name";
            this.frm2txtbx_name.Size = new System.Drawing.Size(148, 20);
            this.frm2txtbx_name.TabIndex = 1;
            this.frm2txtbx_name.TextChanged += new System.EventHandler(this.Frm2txtbx_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // frm2txtbx_surname
            // 
            this.frm2txtbx_surname.Location = new System.Drawing.Point(93, 94);
            this.frm2txtbx_surname.Name = "frm2txtbx_surname";
            this.frm2txtbx_surname.Size = new System.Drawing.Size(148, 20);
            this.frm2txtbx_surname.TabIndex = 1;
            this.frm2txtbx_surname.TextChanged += new System.EventHandler(this.Frm2txtbx_surname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // frm2txtbx_email
            // 
            this.frm2txtbx_email.Location = new System.Drawing.Point(93, 129);
            this.frm2txtbx_email.Name = "frm2txtbx_email";
            this.frm2txtbx_email.Size = new System.Drawing.Size(148, 20);
            this.frm2txtbx_email.TabIndex = 1;
            this.frm2txtbx_email.TextChanged += new System.EventHandler(this.Frm2txtbx_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // frm2txtbx_phn
            // 
            this.frm2txtbx_phn.Location = new System.Drawing.Point(93, 167);
            this.frm2txtbx_phn.Name = "frm2txtbx_phn";
            this.frm2txtbx_phn.Size = new System.Drawing.Size(148, 20);
            this.frm2txtbx_phn.TabIndex = 1;
            this.frm2txtbx_phn.TextChanged += new System.EventHandler(this.Frm2txtbx_phn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(10, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "by_hasanzada";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Include Information";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // btn_teacher_delete
            // 
            this.btn_teacher_delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_teacher_delete.FlatAppearance.BorderSize = 0;
            this.btn_teacher_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_teacher_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_teacher_delete.Location = new System.Drawing.Point(14, 326);
            this.btn_teacher_delete.Name = "btn_teacher_delete";
            this.btn_teacher_delete.Size = new System.Drawing.Size(227, 33);
            this.btn_teacher_delete.TabIndex = 5;
            this.btn_teacher_delete.Text = "Delete";
            this.btn_teacher_delete.UseVisualStyleBackColor = false;
            this.btn_teacher_delete.Click += new System.EventHandler(this.Btn_teacher_delete_Click);
            // 
            // btn_teacher_save
            // 
            this.btn_teacher_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_teacher_save.FlatAppearance.BorderSize = 0;
            this.btn_teacher_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_teacher_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_teacher_save.Location = new System.Drawing.Point(14, 277);
            this.btn_teacher_save.Name = "btn_teacher_save";
            this.btn_teacher_save.Size = new System.Drawing.Size(227, 33);
            this.btn_teacher_save.TabIndex = 5;
            this.btn_teacher_save.Text = "Save";
            this.btn_teacher_save.UseVisualStyleBackColor = false;
            this.btn_teacher_save.Click += new System.EventHandler(this.Btn_teacher_save_Click);
            // 
            // btn_teacher_update
            // 
            this.btn_teacher_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_teacher_update.FlatAppearance.BorderSize = 0;
            this.btn_teacher_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_teacher_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_update.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_teacher_update.Location = new System.Drawing.Point(14, 374);
            this.btn_teacher_update.Name = "btn_teacher_update";
            this.btn_teacher_update.Size = new System.Drawing.Size(227, 33);
            this.btn_teacher_update.TabIndex = 5;
            this.btn_teacher_update.Text = "Update";
            this.btn_teacher_update.UseVisualStyleBackColor = false;
            this.btn_teacher_update.Click += new System.EventHandler(this.Btn_teacher_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speciality";
            this.label1.Click += new System.EventHandler(this.Label6_Click);
            // 
            // frm2cmbbx_spclty
            // 
            this.frm2cmbbx_spclty.FormattingEnabled = true;
            this.frm2cmbbx_spclty.Location = new System.Drawing.Point(93, 204);
            this.frm2cmbbx_spclty.Name = "frm2cmbbx_spclty";
            this.frm2cmbbx_spclty.Size = new System.Drawing.Size(148, 21);
            this.frm2cmbbx_spclty.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(590, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 44);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fmr_tchr_edctn_cb
            // 
            this.fmr_tchr_edctn_cb.FormattingEnabled = true;
            this.fmr_tchr_edctn_cb.Location = new System.Drawing.Point(93, 241);
            this.fmr_tchr_edctn_cb.Name = "fmr_tchr_edctn_cb";
            this.fmr_tchr_edctn_cb.Size = new System.Drawing.Size(148, 21);
            this.fmr_tchr_edctn_cb.TabIndex = 9;
            this.fmr_tchr_edctn_cb.SelectedIndexChanged += new System.EventHandler(this.Fmr_tchr_edctn_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(10, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Education";
            this.label4.Click += new System.EventHandler(this.Label6_Click);
            // 
            // AddInformationfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 429);
            this.Controls.Add(this.fmr_tchr_edctn_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.frm2cmbbx_spclty);
            this.Controls.Add(this.btn_teacher_update);
            this.Controls.Add(this.btn_teacher_save);
            this.Controls.Add(this.btn_teacher_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frm2txtbx_phn);
            this.Controls.Add(this.frm2txtbx_email);
            this.Controls.Add(this.frm2txtbx_surname);
            this.Controls.Add(this.frm2txtbx_name);
            this.Controls.Add(this.teacher_datagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddInformationfrm";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.AddInformationfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView teacher_datagridview;
        private System.Windows.Forms.TextBox frm2txtbx_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frm2txtbx_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox frm2txtbx_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox frm2txtbx_phn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_teacher_delete;
        private System.Windows.Forms.Button btn_teacher_save;
        private System.Windows.Forms.Button btn_teacher_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frm2cmbbx_spclty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fmr_tchr_edctn_cb;
        private System.Windows.Forms.Label label4;
    }
}