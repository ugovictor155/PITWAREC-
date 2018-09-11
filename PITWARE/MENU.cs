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
	public partial class MENU : Form
	{
		public MENU()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			while (progressBar1.Value < 100)
			{
				if (progressBar1.Value < progressBar1.Maximum)
				{
					progressBar1.Value = progressBar1.Value + 1;
				}
			}
			progressBar1.Visible = false;
			timer1.Enabled = false;
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;
			label6.Visible = true;
			label7.Visible = true;
			label8.Visible = true;
			pictureBox1.Visible = true;
			pie.Visible = true;
		}

		private void MENU_Load(object sender, EventArgs e)
		{
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
			label7.Visible = false;
			label8.Visible = false;
			pictureBox1.Visible = false;
			pie.Visible = false;
			timer1.Enabled = true;
			fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
		}

		private void pie_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			pie.Text = DateTime.Now.ToString("dd/MM/yyyy");
		}

		private void salir_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("GRACIAS POR USAR NUESTRO SISTEMA");
			//this.Close();
			DialogResult respuesta;
			respuesta = MessageBox.Show("ESTA SEGURO DE SALIR?", "CONFIRME OPERACIÓN",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
				this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			institucion frm = new institucion();
			frm.Show();
			

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{
			alumnos  frm = new alumnos ();
			frm.Show();
		}
	}
}
