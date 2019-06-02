namespace AcademyMngtSystem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.academyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacansiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classRoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_main_Student = new System.Windows.Forms.Button();
            this.btn_main_Task = new System.Windows.Forms.Button();
            this.btn_man_Employee = new System.Windows.Forms.Button();
            this.btn_main_education = new System.Windows.Forms.Button();
            this.btnTeacherReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(263, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Our Acaemdy";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.academyToolStripMenuItem,
            this.educationToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.positionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // academyToolStripMenuItem
            // 
            this.academyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.academyInfoToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.vacansiesToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.academyToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.academyToolStripMenuItem.Name = "academyToolStripMenuItem";
            this.academyToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.academyToolStripMenuItem.Text = "Academy";
            this.academyToolStripMenuItem.Click += new System.EventHandler(this.AcademyToolStripMenuItem_Click);
            // 
            // academyInfoToolStripMenuItem
            // 
            this.academyInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.academyInfoToolStripMenuItem.Name = "academyInfoToolStripMenuItem";
            this.academyInfoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.academyInfoToolStripMenuItem.Text = "Academy Info";
            this.academyInfoToolStripMenuItem.Click += new System.EventHandler(this.AcademyInfoToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachersToolStripMenuItem1});
            this.teachersToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.teachersToolStripMenuItem.Text = "Employee";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.TeachersToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem1
            // 
            this.teachersToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachersToolStripMenuItem2});
            this.teachersToolStripMenuItem1.ForeColor = System.Drawing.Color.Teal;
            this.teachersToolStripMenuItem1.Name = "teachersToolStripMenuItem1";
            this.teachersToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.teachersToolStripMenuItem1.Text = "Positions";
            this.teachersToolStripMenuItem1.Click += new System.EventHandler(this.TeachersToolStripMenuItem1_Click);
            // 
            // teachersToolStripMenuItem2
            // 
            this.teachersToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.classRoomToolStripMenuItem});
            this.teachersToolStripMenuItem2.ForeColor = System.Drawing.Color.Teal;
            this.teachersToolStripMenuItem2.Name = "teachersToolStripMenuItem2";
            this.teachersToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.teachersToolStripMenuItem2.Text = "Teachers";
            this.teachersToolStripMenuItem2.Click += new System.EventHandler(this.TeachersToolStripMenuItem2_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItem_Click);
            // 
            // classRoomToolStripMenuItem
            // 
            this.classRoomToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.classRoomToolStripMenuItem.Name = "classRoomToolStripMenuItem";
            this.classRoomToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.classRoomToolStripMenuItem.Text = "ClassRoom";
            this.classRoomToolStripMenuItem.Click += new System.EventHandler(this.ClassRoomToolStripMenuItem_Click);
            // 
            // vacansiesToolStripMenuItem
            // 
            this.vacansiesToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.vacansiesToolStripMenuItem.Name = "vacansiesToolStripMenuItem";
            this.vacansiesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vacansiesToolStripMenuItem.Text = "Vacansies";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem1,
            this.classRoomToolStripMenuItem1,
            this.tasksToolStripMenuItem});
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.employeeToolStripMenuItem.Text = "Students";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem1
            // 
            this.groupToolStripMenuItem1.ForeColor = System.Drawing.Color.Teal;
            this.groupToolStripMenuItem1.Name = "groupToolStripMenuItem1";
            this.groupToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.groupToolStripMenuItem1.Text = "Group";
            this.groupToolStripMenuItem1.Click += new System.EventHandler(this.GroupToolStripMenuItem1_Click);
            // 
            // classRoomToolStripMenuItem1
            // 
            this.classRoomToolStripMenuItem1.ForeColor = System.Drawing.Color.Teal;
            this.classRoomToolStripMenuItem1.Name = "classRoomToolStripMenuItem1";
            this.classRoomToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.classRoomToolStripMenuItem1.Text = "ClassRoom";
            this.classRoomToolStripMenuItem1.Click += new System.EventHandler(this.ClassRoomToolStripMenuItem1_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.TasksToolStripMenuItem_Click);
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.educationToolStripMenuItem.Text = "Education";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.EducationToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.PositionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_main_Student);
            this.panel1.Controls.Add(this.btn_main_Task);
            this.panel1.Controls.Add(this.btn_man_Employee);
            this.panel1.Controls.Add(this.btn_main_education);
            this.panel1.Controls.Add(this.btnTeacherReg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 448);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 162);
            this.button2.TabIndex = 7;
            this.button2.Text = "Academy";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(98, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 87);
            this.button1.TabIndex = 6;
            this.button1.Text = "Info";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // btn_main_Student
            // 
            this.btn_main_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.btn_main_Student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main_Student.BackgroundImage")));
            this.btn_main_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_main_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_Student.FlatAppearance.BorderSize = 0;
            this.btn_main_Student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_main_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_Student.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_main_Student.Location = new System.Drawing.Point(3, 350);
            this.btn_main_Student.Name = "btn_main_Student";
            this.btn_main_Student.Size = new System.Drawing.Size(76, 96);
            this.btn_main_Student.TabIndex = 5;
            this.btn_main_Student.Text = "Student";
            this.btn_main_Student.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_Student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_Student.UseVisualStyleBackColor = false;
            this.btn_main_Student.Click += new System.EventHandler(this.Btn_main_Student_Click);
            // 
            // btn_main_Task
            // 
            this.btn_main_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.btn_main_Task.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main_Task.BackgroundImage")));
            this.btn_main_Task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_main_Task.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_Task.FlatAppearance.BorderSize = 0;
            this.btn_main_Task.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_main_Task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_Task.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_main_Task.Location = new System.Drawing.Point(98, 244);
            this.btn_main_Task.Name = "btn_main_Task";
            this.btn_main_Task.Size = new System.Drawing.Size(82, 108);
            this.btn_main_Task.TabIndex = 4;
            this.btn_main_Task.Text = "Task";
            this.btn_main_Task.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_Task.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_Task.UseVisualStyleBackColor = false;
            this.btn_main_Task.Click += new System.EventHandler(this.Btn_main_Task_Click);
            // 
            // btn_man_Employee
            // 
            this.btn_man_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.btn_man_Employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_man_Employee.BackgroundImage")));
            this.btn_man_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_man_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_man_Employee.FlatAppearance.BorderSize = 0;
            this.btn_man_Employee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_man_Employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_man_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_man_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man_Employee.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_man_Employee.Location = new System.Drawing.Point(86, 152);
            this.btn_man_Employee.Name = "btn_man_Employee";
            this.btn_man_Employee.Size = new System.Drawing.Size(100, 86);
            this.btn_man_Employee.TabIndex = 3;
            this.btn_man_Employee.Text = "Employee";
            this.btn_man_Employee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_man_Employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_man_Employee.UseVisualStyleBackColor = false;
            this.btn_man_Employee.Click += new System.EventHandler(this.Btn_man_Employee_Click);
            // 
            // btn_main_education
            // 
            this.btn_main_education.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.btn_main_education.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main_education.BackgroundImage")));
            this.btn_main_education.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_main_education.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_education.FlatAppearance.BorderSize = 0;
            this.btn_main_education.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_main_education.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_education.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_education.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_main_education.Location = new System.Drawing.Point(0, 153);
            this.btn_main_education.Name = "btn_main_education";
            this.btn_main_education.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_main_education.Size = new System.Drawing.Size(89, 86);
            this.btn_main_education.TabIndex = 2;
            this.btn_main_education.Text = "Education";
            this.btn_main_education.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_education.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_education.UseVisualStyleBackColor = false;
            this.btn_main_education.Click += new System.EventHandler(this.Btn_main_education_Click);
            // 
            // btnTeacherReg
            // 
            this.btnTeacherReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.btnTeacherReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTeacherReg.BackgroundImage")));
            this.btnTeacherReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTeacherReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherReg.FlatAppearance.BorderSize = 0;
            this.btnTeacherReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnTeacherReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherReg.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnTeacherReg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacherReg.Location = new System.Drawing.Point(0, 245);
            this.btnTeacherReg.Name = "btnTeacherReg";
            this.btnTeacherReg.Size = new System.Drawing.Size(88, 108);
            this.btnTeacherReg.TabIndex = 1;
            this.btnTeacherReg.Text = "Teacher";
            this.btnTeacherReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacherReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeacherReg.UseVisualStyleBackColor = false;
            this.btnTeacherReg.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "by_hasanzada";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(795, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Opacity = 0.94D;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem academyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacansiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classRoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classRoomToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTeacherReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_main_education;
        private System.Windows.Forms.Button btn_man_Employee;
        private System.Windows.Forms.Button btn_main_Task;
        private System.Windows.Forms.Button btn_main_Student;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
    }
}

