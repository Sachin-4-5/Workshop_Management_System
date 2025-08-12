<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WorkshopManagementSystem.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <h2 class="mb-4">User Registration</h2>
            <div class="card shadow-sm">
                <div class="card-body">
                    <div class="mb-3">
                        <label for="txtFullName" class="form-label">Full Name</label>
                        <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtEmail" class="form-label">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtPassword" class="form-label">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="ddlRole" class="form-label">Role</label>
                        <asp:DropDownList ID="ddlRole" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                    <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary w-100" OnClick="btnRegister_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
