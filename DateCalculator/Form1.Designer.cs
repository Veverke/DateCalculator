namespace DateCalculator
{
    partial class frmMain
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblPickDate = new System.Windows.Forms.Label();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.btnOpenCalendar = new System.Windows.Forms.Button();
            this.txtWeeks = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lblJewishDate = new System.Windows.Forms.Label();
            this.txtJewishDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(81, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseClick);
            // 
            // lblPickDate
            // 
            this.lblPickDate.AutoSize = true;
            this.lblPickDate.Location = new System.Drawing.Point(15, 36);
            this.lblPickDate.Name = "lblPickDate";
            this.lblPickDate.Size = new System.Drawing.Size(64, 13);
            this.lblPickDate.TabIndex = 2;
            this.lblPickDate.Text = "Pick a date:";
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Location = new System.Drawing.Point(150, 87);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(44, 13);
            this.lblWeeks.TabIndex = 4;
            this.lblWeeks.Text = "Weeks:";
            // 
            // btnOpenCalendar
            // 
            this.btnOpenCalendar.Location = new System.Drawing.Point(187, 22);
            this.btnOpenCalendar.Name = "btnOpenCalendar";
            this.btnOpenCalendar.Size = new System.Drawing.Size(65, 42);
            this.btnOpenCalendar.TabIndex = 6;
            this.btnOpenCalendar.Text = "Open Calendar";
            this.btnOpenCalendar.UseVisualStyleBackColor = true;
            this.btnOpenCalendar.Click += new System.EventHandler(this.btnOpenCalendar_Click);
            // 
            // txtWeeks
            // 
            this.txtWeeks.Location = new System.Drawing.Point(215, 84);
            this.txtWeeks.Name = "txtWeeks";
            this.txtWeeks.ReadOnly = true;
            this.txtWeeks.Size = new System.Drawing.Size(46, 20);
            this.txtWeeks.TabIndex = 7;
            this.txtWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(12, 87);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Days:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(83, 83);
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(46, 20);
            this.txtDays.TabIndex = 7;
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(152, 115);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 13);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "Years:";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(12, 115);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(45, 13);
            this.lblMonths.TabIndex = 4;
            this.lblMonths.Text = "Months:";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(215, 112);
            this.txtYears.Name = "txtYears";
            this.txtYears.ReadOnly = true;
            this.txtYears.Size = new System.Drawing.Size(46, 20);
            this.txtYears.TabIndex = 7;
            this.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(83, 110);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.ReadOnly = true;
            this.txtMonths.Size = new System.Drawing.Size(46, 20);
            this.txtMonths.TabIndex = 7;
            this.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJewishDate
            // 
            this.lblJewishDate.AutoSize = true;
            this.lblJewishDate.Location = new System.Drawing.Point(53, 156);
            this.lblJewishDate.Name = "lblJewishDate";
            this.lblJewishDate.Size = new System.Drawing.Size(68, 13);
            this.lblJewishDate.TabIndex = 4;
            this.lblJewishDate.Text = "Jewish Date:";
            // 
            // txtJewishDate
            // 
            this.txtJewishDate.Location = new System.Drawing.Point(120, 153);
            this.txtJewishDate.Name = "txtJewishDate";
            this.txtJewishDate.ReadOnly = true;
            this.txtJewishDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJewishDate.Size = new System.Drawing.Size(113, 20);
            this.txtJewishDate.TabIndex = 7;
            this.txtJewishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 178);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtJewishDate);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtWeeks);
            this.Controls.Add(this.btnOpenCalendar);
            this.Controls.Add(this.lblJewishDate);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblWeeks);
            this.Controls.Add(this.lblPickDate);
            this.Controls.Add(this.txtDate);
            this.Name = "frmMain";
            this.Text = "Date Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblPickDate;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.Button btnOpenCalendar;
        private System.Windows.Forms.TextBox txtWeeks;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label lblJewishDate;
        private System.Windows.Forms.TextBox txtJewishDate;

    }
}

