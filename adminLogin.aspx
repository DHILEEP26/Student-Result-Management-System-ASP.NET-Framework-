<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="Students_Record_Management_System.adminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color:darkgray">
    <div class="container" style="width: 60rem">
        <br />
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="images/settings.png" />
                                </center>

                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>

                        </div>
                        <div class="row">
                            <div class="col">
                                <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Admin ID :</label>

                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" Width="100%" Height="40px" required="@"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="ID is required" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Password :</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" Width="100%" Height="40px" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is required" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                                <div class="form-group">
                                    <asp:Button CssClass="btn btn-success btn-lg" ID="Button1" runat="server" Text="Login" Width="100%" OnClick="Button1_Click" />

                                </div>
                            </div>

                        </div>
                    </div>

                </div>
                <div>
                    <a href="Default.aspx" style="color:red;font-size:larger"><< Back to Home</a>
                </div>

            </div>

        </div>
    </div>
        <br />
        </div>
</asp:Content>
