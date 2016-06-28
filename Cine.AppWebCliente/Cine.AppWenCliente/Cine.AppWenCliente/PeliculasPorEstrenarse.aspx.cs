using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cine.AppWenCliente.CineWS;

namespace Cine.AppWenCliente
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransaccionesClient proxy=new TransaccionesClient();   
           if (!IsPostBack)
            {
                this.GridView1.DataSource = proxy.ListarEstrenos();
                this.GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}