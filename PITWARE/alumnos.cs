using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PITWARE
{
	public partial class alumnos : Form
	{
		public alumnos()
		{
			InitializeComponent();
		}

		private void alumnos_Load(object sender, EventArgs e)
		{

		}

		private void trayectosToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void sUBMENUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//datos personales
			panel1.Visible = true;
			comboBox3.Items.Clear();
			for (int x = 1999; x < 2018; x++)
			{
				comboBox3.Items.Add(x);
			}
		}
	}
}
