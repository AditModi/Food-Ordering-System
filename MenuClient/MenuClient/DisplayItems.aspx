<%@ Page Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="DisplayItems.aspx.cs" Inherits="MenuClient.DisplayItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
  
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdItems" runat="server">  
       <AlternatingRowStyle BackColor="White" />  
       <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />  
   </asp:GridView> 
</asp:Content>