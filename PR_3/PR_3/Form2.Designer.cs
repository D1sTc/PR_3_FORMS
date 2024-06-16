namespace PR_3
{
    partial class Form2
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.labelWhoDeveloped = new System.Windows.Forms.Label();
            this.labelPrgoram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.Location = new System.Drawing.Point(400, 185);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 38);
            this.buttonBack.TabIndex = 43;
            this.buttonBack.Text = "Назад ✔️";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Link.Location = new System.Drawing.Point(140, 129);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(49, 17);
            this.Link.TabIndex = 42;
            this.Link.TabStop = true;
            this.Link.Text = "D1sTc";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChannel.Location = new System.Drawing.Point(13, 129);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(121, 17);
            this.labelChannel.TabIndex = 41;
            this.labelChannel.Text = "Youtube Channel:";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialization.Location = new System.Drawing.Point(12, 91);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(443, 17);
            this.labelSpecialization.TabIndex = 40;
            this.labelSpecialization.Text = "Специальность: Информационные Системы и Программирование";
            // 
            // labelWhoDeveloped
            // 
            this.labelWhoDeveloped.AutoSize = true;
            this.labelWhoDeveloped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhoDeveloped.Location = new System.Drawing.Point(13, 55);
            this.labelWhoDeveloped.Name = "labelWhoDeveloped";
            this.labelWhoDeveloped.Size = new System.Drawing.Size(311, 17);
            this.labelWhoDeveloped.TabIndex = 39;
            this.labelWhoDeveloped.Text = "Разработал: Филиппов Александр Сергеевич";
            // 
            // labelPrgoram
            // 
            this.labelPrgoram.AutoSize = true;
            this.labelPrgoram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrgoram.Location = new System.Drawing.Point(12, 9);
            this.labelPrgoram.Name = "labelPrgoram";
            this.labelPrgoram.Size = new System.Drawing.Size(391, 24);
            this.labelPrgoram.TabIndex = 38;
            this.labelPrgoram.Text = "Программа \"Практическая работа №3\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 236);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.labelWhoDeveloped);
            this.Controls.Add(this.labelPrgoram);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.Label labelWhoDeveloped;
        private System.Windows.Forms.Label labelPrgoram;
    }
}