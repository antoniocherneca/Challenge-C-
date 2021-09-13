using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Net;

namespace AppScraping
{
	public partial class frmScraping: Form
	{
		public frmScraping()
		{
			InitializeComponent();
		}
		Int64 contadorCaracteres;

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string urlABuscar = txtUrl.Text;
			HtmlWeb paginaBuscada = new HtmlWeb();
			try
			{
				HttpWebRequest solicitud = (HttpWebRequest) WebRequest.Create(urlABuscar);
				HttpWebResponse webRespuesta = (HttpWebResponse) solicitud.GetResponse();
				lblStatus.Text = $"{webRespuesta.StatusCode}";

				HtmlDocument html = paginaBuscada.Load(urlABuscar);
				
				var body = html.DocumentNode.InnerText;

				txtContenido.Text = body;
				foreach(char caracter in body)
				{
					if(!caracter.Equals(""))
					{
						contadorCaracteres++;
					}
				}

				lblCantidadCaracteres.Text = contadorCaracteres.ToString();
			}
			catch(UriFormatException error)
			{
				MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(Exception error)
			{
				MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtUrl_TextChanged(object sender, EventArgs e)
		{
			txtContenido.Text = "";
			lblStatus.Text = "";
			lblCantidadCaracteres.Text = "";
		}
	}
}
