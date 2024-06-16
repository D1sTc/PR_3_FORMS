namespace PR_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationGeometricMean = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ValueMatrix = new System.Windows.Forms.GroupBox();
            this.GeometricMeanMatrixButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.textBoxLines = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labellines = new System.Windows.Forms.Label();
            this.labelcolumns = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxmatrix = new System.Windows.Forms.PictureBox();
            this.TaskPNG = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(859, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "файл";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationGeometricMean});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(146, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationGeometricMean
            // 
            this.ApplicationGeometricMean.Name = "ApplicationGeometricMean";
            this.ApplicationGeometricMean.Size = new System.Drawing.Size(261, 22);
            this.ApplicationGeometricMean.Text = "Программа \"ср. геометрическое\"";
            this.ApplicationGeometricMean.Click += new System.EventHandler(this.ApplicationGeometricMean_Click);
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(146, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(146, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(149, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Task.Controls.Add(this.pictureBoxmatrix);
            this.Task.Controls.Add(this.TaskPNG);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(835, 80);
            this.Task.TabIndex = 3;
            this.Task.TabStop = false;
            this.Task.Text = "Задание:";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(715, 163);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 39);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход 🚪";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.Location = new System.Drawing.Point(568, 163);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(117, 39);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Очистить 🧹";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ValueMatrix
            // 
            this.ValueMatrix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ValueMatrix.Location = new System.Drawing.Point(12, 113);
            this.ValueMatrix.Name = "ValueMatrix";
            this.ValueMatrix.Size = new System.Drawing.Size(281, 150);
            this.ValueMatrix.TabIndex = 8;
            this.ValueMatrix.TabStop = false;
            this.ValueMatrix.Text = "Матрица:";
            // 
            // GeometricMeanMatrixButton
            // 
            this.GeometricMeanMatrixButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GeometricMeanMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GeometricMeanMatrixButton.Location = new System.Drawing.Point(558, 114);
            this.GeometricMeanMatrixButton.Name = "GeometricMeanMatrixButton";
            this.GeometricMeanMatrixButton.Size = new System.Drawing.Size(289, 34);
            this.GeometricMeanMatrixButton.TabIndex = 12;
            this.GeometricMeanMatrixButton.Text = "Вычислить ср. геометрическое значение";
            this.GeometricMeanMatrixButton.UseVisualStyleBackColor = false;
            this.GeometricMeanMatrixButton.Click += new System.EventHandler(this.GeometricMeanMatrixButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CreateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateMatrix.Location = new System.Drawing.Point(124, 76);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(77, 34);
            this.CreateMatrix.TabIndex = 13;
            this.CreateMatrix.Text = "Создать";
            this.CreateMatrix.UseVisualStyleBackColor = false;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(103, 19);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(117, 20);
            this.textBoxColumns.TabIndex = 12;
            this.textBoxColumns.TextChanged += new System.EventHandler(this.textBoxColumns_TextChanged);
            // 
            // textBoxLines
            // 
            this.textBoxLines.Location = new System.Drawing.Point(103, 50);
            this.textBoxLines.Name = "textBoxLines";
            this.textBoxLines.Size = new System.Drawing.Size(117, 20);
            this.textBoxLines.TabIndex = 14;
            this.textBoxLines.TextChanged += new System.EventHandler(this.textBoxLines_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.labelinfo);
            this.groupBox1.Controls.Add(this.labellines);
            this.groupBox1.Controls.Add(this.labelcolumns);
            this.groupBox1.Controls.Add(this.CreateMatrix);
            this.groupBox1.Controls.Add(this.textBoxLines);
            this.groupBox1.Controls.Add(this.textBoxColumns);
            this.groupBox1.Location = new System.Drawing.Point(299, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления создания матрицы";
            // 
            // labellines
            // 
            this.labellines.AutoSize = true;
            this.labellines.Location = new System.Drawing.Point(6, 53);
            this.labellines.Name = "labellines";
            this.labellines.Size = new System.Drawing.Size(76, 13);
            this.labellines.TabIndex = 16;
            this.labellines.Text = "Кол-во строк:";
            // 
            // labelcolumns
            // 
            this.labelcolumns.AutoSize = true;
            this.labelcolumns.Location = new System.Drawing.Point(3, 22);
            this.labelcolumns.Name = "labelcolumns";
            this.labelcolumns.Size = new System.Drawing.Size(94, 13);
            this.labelcolumns.TabIndex = 15;
            this.labelcolumns.Text = "Кол-во столбцов:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR_3.Properties.Resources.matrix2;
            this.pictureBox1.Location = new System.Drawing.Point(558, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxmatrix
            // 
            this.pictureBoxmatrix.Image = global::PR_3.Properties.Resources.matrix;
            this.pictureBoxmatrix.Location = new System.Drawing.Point(694, -27);
            this.pictureBoxmatrix.Name = "pictureBoxmatrix";
            this.pictureBoxmatrix.Size = new System.Drawing.Size(136, 131);
            this.pictureBoxmatrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxmatrix.TabIndex = 1;
            this.pictureBoxmatrix.TabStop = false;
            // 
            // TaskPNG
            // 
            this.TaskPNG.Image = global::PR_3.Properties.Resources._213442;
            this.TaskPNG.Location = new System.Drawing.Point(6, 19);
            this.TaskPNG.Name = "TaskPNG";
            this.TaskPNG.Size = new System.Drawing.Size(682, 50);
            this.TaskPNG.TabIndex = 0;
            this.TaskPNG.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PR_3.Properties.Resources.matrix2;
            this.pictureBox2.Location = new System.Drawing.Point(631, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PR_3.Properties.Resources.matrix2;
            this.pictureBox3.Location = new System.Drawing.Point(704, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PR_3.Properties.Resources.matrix2;
            this.pictureBox4.Location = new System.Drawing.Point(775, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(6, 122);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(55, 13);
            this.labelinfo.TabIndex = 17;
            this.labelinfo.Text = "от 0 до 5*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GeometricMeanMatrixButton);
            this.Controls.Add(this.ValueMatrix);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №3";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox TaskPNG;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox ValueMatrix;
        private System.Windows.Forms.Button GeometricMeanMatrixButton;
        private System.Windows.Forms.ToolStripMenuItem ApplicationGeometricMean;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.TextBox textBoxLines;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label labelcolumns;
        private System.Windows.Forms.Label labellines;
        private System.Windows.Forms.PictureBox pictureBoxmatrix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelinfo;
    }
}

