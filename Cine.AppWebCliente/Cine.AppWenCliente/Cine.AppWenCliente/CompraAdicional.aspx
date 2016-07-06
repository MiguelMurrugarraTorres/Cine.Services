<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompraAdicional.aspx.cs" Inherits="Cine.AppWenCliente.CompraAdicional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Compra Combos</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
   <%-- <script src="Scripts/formatDate.js" type="text/javascript"></script>--%>
    <script src="Scripts/jquery-1.7.2.min.js"></script>
    <script src="Scripts/jquery-ui-1.8.19.custom.min.js"></script>
    <link href="css/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>

    <script type="text/javascript">
        $(function () {
            $(("input[id$='TextBox1']")).datepicker({
                dateFormat: 'dd/mm/yy'
            });
          
        });
    </script>
</head>
<body class="fondo">
    
    <nav class="padding-largo se-gris text-center navbar navbar-default" role="navigation">
       <div class="navbar-collapse collapse">
            <ul class="no-lista row nav navbar-nav">
            <li ><a href="Index.aspx"><span class="glyphicon-home">Inicio</span></a></li>
            <li ><a href="Home">home</a></li>
            <li ><a href="PeliculasPorEstrenarse.aspx">Muy Pronto!</a></li>
            <li ><a>Local</a></li>
            <li ><a href="PeliculasxGenero.aspx">Peliculas por Genero</a></li>
        </ul>
       </div>
        
    </nav>
  <div class="container" >
      <br />

    <form id="form1" runat="server" class="form-horizontal">

      
            <div class="form-group ">
              <div class="col-xs-4">
               <asp:Label ID="Label1" runat="server" Text="Label">Fecha</asp:Label>
            
               <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="form-control"></asp:TextBox>
                </div>
           
            </div>



        <div class="form-group">
            
           <div class="col-xs-4">
            <asp:Label ID="Label2" runat="server" Text="Label">Compra Entrada</asp:Label>
           <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
               <Columns>
             <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
               </Columns>
         </asp:GridView>
           </div>
             </div>

         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString2 %>" SelectCommand="listarEspectador" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="idcompra" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
        

        
            
                    
        

        <div class="form-group">
         <div class="col-xs-4">
   <asp:Label ID="Label3" runat="server" Text="Label">Combo</asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
               <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="precioVenta" HeaderText="precio Venta" SortExpression="precioVenta" />
                            <asp:ImageField DataAlternateTextField="imagen" DataImageUrlField="imagen" DataImageUrlFormatString="~\Resource\{0}" HeaderText="imagen">
                            </asp:ImageField>
                        </Columns>
                    </asp:GridView>
         </div>
         
       
        </div>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString2 %>" SelectCommand="listarImagenCombo" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="idCom" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>



         <div class="form-group">
             <div class="col-xs-4">
                <asp:Label ID="Label4" runat="server" Text="Label">Cantidad</asp:Label>   
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control col-xs-2"></asp:TextBox>
             </div>
            
        </div>
       
        <asp:Button ID="Button1" runat="server" Text="Comprar Combo" OnClick="Button1_Click" CssClass="btn btn-primary"/>
     
      
       </form>  
         </div>
            
    
   
</body>
</html>
