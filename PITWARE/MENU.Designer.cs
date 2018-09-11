namespace PITWARE
{
	partial class MENU
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pie = new System.Windows.Forms.StatusStrip();
			this.salir = new System.Windows.Forms.ToolStripStatusLabel();
			this.legajo = new System.Windows.Forms.ToolStripStatusLabel();
			this.recordar = new System.Windows.Forms.ToolStripStatusLabel();
			this.fecha = new System.Windows.Forms.ToolStripStatusLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.pie.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 234);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(945, 20);
			this.progressBar1.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pie
			// 
			this.pie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salir,
            this.legajo,
            this.recordar,
            this.fecha});
			this.pie.Location = new System.Drawing.Point(0, 480);
			this.pie.Name = "pie";
			this.pie.Size = new System.Drawing.Size(963, 22);
			this.pie.TabIndex = 2;
			this.pie.Text = "statusStrip1";
			this.pie.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pie_ItemClicked);
			// 
			// salir
			// 
			this.salir.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salir.ForeColor = System.Drawing.Color.Red;
			this.salir.Image = global::PITWARE.Properties.Resources.SAL;
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(52, 17);
			this.salir.Text = "SALIR";
			this.salir.Click += new System.EventHandler(this.salir_Click);
			// 
			// legajo
			// 
			this.legajo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.legajo.ForeColor = System.Drawing.Color.Blue;
			this.legajo.Name = "legajo";
			this.legajo.Size = new System.Drawing.Size(111, 17);
			this.legajo.Text = "       LEGAJO ALUMNO";
			// 
			// recordar
			// 
			this.recordar.Name = "recordar";
			this.recordar.Size = new System.Drawing.Size(67, 17);
			this.recordar.Text = "RECORDAR";
			// 
			// fecha
			// 
			this.fecha.Name = "fecha";
			this.fecha.Size = new System.Drawing.Size(718, 17);
			this.fecha.Spring = true;
			this.fecha.Text = "      xxx";
			this.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Image = global::PITWARE.Properties.Resources.calculator_24x24_32;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new System.Drawing.Point(342, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "        ADMINISTRACIÓN";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Image = global::PITWARE.Properties.Resources.User_12_24x24_32;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(246, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "         ALUMNO";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Image = global::PITWARE.Properties.Resources.community_users_24x24_32;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(139, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "         PERSONAL";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = global::PITWARE.Properties.Resources.home_24x24_32__3_;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(21, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "         INSTITUCIÓN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(199, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(261, 123);
			this.label5.TabIndex = 16;
			this.label5.Text = "PIT";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(431, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(413, 123);
			this.label6.TabIndex = 17;
			this.label6.Text = "WARE";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::PITWARE.Properties.Resources.saldos;
			this.pictureBox1.Location = new System.Drawing.Point(287, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 77);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(186, 295);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(658, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "PROGRAMA DE INCLUSIÓN PARA LA TERMINALIDAD DE LA EDUCACIÓN SECUNDARIA";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(256, 329);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(511, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "SECUNDARIA Y FORMACIÓN LABORAL PARA JÓVENES DE 14 A 17";
			// 
			// MENU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PITWARE.Properties.Resources.rayas;
			this.ClientSize = new System.Drawing.Size(963, 502);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pie);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MENU";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MENU_Load);
			this.pie.ResumeLayout(false);
			this.pie.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusStrip pie;
		private System.Windows.Forms.ToolStripStatusLabel salir;
		private System.Windows.Forms.ToolStripStatusLabel legajo;
		private System.Windows.Forms.ToolStripStatusLabel fecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolStripStatusLabel recordar;
	}
}

