using System;
using System.Windows.Forms;

namespace AppTimer
{
	public partial class frmTimer: Form
	{
		public frmTimer()
		{
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnProcesar_Click(object sender, EventArgs e)
		{
			tmrIntervalo.Enabled = true;
		}

		private void tmrIntervalo_Tick(object sender, EventArgs e)
		{
			if(prbProceso.Value < 100)
			{
				prbProceso.Value++;
			}
			else
			{
				tmrIntervalo.Enabled = false;
				MessageBox.Show("Proceso finalizado!", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
