<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PeliculasPorEstrenarse.aspx.cs" Inherits="Cine.AppWenCliente.Peliculas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/grid.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proximo</title>
</head>
<body>
    <form id="form1" runat="server">

      <div>
    <nav class="padding-largo se-gris text-center">
        <ul class="no-lista row">
            <li class="col-md-4 inline-block"><a href="Index.aspx">Inicio</a></li>
            <li class="col-md-4 inline-block"><a href="Cartelera.aspx">Cartelera</a></li>
            <li class="col-md-4 inline-block"><a>Local</a></li>
            <li class="col-md-4 inline-block"><a href="PeliculasxGenero.aspx">Peliculas por Genero</a></li>
        </ul>
    </nav>
          </div>

    <div  >
    
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" CssClass="mGrid">
            <Columns>
                <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="duracion" HeaderText="Duracion" />
                <asp:BoundField DataField="fechaEstreno" HeaderText="Fecha Estreno" />
                <asp:BoundField DataField="Genero.nombre" HeaderText="Genero" />
                <asp:BoundField DataField="sinopsis" HeaderText="Sinopsis" />
                <asp:ImageField HeaderText="Imagen" DataImageUrlField="imagen" DataImageUrlFormatString="~\Resource\{0}" >
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
