
namespace AppFilesAndDirectories
{
	partial class frmArchivosDirectorios
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
			if(disposing && (components != null))
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
			this.txtTextoAIngresar = new System.Windows.Forms.TextBox();
			this.btnProcesarIngreso = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.BuscarUbicacion = new System.Windows.Forms.Button();
			this.txtPathCarpeta = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.rabReemplazar = new System.Windows.Forms.RadioButton();
			this.rabAgregar = new System.Windows.Forms.RadioButton();
			this.txtNombreArchivo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTextoAIngresar
			// 
			this.txtTextoAIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTextoAIngresar.Location = new System.Drawing.Point(12, 116);
			this.txtTextoAIngresar.Multiline = true;
			this.txtTextoAIngresar.Name = "txtTextoAIngresar";
			this.txtTextoAIngresar.Size = new System.Drawing.Size(561, 101);
			this.txtTextoAIngresar.TabIndex = 2;
			// 
			// btnProcesarIngreso
			// 
			this.btnProcesarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcesarIngreso.Location = new System.Drawing.Point(317, 238);
			this.btnProcesarIngreso.Name = "btnProcesarIngreso";
			this.btnProcesarIngreso.Size = new System.Drawing.Size(125, 38);
			this.btnProcesarIngreso.TabIndex = 5;
			this.btnProcesarIngreso.Text = "&Guardar Texto";
			this.btnProcesarIngreso.UseVisualStyleBackColor = true;
			this.btnProcesarIngreso.Click += new System.EventHandler(this.btnProcesarIngreso_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Seleccione la carpeta donde desea guardar el archivo";
			// 
			// BuscarUbicacion
			// 
			this.BuscarUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuscarUbicacion.Location = new System.Drawing.Point(432, 33);
			this.BuscarUbicacion.Name = "BuscarUbicacion";
			this.BuscarUbicacion.Size = new System.Drawing.Size(143, 36);
			this.BuscarUbicacion.TabIndex = 0;
			this.BuscarUbicacion.Text = "&Buscar carpeta";
			this.BuscarUbicacion.UseVisualStyleBackColor = true;
			this.BuscarUbicacion.Click += new System.EventHandler(this.BuscarUbicacion_Click);
			// 
			// txtPathCarpeta
			// 
			this.txtPathCarpeta.Enabled = false;
			this.txtPathCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPathCarpeta.Location = new System.Drawing.Point(16, 42);
			this.txtPathCarpeta.Name = "txtPathCarpeta";
			this.txtPathCarpeta.Size = new System.Drawing.Size(408, 27);
			this.txtPathCarpeta.TabIndex = 4;
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(448, 238);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(125, 38);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "&Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// rabReemplazar
			// 
			this.rabReemplazar.AutoSize = true;
			this.rabReemplazar.Checked = true;
			this.rabReemplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rabReemplazar.ForeColor = System.Drawing.Color.White;
			this.rabReemplazar.Location = new System.Drawing.Point(12, 232);
			this.rabReemplazar.Name = "rabReemplazar";
			this.rabReemplazar.Size = new System.Drawing.Size(358, 21);
			this.rabReemplazar.TabIndex = 3;
			this.rabReemplazar.TabStop = true;
			this.rabReemplazar.Text = "Reemplazar el contenido del archivo si existe";
			this.rabReemplazar.UseVisualStyleBackColor = true;
			// 
			// rabAgregar
			// 
			this.rabAgregar.AutoSize = true;
			this.rabAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rabAgregar.ForeColor = System.Drawing.Color.White;
			this.rabAgregar.Location = new System.Drawing.Point(12, 259);
			this.rabAgregar.Name = "rabAgregar";
			this.rabAgregar.Size = new System.Drawing.Size(287, 21);
			this.rabAgregar.TabIndex = 4;
			this.rabAgregar.TabStop = true;
			this.rabAgregar.Text = "Añadir el texto ingresado al archivo";
			this.rabAgregar.UseVisualStyleBackColor = true;
			// 
			// txtNombreArchivo
			// 
			this.txtNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreArchivo.Location = new System.Drawing.Point(233, 78);
			this.txtNombreArchivo.Name = "txtNombreArchivo";
			this.txtNombreArchivo.Size = new System.Drawing.Size(340, 27);
			this.txtNombreArchivo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(13, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nombre del archivo a crear";
			// 
			// frmArchivosDirectorios
			// 
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(587, 291);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombreArchivo);
			this.Controls.Add(this.rabAgregar);
			this.Controls.Add(this.rabReemplazar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtPathCarpeta);
			this.Controls.Add(this.BuscarUbicacion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnProcesarIngreso);
			this.Controls.Add(this.txtTextoAIngresar);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmArchivosDirectorios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Archivos y Directorios";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTextoAIngresar;
		private System.Windows.Forms.Button btnProcesarIngreso;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BuscarUbicacion;
		private System.Windows.Forms.TextBox txtPathCarpeta;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.RadioButton rabReemplazar;
		private System.Windows.Forms.RadioButton rabAgregar;
		private System.Windows.Forms.TextBox txtNombreArchivo;
		private System.Windows.Forms.Label label2;
	}
}

