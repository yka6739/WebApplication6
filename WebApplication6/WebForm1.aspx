<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



<%--<form>
<div>
<table>
<tr>
<td>
Enter Username:
</td>
<td>
    
<asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
</td>
<td>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />
</td>
</tr>
<tr>
<td align="right">
First Name:
</td>
<td>
<asp:Label ID="lblfname" runat="server" Font-Bold="true"></asp:Label> 
</td>
</tr>
<tr>
<td align="right">
Last Name:
</td>
<td>
<asp:Label ID="lbllname" runat="server" Font-Bold="true" ></asp:Label> 
</td>
</tr>
<tr>
<td align="right">
Email:
</td>
<td>
<asp:Label ID="lblemail" runat="server" Font-Bold="true"></asp:Label> 
</td>
</tr>
</table>
</div>
</form>--%>




    <asp:GridView ID="GridView1" runat="server">

    </asp:GridView>




</asp:Content>