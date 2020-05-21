<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DogsList.aspx.cs" Inherits="PetStoreWeb.DogsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>List of All Dogs</h1>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="YearBorn" HeaderText="YearBorn" SortExpression="YearBorn" />
                    <asp:BoundField DataField="Breed" HeaderText="Breed" SortExpression="Breed" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PetStoreDBConnectionString %>" SelectCommand="SELECT * FROM [Dogs]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
