using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalculator
{
    public partial class frmMain : Form
    {
        DateCalculator _dateCalculator;

        public frmMain()
        {
            InitializeComponent();
            _dateCalculator = new DateCalculator();
        }

        private void txtDate_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = GetCalendarPopUp().ShowDialog();
        }

        private void btnOpenCalendar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = GetCalendarPopUp().ShowDialog();
        }

        private Form GetCalendarPopUp()
        {
            MonthCalendar calendar = new MonthCalendar();
            calendar.DateSelected += calendar_DateSelected;
            calendar.Dock = DockStyle.Fill;

            Form popup = new Form();
            popup.Width = 250;
            popup.Height = 200;

            popup.Controls.Add(calendar);
            return popup;
        }

        void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = e.Start.ToShortDateString();
            Control parentForm = (sender as MonthCalendar).Parent;
            if (parentForm is Form)
            {
                (parentForm as Form).Close();
            }

            txtWeeksPassed.Text = _dateCalculator.GetWeeksPassedSince(e.Start).ToString();
        }
    }
}
