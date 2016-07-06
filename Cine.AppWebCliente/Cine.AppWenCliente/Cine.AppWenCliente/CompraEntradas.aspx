<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompraEntradas.aspx.cs" Inherits="Cine.AppWenCliente.CompraEntradas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="css/main.css" rel="stylesheet" />
   <link href="css/main.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
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

    <div class="container">
        <br />


         <form id="form1" runat="server" class="form-horizontal">
                

            <div class="form-group">
                <div class="col-xs-4">
                    <asp:Label ID="Label1" runat="server" Text="Label">Cantidad</asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                
                
  
             <div class="form-group"> 
                 <div class="col-xs-4">
               <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
               <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" CssClass="form-control"> </asp:DropDownList>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="precioNormal" HeaderText="precioNormal" SortExpression="precioNormal" />
                        <asp:BoundField DataField="precioFeriado" HeaderText="precioFeriado" SortExpression="precioFeriado" />
                    </Columns>
                </asp:GridView>

                 </div>
             </div>

                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString2 %>" SelectCommand="listarPrecio" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" DefaultValue="2" Name="idtipo" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>



           
                <div class="form-group">
                    <div class="col-xs-4">
                     <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                      <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" CssClass="form-control">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                  </asp:DropDownList>
                    </div>
                </div>

                
        
                <div class="form-group">
                    <div class="col-xs-4">
                 <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" CssClass="form-control">
                <asp:ListItem>--Seleccionar--</asp:ListItem>
                </asp:DropDownList>

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
                <Columns>
                <asp:ImageField DataAlternateTextField="imagen" DataImageUrlField="imagen" DataImageUrlFormatString="~\Resource\{0}" HeaderText="imagen">
                </asp:ImageField>
                </Columns>
                </asp:GridView>

                    </div>
                </div>
               
        
                
     
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Comprar " />
    



       

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString2 %>" SelectCommand="listarImagen" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" Name="idfuncion" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
      
    </form>

    </div>


   
</body>
</html>
