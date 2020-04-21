<%@ Page Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="DeleteItem.aspx.cs" Inherits="MenuClient.DeleteItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
  
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  


<table id="panSearch" runat="server" style="width:inherit; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left; padding:10px; padding-bottom:20px;" >  
<tr>  
<td>Enter Item ID</td>  
<td><asp:TextBox ID="txtSearch" runat="server" CssClass="textBox" Placeholder="Enter Item ID e.g 201" ></asp:TextBox></td>  
<td><asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button"   
        onclick="btnSearch_Click" ></asp:Button></td>  
</tr>  
<tr>  
  
<td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" ></asp:Label></td></tr>
<tr>
<td colspan="3"><asp:Label ID="lblResult" runat="server" Font-Size="Medium" ></asp:Label></td>
</tr>
</table>

<asp:GridView ID="grdItems" runat="server">  
       <AlternatingRowStyle BackColor="White" />  
       <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />  
</asp:GridView>
<asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button" onclick="btnDelete_Click"    
         />  
<asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" onclick="btnCancel_Click"   
        />  
    
</asp:Content>