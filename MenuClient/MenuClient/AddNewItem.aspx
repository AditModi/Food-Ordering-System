<%@ Page Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AddNewItem.aspx.cs" Inherits="MenuClient.AddNewItem" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
  
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
<table style="width:100%; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left;">  
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
<asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button"   
        onclick="btnSave_Click" />  
<asp:Button ID="bntReset" runat="server" Text="Reset" CssClass="button"   
        onclick="bntReset_Click" />  
</td>  
</tr>  
  
</table>  
</asp:Content>  