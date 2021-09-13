
namespace AppScraping
{
	partial class frmScraping
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtContenido = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblCantidadCaracteres = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL";
			// 
			// txtUrl
			// 
			this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUrl.Location = new System.Drawing.Point(53, 12);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(442, 27);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnBuscar.Location = new System.Drawing.Point(511, 11);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(156, 28);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar Contenido";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtContenido
			// 
			this.txtContenido.Location = new System.Drawing.Point(12, 45);
			this.txtContenido.Multiline = true;
			this.txtContenido.Name = "txtContenido";
			this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtContenido.Size = new System.Drawing.Size(655, 352);
			this.txtContenido.TabIndex = 3;
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnSalir.Location = new System.Drawing.Point(527, 403);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(140, 28);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "&Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 407);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Status";
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.White;
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblStatus.ForeColor = System.Drawing.Color.Black;
			this.lblStatus.Location = new System.Drawing.Point(70, 402);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(164, 29);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCantidadCaracteres
			// 
			this.lblCantidadCaracteres.BackColor = System.Drawing.Color.White;
			this.lblCantidadCaracteres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCantidadCaracteres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCantidadCaracteres.ForeColor = System.Drawing.Color.Black;
			this.lblCantidadCaracteres.Location = new System.Drawing.Point(413, 403);
			this.lblCantidadCaracteres.Name = "lblCantidadCaracteres";
			this.lblCantidadCaracteres.Size = new System.Drawing.Size(92, 29);
			this.lblCantidadCaracteres.TabIndex = 8;
			this.lblCantidadCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(240, 407);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cantidad de caracteres";
			// 
			// frmScraping
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(679, 439);
			this.Controls.Add(this.lblCantidadCaracteres);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtContenido);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmScraping";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Web Scraping";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtContenido;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblCantidadCaracteres;
		private System.Windows.Forms.Label label4;
	}
}

