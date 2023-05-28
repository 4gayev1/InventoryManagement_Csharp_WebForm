<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Views.Admin.Register" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
                    <label class="text-danger text-center" id="Errmsg" runat="server"></label>

   <table class="auto-style43" style="margin-top:200px;">
        <tr>
            <td class="auto-style44" colspan="2">
                <h3><strong>Daxil ol</strong></h3>
            </td>
        </tr>
        <tr>
            <td class="auto-style46">Username:&nbsp;</td>
            <td class="secclmn">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style46">Password:&nbsp;</td>
            <td class="secclmn">
                <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style46">
                <asp:Button ID="btnLogin" runat="server" Font-Bold="True" ForeColor="#006600" Text="Login" Font-Size="Medium" OnClick="btnLogin_Click" />
            </td>
            <td class="secclmn">
                <asp:Label ID="lblerror" runat="server" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
