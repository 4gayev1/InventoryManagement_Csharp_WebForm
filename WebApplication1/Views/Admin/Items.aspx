<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="WebApplication1.Views.Admin.Items" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="row" style="height:20px;background-color:crimson;">

    </div>
    <div class="row">
        <div class="col-md-3">
            <h4>Items Details</h4>

            <div class="mb-2">
                <label></label>
                <input type="text" placeholder="Enter Item Name" id="ItemNameTb" runat="server" class="form-control mt-1"/>
            </div>

            <div class="mb-2">
                <label>Supplier</label>
                <asp:DropDownList runat="server" id="SupplierTb" class="form-control mt-1" ></asp:DropDownList>            

            </div>

            <div class="mb-2">
                <label>Quantity</label>
                <input type="text" placeholder="Enter Quantity" id="QuantityTb" runat="server" class="form-control mt-1"/>
            </div>

            <div class="mb-2">
                <label>Minimum Level</label>
                <input type="text" placeholder="Enter Minimum Level" id="MinimumLevelTb" runat="server" class="form-control mt-1"/>
            </div>

            <div class="mb-2">
                <label>Item Category</label>
                <asp:DropDownList runat="server" id="ItemCategoryTb" class="form-control mt-1"></asp:DropDownList>            
            </div>



            <div class="row">
                <label class="text-danger text-center" id="Errmsg" runat="server"></label>
                <div class="col d-grid">
                    <asp:Button Text="Edit" id="EditBtn" class="btn btn-success btn-block" runat="server" OnClick="EditBtn_Click"/>
                </div>
                <div class="col d-grid">
                    <asp:Button Text="Save" id="SaveBtn" class="btn btn-primary btn-block" runat="server" OnClick="SaveBtn_Click"/>
                </div>
                <div class="col d-grid">
                    <asp:Button Text="Delete" id="DeleteBtn" class="btn btn-danger btn-block" runat="server" OnClick="DeleteBtn_Click"/>
                </div>
            </div>
            
        </div>
           <div class="col">
       <h3>Items List</h3>
        <asp:GridView runat="server" id="ItemsList" class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Unnamed3_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
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
