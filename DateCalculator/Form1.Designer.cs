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
            this.lblWeeksPassed = new System.Windows.Forms.Label();
            this.btnOpenCalendar = new System.Windows.Forms.Button();
            this.txtWeeksPassed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(81, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
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
            // lblWeeksPassed
            // 
            this.lblWeeksPassed.AutoSize = true;
            this.lblWeeksPassed.Location = new System.Drawing.Point(30, 90);
            this.lblWeeksPassed.Name = "lblWeeksPassed";
            this.lblWeeksPassed.Size = new System.Drawing.Size(130, 13);
            this.lblWeeksPassed.TabIndex = 4;
            this.lblWeeksPassed.Text = "Number of weeks passed:";
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
            // txtWeeksPassed
            // 
            this.txtWeeksPassed.Location = new System.Drawing.Point(168, 88);
            this.txtWeeksPassed.Name = "txtWeeksPassed";
            this.txtWeeksPassed.ReadOnly = true;
            this.txtWeeksPassed.Size = new System.Drawing.Size(46, 20);
            this.txtWeeksPassed.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 132);
            this.Controls.Add(this.txtWeeksPassed);
            this.Controls.Add(this.btnOpenCalendar);
            this.Controls.Add(this.lblWeeksPassed);
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
        private System.Windows.Forms.Label lblWeeksPassed;
        private System.Windows.Forms.Button btnOpenCalendar;
        private System.Windows.Forms.TextBox txtWeeksPassed;

    }
}

