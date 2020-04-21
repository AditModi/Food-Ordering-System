<%@ Page Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="UpdateItem.aspx.cs" Inherits="MenuClient.UpdateItem" %>


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
</table>  


<table id="panUpdate" runat="server" style="width:100%; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left;">  
<tr>  
<td colspan="2"><asp:Label ID="lblMsg" runat="server" Font-Size="Medium" ></asp:Label></td>  
</tr>
<tr>
<td>Name</td>  
<td><asp:TextBox ID="txtName" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Description</td>  
<td><asp:TextBox ID="txtDesc" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Price</td>  
<td><asp:TextBox ID="txtPrice" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Category</td>  
<td><asp:TextBox ID="txtCg" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Type</td>  
<td>  
<asp:RadioButtonList ID="rbtnTp" runat="server" RepeatColumns="2" CssClass="textBox" >  
    <asp:ListItem Selected="True">Veg</asp:ListItem>  
    <asp:ListItem>Non-veg</asp:ListItem>  
</asp:RadioButtonList>
</td>  
</tr>  
<tr>  
<td>Status</td>  
<td>  
<asp:RadioButtonList ID="rbtnSt" runat="server" RepeatColumns="2" CssClass="textBox" >  
    <asp:ListItem Selected="True">Available</asp:ListItem>  
    <asp:ListItem>Not Available</asp:ListItem>  
</asp:RadioButtonList>
</td>  
</tr>  

<tr>  
<td colspan="2">  
<asp:Button ID="bntUpdated" runat="server" Text="Update" CssClass="button" onclick="bntUpdated_Click"    
         />  
<asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" onclick="btnCancel_Click"   
        />  
</td>  
</tr>  
  
</table>  
</asp:Content>  