<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Views.Admin.Home" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>

        .box{
            background-color:mediumpurple;
            border:solid 1px purple;
            width:200px;
            height:200px;
            margin:20px 0 0 50px;
            display: flex;
            flex-direction:column;
            justify-content: center;
            align-items: center;
            row-gap:20px;
            
        }

        .BoxText{
            color:white;
            font-size:24px;
        }

        label{
            font-size:36px;
            color:white;

        }

    </style>

</asp:Content>





<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

                        

<div class="d-flex justify-content-center align-items-center h-100">

        <div  class="box" > 
            <i class="fa-solid fa-boxes-stacked fa-2xl" style="color: #ffffff;"></i>
        <asp:LinkButton ID="ItemsBtn" class="BoxText" href="Items.aspx" runat="server">Items</asp:LinkButton>
            <label class=" text-center" id="ItemsCnt" runat="server"></label>
    </div>

    <div  class="box" > 
        <i class="fa-solid fa-users fa-2xl" style="color: #ffffff;"></i>
        <asp:LinkButton ID="EmployeeBtn" class="BoxText" href="Employee.aspx" runat="server" OnClick="EmployeeBtn_Click">Employees</asp:LinkButton>
        <label class=" text-center" id="EmployeeCnt" runat="server"></label>
    </div>

    <div  class="box" > 
         <i class="fa-solid fa-table fa-2xl" style="color: #ffffff;"></i>
        <asp:LinkButton ID="CategoriesBtn" class="BoxText" href="Categories.aspx" runat="server" OnClick="CategoriesBtn_Click">Categories</asp:LinkButton>
        <label class=" text-center" id="CategoriesCnt" runat="server"></label>
    </div>

    <div  class="box" > 
       <i class="fa-solid fa-truck-field fa-2xl" style="color: #ffffff;"></i>
        <asp:LinkButton ID="SupllierBtn" class="BoxText" href="Supplier.aspx" runat="server" OnClick="SupllierBtn_Click">Suppliers</asp:LinkButton>
        <label class=" text-center" id="SuppliersCnt" runat="server"></label>
    </div>
</div>



</asp:Content>
