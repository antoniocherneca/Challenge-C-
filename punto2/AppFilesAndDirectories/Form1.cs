using System;
using System.IO;
using System.Windows.Forms;

namespace AppFilesAndDirectories
{
	public partial class frmArchivosDirectorios: Form
	{
		public frmArchivosDirectorios()
		{
			InitializeComponent();
		}
		string pathCarpeta;

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BuscarUbicacion_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog busquedaCarpeta = new FolderBrowserDialog();
			if(busquedaCarpeta.ShowDialog() == DialogResult.OK)
			{
				pathCarpeta = busquedaCarpeta.SelectedPath;
				txtPathCarpeta.Text = pathCarpeta;
			}
		}

		private void btnProcesarIngreso_Click(object sender, EventArgs e)
		{
			string pathCompleto = pathCarpeta + "\\" + txtNombreArchivo.Text + ".txt";
			if(txtPathCarpeta.Text == "" || txtTextoAIngresar.Text == "" || txtNombreArchivo.Text == "")
			{
				MessageBox.Show("Debe inresar todos los datos", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				if(rabReemplazar.Checked)
				{
					File.WriteAllText(pathCompleto, txtTextoAIngresar.Text + "\n");
					MessageBox.Show("Operación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if(File.Exists(pathCompleto))
					{
						File.AppendAllText(pathCompleto, txtTextoAIngresar.Text + "\n");
						MessageBox.Show("Operación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("El archivo no existe. Verifique el nombre del archivo y la ruta " +
							"donde lo va a guardar.", "Archivo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation;
					}
				}
			}
		}
	}
}
