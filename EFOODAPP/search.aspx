<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayShops.aspx.cs" Inherits="SearchShops.DisplayShops" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<center>
				<h1>Search For Available Shops</h1>
				<hr />
			Search  : <asp:TextBox ID="TxtSearch" runat="server" Width="118px"></asp:TextBox>
			<asp:Button ID="ButSearch" runat="server" Text="Search" OnClick="ButSearch_Click" />
                <br />
                  Choose food type :  <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>Souvlakia</asp:ListItem>
                        <asp:ListItem>Burgers</asp:ListItem>
                        <asp:ListItem>Crepes</asp:ListItem>
                </asp:CheckBoxList>
                <br />
               You have chosen : 
                 <br />
                <asp:Label ID="Label1" runat="server" ></asp:Label>
                <hr />
			    <br />
			<asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No Shops Found!!" >	
				
			</asp:GridView>
			    <br />
			</center>
        </div>
    </form>
</body>
</html>
