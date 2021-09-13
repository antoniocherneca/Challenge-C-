using System;
using System.Windows.Forms;

namespace AppArray
{
	public partial class frmArray: Form
	{
		public frmArray()
		{
			InitializeComponent();
		}
		int[] numeros = new int[100];

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();       
		}

		private void frmArray_Load(object sender, EventArgs e)
		{
			GenerarArray();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			int numeroABuscar = 0, encontrado;
			try
			{
				numeroABuscar = Convert.ToInt32(txtNumeroBuscado.Text);
				encontrado = Array.IndexOf(numeros, numeroABuscar);
				VerificarIndice(numeroABuscar, encontrado);
			}
			catch(Exception error)
			{
				MessageBox.Show(error.Message, "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void VerificarIndice(int numeroABuscar, int encontrado)
		{
			if(encontrado == -1)
			{
				MessageBox.Show($"El número {numeroABuscar} no existe en el array definido", 
					"Resultado de la Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show($"El índice del elemento {numeroABuscar} es: {encontrado}", 
					"Resultado de la Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void GenerarArray()
		{
			Random aleatorio = new Random();
			int numeroInicio = aleatorio.Next(1, 900);
			for(int i = 0; i < 100; i++)
			{
				numeros[i] = numeroInicio + i;
				Console.WriteLine(numeros[i]);
			}
		}
	}
}
