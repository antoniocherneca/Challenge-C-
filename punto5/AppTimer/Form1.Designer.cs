
namespace AppTimer
{
	partial class frmTimer
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.prbProceso = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrIntervalo = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btnProcesar
			// 
			this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnProcesar.Location = new System.Drawing.Point(24, 81);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(136, 34);
			this.btnProcesar.TabIndex = 0;
			this.btnProcesar.Text = "&Procesar";
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSalir.Location = new System.Drawing.Point(166, 81);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(136, 34);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "&Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// prbProceso
			// 
			this.prbProceso.Location = new System.Drawing.Point(24, 42);
			this.prbProceso.Name = "prbProceso";
			this.prbProceso.Size = new System.Drawing.Size(278, 24);
			this.prbProceso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prbProceso.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Progreso del proceso";
			// 
			// tmrIntervalo
			// 
			this.tmrIntervalo.Tick += new System.EventHandler(this.tmrIntervalo_Tick);
			// 
			// frmTimer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(321, 127);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.prbProceso);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnProcesar);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTimer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProcesar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ProgressBar prbProceso;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer tmrIntervalo;
	}
}

