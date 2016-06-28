<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PeliculasxGenero.aspx.cs" Inherits="Cine.AppWenCliente.PeliculasxGenero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link href="css/grid.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pelicula por Genero</title>
</head>
<body>
     <form id="form1" runat="server">

      <div>
    <nav class="padding-largo se-gris text-center">
        <ul class="no-lista row">
            <li class="col-md-4 inline-block"><a href="Index.aspx">Inicio</a></li>
            <li class="col-md-4 inline-block"><a href="Cartelera.aspx">Cartelera</a></li>
            <li class="col-md-4 inline-block"><a>Local</a></li>
            <li class="col-md-4 inline-block"><a href="PeliculasPorEstrenarse.aspx">Muy Pronto!</a></li>
            
            
        </ul>
    </nav>
          </div>


        <div>

            <asp:DropDownList ID="DropDownList1" runat="server"  DataSourceID="SqlDataSource2" DataTextField="nombre" DataValueField="idGenero"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" style="height: 22px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString3 %>" SelectCommand="SELECT [idGenero], [nombre] FROM [tbGenero]"></asp:SqlDataSource>

        </div>
      
    <div >
 
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="mGrid">
            <Columns>
                <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="fechaEstreno" HeaderText="fechaEstreno" SortExpression="fechaEstreno" />
                <asp:BoundField DataField="fechaFin" HeaderText="fechaFin" SortExpression="fechaFin" />
                <asp:BoundField DataField="fechaInicio" HeaderText="fechaInicio" SortExpression="fechaInicio" />
                <asp:ImageField DataAlternateTextField="imagen" DataImageUrlField="imagen" DataImageUrlFormatString="~\Resource\{0}" HeaderText="Imagen">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString2 %>" SelectCommand="ListarCarteleraXGenero" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="idGenero" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
 
    </div>
    </form>
</body>
</html>
