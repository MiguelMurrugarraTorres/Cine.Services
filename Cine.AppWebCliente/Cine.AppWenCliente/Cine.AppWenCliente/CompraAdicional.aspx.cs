using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cine.AppWenCliente.CineWS;

namespace Cine.AppWenCliente
{
    public partial class CompraAdicional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = DateTime.Today.ToString("dd/MM/yyyy");
                TextBox1.ForeColor = System.Drawing.Color.Blue;
                TextBox1.DataBind();
                llenarCombo();
                llenarCompraEntrada();
                GridView1.DataBind();
                GridView2.DataBind();
                TextBox2.Text = "1";
            }
        }


        void llenarCompraEntrada()
        {
            TransaccionesClient proxy = new TransaccionesClient();
            DropDownList1.DataSource = proxy.ListarCompraEntrada();
            DropDownList1.SelectedIndex = -1;
            DropDownList1.DataTextField = "idCompraEntrada";
            DropDownList1.DataValueField = "idCompraEntrada";
            DropDownList1.DataBind();
        }

        void llenarCombo()
        {
            TransaccionesClient proxy = new TransaccionesClient();
            DropDownList2.DataSource = proxy.ListarCombo();
            DropDownList2.DataTextField = "nombre";
            DropDownList2.DataValueField = "idCombo";
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TransaccionesClient pro = new TransaccionesClient();
                int idcom;
                int idcombo;
                idcom = int.Parse(DropDownList1.SelectedValue.ToString());
                idcombo = int.Parse(DropDownList2.SelectedValue.ToString());
                CompraAdicionales dao = new CompraAdicionales()
                
                {
                    
                    fecha =Convert.ToDateTime(TextBox1.Text.ToString()),
                    CompraEntradas = pro.obtenerCompraEntrada(idcom),
                    combo = pro.obtenerCombo(idcombo),
                    cantidad = int.Parse(TextBox2.Text.ToString())
                };
                using (TransaccionesClient proxy = new TransaccionesClient())
                    proxy.crearCompraAdicional(dao);


                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
              

                string script = @"<script type='text/javascript'>
                
                alert('Compra satisfactoria');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            catch (Exception)
            {

            }
            

        }

      

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}