﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cartelera.aspx.cs" Inherits="Cine.AppWenCliente.Cartelera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/grid.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cartelera</title>
</head>
<body class="fondo">
    <form id="form1" runat="server">
    <div>
    <nav class="padding-largo se-gris text-center">
        <ul class="no-lista row">
            <li class="col-md-4 inline-block"><a href="Index.aspx">Inicio</a></li>
            <li><a href="Home">home</a></li>
            <li class="col-md-4 inline-block"><a href="PeliculasPorEstrenarse.aspx">Muy Pronto!</a></li>
            <li class="col-md-4 inline-block"><a>Local</a></li>
            <li class="col-md-4 inline-block"><a href="PeliculasxGenero.aspx">Peliculas por Genero</a></li>
        </ul>
    </nav>

        

        
        <div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="mGrid">
                <Columns>
                    <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="fechaEstreno" HeaderText="fechaEstreno" SortExpression="fechaEstreno" />
                    <asp:BoundField DataField="fechaFin" HeaderText="fechaFin" SortExpression="fechaFin" />
                    <asp:BoundField DataField="fechaInicio" HeaderText="fechaInicio" SortExpression="fechaInicio" />
                    <asp:ImageField HeaderText="imagen" DataAlternateTextField="imagen" DataImageUrlField="imagen" DataImageUrlFormatString="~\Resource\{0}">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDCinepolis1ConnectionString %>" 
                SelectCommand="ListarCartelera" SelectCommandType="StoredProcedure"></asp:SqlDataSource>

        </div>
        
  
        
    </div>
        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
