namespace AcademyMngtSystem
{
    partial class ClassRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassRoom));
            this.clsrmdatagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clsrm_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_clsrm_updt = new System.Windows.Forms.Button();
            this.btn_clsrm_save = new System.Windows.Forms.Button();
            this.btn_clsrm_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clsrm_search = new System.Windows.Forms.Button();
            this.clsrm_txtbx_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clsrm_cmbbx_group = new System.Windows.Forms.ComboBox();
            this.clsrm_stdnt_name = new System.Windows.Forms.TextBox();
            this.clsrm_grp_capacity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clsrmdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clsrmdatagrid
            // 
            this.clsrmdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clsrmdatagrid.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.clsrmdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clsrmdatagrid.Location = new System.Drawing.Point(291, 60);
            this.clsrmdatagrid.Name = "clsrmdatagrid";
            this.clsrmdatagrid.Size = new System.Drawing.Size(371, 277);
            this.clsrmdatagrid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // clsrm_status
            // 
            this.clsrm_status.Location = new System.Drawing.Point(94, 132);
            this.clsrm_status.Name = "clsrm_status";
            this.clsrm_status.Size = new System.Drawing.Size(153, 20);
            this.clsrm_status.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Include Information";
            // 
            // btn_clsrm_updt
            // 
            this.btn_clsrm_updt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_clsrm_updt.FlatAppearance.BorderSize = 0;
            this.btn_clsrm_updt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_clsrm_updt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clsrm_updt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clsrm_updt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clsrm_updt.Location = new System.Drawing.Point(128, 257);
            this.btn_clsrm_updt.Name = "btn_clsrm_updt";
            this.btn_clsrm_updt.Size = new System.Drawing.Size(119, 33);
            this.btn_clsrm_updt.TabIndex = 7;
            this.btn_clsrm_updt.Text = "Update";
            this.btn_clsrm_updt.UseVisualStyleBackColor = false;
            // 
            // btn_clsrm_save
            // 
            this.btn_clsrm_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_clsrm_save.FlatAppearance.BorderSize = 0;
            this.btn_clsrm_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_clsrm_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clsrm_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clsrm_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clsrm_save.Location = new System.Drawing.Point(12, 206);
            this.btn_clsrm_save.Name = "btn_clsrm_save";
            this.btn_clsrm_save.Size = new System.Drawing.Size(235, 33);
            this.btn_clsrm_save.TabIndex = 8;
            this.btn_clsrm_save.Text = "Save";
            this.btn_clsrm_save.UseVisualStyleBackColor = false;
            this.btn_clsrm_save.Click += new System.EventHandler(this.Btn_teacher_save_Click);
            // 
            // btn_clsrm_delete
            // 
            this.btn_clsrm_delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_clsrm_delete.FlatAppearance.BorderSize = 0;
            this.btn_clsrm_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_clsrm_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clsrm_delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clsrm_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clsrm_delete.Location = new System.Drawing.Point(12, 257);
            this.btn_clsrm_delete.Name = "btn_clsrm_delete";
            this.btn_clsrm_delete.Size = new System.Drawing.Size(110, 33);
            this.btn_clsrm_delete.TabIndex = 10;
            this.btn_clsrm_delete.Text = "Delete";
            this.btn_clsrm_delete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "by_hasanzada";
            // 
            // btn_clsrm_search
            // 
            this.btn_clsrm_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clsrm_search.BackgroundImage")));
            this.btn_clsrm_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clsrm_search.FlatAppearance.BorderSize = 0;
            this.btn_clsrm_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clsrm_search.Location = new System.Drawing.Point(543, 2);
            this.btn_clsrm_search.Name = "btn_clsrm_search";
            this.btn_clsrm_search.Size = new System.Drawing.Size(56, 44);
            this.btn_clsrm_search.TabIndex = 12;
            this.btn_clsrm_search.UseVisualStyleBackColor = true;
            // 
            // clsrm_txtbx_search
            // 
            this.clsrm_txtbx_search.Location = new System.Drawing.Point(291, 15);
            this.clsrm_txtbx_search.Multiline = true;
            this.clsrm_txtbx_search.Name = "clsrm_txtbx_search";
            this.clsrm_txtbx_search.Size = new System.Drawing.Size(246, 20);
            this.clsrm_txtbx_search.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(7, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Group";
            // 
            // clsrm_cmbbx_group
            // 
            this.clsrm_cmbbx_group.FormattingEnabled = true;
            this.clsrm_cmbbx_group.Location = new System.Drawing.Point(94, 167);
            this.clsrm_cmbbx_group.Name = "clsrm_cmbbx_group";
            this.clsrm_cmbbx_group.Size = new System.Drawing.Size(153, 21);
            this.clsrm_cmbbx_group.TabIndex = 13;
            this.clsrm_cmbbx_group.SelectedIndexChanged += new System.EventHandler(this.Clsrm_cmbbx_group_SelectedIndexChanged);
            // 
            // clsrm_stdnt_name
            // 
            this.clsrm_stdnt_name.Location = new System.Drawing.Point(94, 60);
            this.clsrm_stdnt_name.Name = "clsrm_stdnt_name";
            this.clsrm_stdnt_name.Size = new System.Drawing.Size(153, 20);
            this.clsrm_stdnt_name.TabIndex = 14;
            // 
            // clsrm_grp_capacity
            // 
            this.clsrm_grp_capacity.Location = new System.Drawing.Point(94, 94);
            this.clsrm_grp_capacity.Name = "clsrm_grp_capacity";
            this.clsrm_grp_capacity.Size = new System.Drawing.Size(153, 20);
            this.clsrm_grp_capacity.TabIndex = 15;
            // 
            // ClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 343);
            this.Controls.Add(this.clsrm_grp_capacity);
            this.Controls.Add(this.clsrm_stdnt_name);
            this.Controls.Add(this.clsrm_cmbbx_group);
            this.Controls.Add(this.btn_clsrm_search);
            this.Controls.Add(this.clsrm_txtbx_search);
            this.Controls.Add(this.btn_clsrm_updt);
            this.Controls.Add(this.btn_clsrm_save);
            this.Controls.Add(this.btn_clsrm_delete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clsrm_status);
            this.Controls.Add(this.clsrmdatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClassRoom";
            this.Text = "ClassRoom";
            this.Load += new System.EventHandler(this.ClassRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clsrmdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clsrmdatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clsrm_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_clsrm_updt;
        private System.Windows.Forms.Button btn_clsrm_save;
        private System.Windows.Forms.Button btn_clsrm_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clsrm_search;
        private System.Windows.Forms.TextBox clsrm_txtbx_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox clsrm_cmbbx_group;
        private System.Windows.Forms.TextBox clsrm_stdnt_name;
        private System.Windows.Forms.TextBox clsrm_grp_capacity;
    }
}