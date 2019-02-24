<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftMenuControl.ascx.cs" Inherits="WebApplication1.LeftMenuControl" %>
<asp:DataList ID="dlMenu" runat="server" Width="250px">
	<ItemTemplate>
		<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "Category.aspx?IDCAT="+Eval("ID") %>' Text='<%# Eval("NAME") %>'></asp:HyperLink>
	</ItemTemplate>
</asp:DataList>

