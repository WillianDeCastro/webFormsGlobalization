using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GlobalizationExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

      
 
        }

        /// <summary>
        /// Pode ser utilizado para setar o padrão do idioma na página
        /// </summary>
        protected override void InitializeCulture()
        {
            base.InitializeCulture();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listaSelecao = ((ListBox)sender).SelectedValue;

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(listaSelecao);

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(listaSelecao);

            var retorno = GetGlobalResourceObject("Resource", "AccCode");
            traducao.Text = retorno.ToString();
        }
    }
}