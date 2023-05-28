<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="WebApplication1.Views.Admin.Supplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="row" style="height:20px;background-color:crimson;">

    </div>
    <div class="row">
        <div class="col-md-3">
            <h4>Tədarükçü Məlumatları</h4>

            <div class="mb-2">
                <label>Tədarükçü adı</label>
                <input type="text" placeholder="Tədarükçü adını daxil edin" id="SupNameTb" runat="server" class="form-control mt-1"/>
            </div>

            <div class="mb-2">
                <label>Tədarükçü Adresi</label>
                <input type="text" placeholder="Tədarükçü adresini daxil edin" id="SupAddTb" runat="server" class="form-control mt-1"/>

            </div>

            <div class="mb-2">
                <label>Tədarükçü Elektron Ünvanı</label>
                <input type="text" placeholder="Elektorn poçt ünvanı daxil edin" id="SupEmailTb" runat="server" class="form-control mt-1"/>
            </div>

            <div class="mb-2">
                <label>Tədarükçü Əlaqə Nömrəsi</label>
                <input type="text" placeholder="Əlaqə nömrəsi daxil edin" id="SupPhoneTb" runat="server" class="form-control mt-1"/>
            </div>


              <div class="row">
                <label class="text-danger text-center" id="Errmsg" runat="server"></label>
                <div class="col d-grid">
                    <asp:Button Text="Redaktə et" id="EditBtn" class="btn btn-success btn-block" runat="server" OnClick="EditBtn_Click"/>
                </div>
                <div class="col d-grid">
                    <asp:Button Text="Yadda saxla" id="SaveBtn" class="btn btn-primary btn-block" runat="server" OnClick="SaveBtn_Click"/>
                </div>
                <div class="col d-grid">
                    <asp:Button Text="Sil" id="DeleteBtn" class="btn btn-danger btn-block" runat="server" OnClick="DeleteBtn_Click"/>
                </div>
            </div>

        
        </div>
               <div class="col">
       <h3>Tədarükçü siyahısı</h3>
        <asp:GridView runat="server" ID="SuppliersList" class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="SuppliersList_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
                   </asp:GridView>
   </div>
    </div>





</asp:Content>

