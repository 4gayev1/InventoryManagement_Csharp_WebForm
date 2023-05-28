<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Views.Admin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

.LoginForm{
    row-gap:20px;
}

#txtUserName, #txtPassword{
    height:30px;
    border-radius:100px;
}



    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">


    <div class="w-100 h-100 d-flex justify-content-center">
        <div class="LoginForm d-flex flex-column justify-content-center align-items-center w-50" runat="server">
        <h2>Daxil ol</h2>
     <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" Font-Bold="True" ForeColor="#006600" Text="Daxil ol" Font-Size="Medium" OnClick="btnLogin_Click" />
     <asp:LinkButton href="Register.aspx" runat="server" ForeColor="Black">Qeydiyyatdan keç</asp:LinkButton>
     <asp:Label ID="lblerror" runat="server" ForeColor="#CC0000"></asp:Label>
    </div>
    </div>

    
</asp:Content>
