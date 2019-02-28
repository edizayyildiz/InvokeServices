<%@ Page Title="Call Services" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CallService.aspx.cs" Inherits="InvokeServices.CallService" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Call Some Services.</p>
    <div class="form-group">
        <label for="formGroupExampleInput">WCF(Windows Communication Foundation)</label>
        <asp:TextBox ID="txtWCFId" class="form-control" runat="server" placeholder="WCF bir SOA framework'üdür" />
        <asp:TextBox ID="txtWCFTitle" class="form-control" runat="server" />
        <asp:TextBox ID="txtWCFDescription" class="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="formGroupExampleInput2">XML Service</label>
        <asp:TextBox ID="txtXMLId" class="form-control" runat="server" />
        <asp:TextBox ID="txtXMLTitle" class="form-control" runat="server" />
        <asp:TextBox ID="txtXMLDescription" class="form-control" runat="server" />
    </div>
    <div class="btn-group">
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="WCF" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="XML" OnClick="Button2_Click" />
    </div>
</asp:Content>
