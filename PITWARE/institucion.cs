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
	public partial class institucion : Form
		
	
	{
		int ban = 0;
		public institucion()
		{
			InitializeComponent();
			
			
		}

		private void institucion_Load(object sender, EventArgs e)
		{
			//pantalla principal
			ban = 0;
	}

		private void label1_Click(object sender, EventArgs e)
		{
			//datos colegio
			panel1.Visible = true;
			panel2.Visible =false;
			panel3.Visible = false;
			panel4.Visible = false;
			panel5.Visible = false;
			panel6.Visible = false;
			panel7.Visible = false;
			panel8.Visible = false;
			foreach ( Control c in  this.Controls)
			{
				if (c is Panel)
				{
					Panel p = (Panel)c;
					foreach (Control x in p.Controls)
					{
						if (x is TextBox)
						{
							TextBox tt = (TextBox)x;
							//tt.Text = "zz";
							//tt.Enabled = false;
							

						}
					
					}
				}
			}
			/*
			foreach(Control c in panel1.Controls )
			{
				if (c is TextBox)
				{

				}
			}
			*/


		}

		private void label2_Click(object sender, EventArgs e)
		{
			//año escolar
			panel1.Visible = false;
			panel2.Visible = true;
			panel3.Visible = false;
			panel4.Visible = false;
			panel5.Visible = false;
			panel6.Visible = false;
			panel7.Visible = false;
			panel8.Visible = false;
			textBox11.Text = "";
			textBox12.Text = "";
			textBox13.Text = "";
			textBox14.Text = "";
			textBox15.Text = "";
			textBox16.Text = "";
			for (int x = 2014; x < 2025; x++)
			{
				comboBox6.Items.Add("03/" + x);
				comboBox6.Items.Add("07/" + x);
			}

		}

		
		

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			textBox11.Text = dateTimePicker1.Text;
			dateTimePicker1.Visible = false;
			textBox11.Visible = true;
			label26.Visible = true;
			if (textBox11.Text == "")
				label27.Visible = true;

		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			textBox12.Text = dateTimePicker2.Text;
			dateTimePicker2.Visible = false;
			textBox12.Visible = true;
			label28.Visible = true;
		}

		private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
		{
			textBox13.Text = dateTimePicker3.Text;
			dateTimePicker3.Visible = false;
			textBox13.Visible = true;
			label29.Visible = true;
		}

		private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
		{
			textBox14.Text = dateTimePicker4.Text;
			dateTimePicker4.Visible = false;
			textBox14.Visible = true;
			label30.Visible = true;
		}

		private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
		{
			textBox15.Text = dateTimePicker5.Text;
			dateTimePicker5.Visible = false;
			textBox15.Visible = true;
			label31.Visible = true;
		}

		private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
		{
			textBox16.Text = dateTimePicker6.Text;
			dateTimePicker6.Visible = false;
			textBox16.Visible = true;
			label32.Visible = true;
		}

		private void label31_Click(object sender, EventArgs e)
		{
			dateTimePicker5.Visible = true;
			textBox15.Visible = false;
			label31.Visible = false;
		}

		private void label26_Click(object sender, EventArgs e)
		{
			dateTimePicker1.Visible = true;
			textBox11.Visible = false;
			label26.Visible = false;
		}

		private void label28_Click(object sender, EventArgs e)
		{
			dateTimePicker2.Visible = true;
			textBox12.Visible = false;
			label28.Visible = false;
		}

		private void label29_Click(object sender, EventArgs e)
		{
			dateTimePicker3.Visible = true;
			textBox13.Visible = false;
			label29.Visible = false;
		}

		private void label30_Click(object sender, EventArgs e)
		{
			dateTimePicker4.Visible = true;
			textBox14.Visible = false;
			label30.Visible = false;
		}

		private void label32_Click(object sender, EventArgs e)
		{
			dateTimePicker6.Visible = true;
			textBox16.Visible = false;
			label32.Visible = false;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			// no habil
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = true;
			panel4.Visible = false;
			panel5.Visible = false;
			panel6.Visible = false;
			panel7.Visible = false;
			panel8.Visible = false;
			for (int x = 2014; x < 2025; x++)
			{
				comboBox5.Items.Add("03/" + x);
				comboBox5.Items.Add("07/" + x);
			}
		}

		private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
		{
			textBox17.Text = dateTimePicker7.Text;
			dateTimePicker7.Visible = false;
			textBox17.Visible = true;
			label33.Visible = true;
		}

		private void label33_Click(object sender, EventArgs e)
		{
			dateTimePicker7.Visible = true;
			textBox17.Visible = false;
			label33.Visible = false;
		}

		private void label4_Click(object sender, EventArgs e)
		{
			// modulos
			pictureBox1.Visible = false;
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = true;
			panel5.Visible = false;
			panel6.Visible = false;
			panel7.Visible = false;
			panel8.Visible = false;
			listBox1.Items.Clear();
			listBox3.Items.Clear();
			listBox4.Items.Clear();
			listBox5.Items.Clear();
			for (int x = 7; x < 23; x++) 
			{
				for (int z = 0 ; z < 60; z+=5)
				{
					listBox1.Items.Add(x + ":"+ z);
					listBox2.Items.Add(x + ":" + z);
				}
				

			}
			for (int x = 2014; x < 2025; x++)
			{
				comboBox4.Items.Add("03/" + x);
				comboBox4.Items.Add("07/" + x);
			}



		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox19.Text = "";
			textBox19.Text = listBox1.SelectedItem.ToString();
			textBox19.Visible = true;
			listBox1.Visible = false;
			label39.Visible = true;


		}

		private void label39_Click(object sender, EventArgs e)
		{
			textBox19.Visible = false;
			listBox1.Visible = true;
			label39.Visible = false;
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox20.Text = "";
			textBox20.Text = listBox2.SelectedItem.ToString();
			textBox20.Visible = true;
			listBox2.Visible = false;
			label43.Visible = true;
			pictureBox1.Visible = true;
		}

		private void label43_Click(object sender, EventArgs e)
		{
			textBox20.Visible = false;
			listBox2.Visible = true;
			label43.Visible = false;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ban = ban + 1;

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != -1 && textBox19.Text != "" && textBox20.Text != "") 
			{
				listBox3.Items.Add(comboBox1.SelectedItem.ToString());
				listBox4.Items.Add(textBox19.Text);
				listBox5.Items.Add(textBox20.Text);
				listBox9.Items.Add(comboBox4.SelectedItem.ToString());
				pictureBox1.Visible = false;
				listBox1.Visible = true;
				listBox2.Visible = true;
				label39.Visible = false;
				label43.Visible = false;
				listBox1.Items.Clear();
				listBox2.Items.Clear();
				for (int x = 7; x < 23; x++)
				{
					for (int z = 0; z < 60; z += 5)
					{
						listBox1.Items.Add(x + ":" + z);
						listBox2.Items.Add(x + ":" + z);
					}


				}

			}
			else
			{
				MessageBox.Show ( "FALTA SELECCIONAR MAS INFORMACIÓN");

			}

		}

		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox4.SelectedIndex = listBox3.SelectedIndex;
			listBox5.SelectedIndex = listBox3.SelectedIndex;
			listBox9.SelectedIndex = listBox3.SelectedIndex;
		}

		private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox3.SelectedIndex = listBox4.SelectedIndex;
			listBox5.SelectedIndex = listBox4.SelectedIndex;
			listBox9.SelectedIndex = listBox4.SelectedIndex;
		}

		private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox3.SelectedIndex = listBox5.SelectedIndex;
			listBox4.SelectedIndex = listBox5.SelectedIndex;
			listBox9.SelectedIndex = listBox5.SelectedIndex;
		}

		private void label5_Click(object sender, EventArgs e)
		{
			// trayecto formativo
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;
			panel5.Visible = true;
			panel6.Visible = false;
			panel7.Visible = false;
			panel8.Visible = false;
			listBox6 .Items .Clear ();
			for (int z = 1; z < 38; z++)
			{
				listBox6.Items.Add(z);
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{
			//grupos
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;
			panel5.Visible = false;
			panel6.Visible = true;
			panel7.Visible = false;
			panel8.Visible = false;
			comboBox3.Items.Clear();
			for (int x = 2014; x < 2025; x++)
			{
				comboBox3.Items.Add("03/" + x);
				comboBox3.Items.Add("07/" + x);
			}

		}

		private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox3.SelectedIndex = listBox9.SelectedIndex;
			listBox4.SelectedIndex = listBox9.SelectedIndex;
			listBox5.SelectedIndex = listBox9.SelectedIndex;
		}

		private void label8_Click(object sender, EventArgs e)
		{
			//HORARIO
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;
			panel5.Visible = false;
			panel6.Visible = false;
			panel7.Visible = true;
			panel8.Visible = false;
			comboBox7.Items.Clear();
			for (int x = 2014; x < 2025; x++)
			{
				comboBox7.Items.Add("03/" + x);
				comboBox7.Items.Add("07/" + x);
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{
			//libro actas
			panel1.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;
			panel5.Visible = false;
			panel6.Visible = false;
			panel7.Visible = false;
			panel8.Visible = true;
		}

		private void label74_Click(object sender, EventArgs e)
		{
			groupBox6.Visible = true;
		}
	}
}
