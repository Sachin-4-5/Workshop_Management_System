<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WorkshopManagementSystem.UI.Default" %>

<asp:Content ID="C1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Available Workshops</h3>
    <asp:Repeater ID="rptWorkshops" runat="server">
        <ItemTemplate>
            <div class="card mb-3">
                <div class="card-body">
                    <h5 class="card-title"><%# Eval("Title") %> - <%# Eval("Date", "{0:yyyy-MM-dd}") %></h5>
                    <p class="card-text"><%# Eval("Description") %></p>
                    <asp:Button runat="server" Text="Register" CssClass="btn btn-primary"
                                CommandName="Register" CommandArgument='<%# Eval("WorkshopID") %>'
                                OnCommand="rptWorkshops_Command" />
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
