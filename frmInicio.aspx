<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="ASP.NET_FRAMEWORK.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonCargarInfo" runat="server" OnClick="ButtonCargarInfo_Click" Text="Cargar Información a SQL" Height="56px" Width="233px" />
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonConexionMySQL" runat="server" Height="53px" OnClick="ButtonConexionMySQL_Click" Text="Cargar Información a MySQL" Width="230px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonConexionOracle" runat="server" Height="53px" OnClick="ButtonConexionOracle_Click" Text="Cargar Información a Oracle" Width="221px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
