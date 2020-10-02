using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_hw7_calender
{
	public partial class Form1 : Form
	{
		private string selectedDate;
		public Form1()
		{
			InitializeComponent();
			this.selectedDate = "";
			DateTime d = monthCalendar1.SelectionRange.End;
			checkMonth(d.Month);
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			DateTime d = monthCalendar1.SelectionRange.End;
			selectedDate = d.Year.ToString()+"-"+d.Month.ToString()+"-"+d.Day.ToString(); //Get the month selected.
			//MessageBox.Show("Selected Date:" + selectedDate);
			checkMonth(d.Month);
		}

		private void checkMonth(int m)
		{
			if(m>=3&&m<=5)
			{
				pictureBox2.Image = imageList1.Images[0];
			}
			else if(m>=6&&m<=8)
			{
				pictureBox2.Image = imageList1.Images[1];
			}
			else if(m>=9&&m<=11)
			{
				pictureBox2.Image = imageList1.Images[2];
			}
			else if(m>=12||m<=2)
			{
				pictureBox2.Image = imageList1.Images[3];
			}
			else
			{
				MessageBox.Show("Err: unpredicted error. Bug Existed. month="+m);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
