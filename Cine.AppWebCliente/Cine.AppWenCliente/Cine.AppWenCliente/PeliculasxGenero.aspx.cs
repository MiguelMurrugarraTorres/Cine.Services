using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cine.AppWenCliente
{
    public partial class PeliculasxGenero : System.Web.UI.Page
    {

        
       
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
               
            }
            
        }
        //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        SqlDataSource s = (SqlDataSource)e.Row.FindControl("SqlDataSource1");
        //        s.SelectParameters[0].DefaultValue = e.Row.Cells[0].Text;
        //    }
        //}
      

      

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            
           
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}