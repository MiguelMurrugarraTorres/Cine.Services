using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cine.AppWenCliente.CineWS;

namespace Cine.AppWenCliente
{
    public partial class CompraEntradas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarcomboEspectador();
                llenarcomboFuncion();
                llenarcomboTipoEntrada();
                //TextBox2.Text = GridView2.Rows[0].Cells[0].Text;
                GridView2.DataBind();
                //TextBox2.DataBind();
                TextBox3.Text = "1";
            }
        }

        void llenarcomboTipoEntrada()
        {
            TransaccionesClient proxy = new TransaccionesClient();
            DropDownList1.DataSource = proxy.ListarTipoEntrada();
            DropDownList1.SelectedIndex = -1;
            DropDownList1.DataTextField = "nombre";
            DropDownList1.DataValueField = "idTipoEntrada";
            DropDownList1.DataBind();
        }

        void llenarcomboFuncion()
        {
            TransaccionesClient proxy = new TransaccionesClient();
            DropDownList2.DataSource = proxy.ListarFuncion();
            DropDownList2.DataTextField = "idFuncion";
            DropDownList2.DataValueField = "idFuncion";
            DropDownList2.DataBind();
        }

        void llenarcomboEspectador()
        {
            TransaccionesClient proxy = new TransaccionesClient();
            DropDownList3.DataSource = proxy.ListarEspectador();
            DropDownList3.DataTextField = "apellidoPaterno";
            DropDownList3.DataValueField = "idEspectador";
            DropDownList3.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TransaccionesClient pro = new TransaccionesClient();
                int idtipo;
                int idfun;
                int esp;

                idtipo = int.Parse(DropDownList1.SelectedValue.ToString());
                idfun = int.Parse(DropDownList2.SelectedValue.ToString());
                esp = int.Parse(DropDownList3.SelectedValue.ToString());

                //pro.obtenerTipoEntrada(idtipo);
                //pro.obtenerFuncion(idfun);
                //pro.obtenerEspectador1(esp);

                CompraEntrada dao = new CompraEntrada()
                {

                    cantidad = int.Parse(TextBox3.Text.ToString()),
                    tipoEntrada = pro.obtenerTipoEntrada(idtipo),
                    Funcion = pro.obtenerFuncion(idfun),
                    Espectador = pro.obtenerEspectador1(esp)
                };
                using (TransaccionesClient proxy = new TransaccionesClient())
                    proxy.crearCompraEntrada(dao);
                TextBox3.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;

                string script = @"<script type='text/javascript'>
                
                alert('Compra satisfactoria');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
               
            }
            catch (Exception )
            {

            }
            
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TextBox2.Text = GridView2.Rows[0].Cells[0].Text;
            //this.GridView2.DataBind();
            
                
       
        }

        public void total()
        {
             
        
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            


        }
      

     

    

      

      

     
    }
}