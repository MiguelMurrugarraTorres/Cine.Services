using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cine.AppWenCliente.CineWS;

namespace Cine.AppWenCliente
{
    public partial class Cartelera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TransaccionesClient proxy = new TransaccionesClient();
            //Cartelera car =new  Cartelera();
            //if (!IsPostBack)
            //{
            //    this.GridView2.DataSource = proxy.ListarCarteleraSP();
            //    this.GridView2.DataBind();
            //}
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}