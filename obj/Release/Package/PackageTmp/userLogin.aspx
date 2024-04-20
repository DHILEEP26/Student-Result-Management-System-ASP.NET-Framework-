<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="Students_Record_Management_System.userLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color:darkgray">
    <div class="container" style="width: 70rem">
        <br />
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="images/graduating-student (1).png" />
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
                                <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Student ID :</label>

                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" Width="100%" Height="40px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Student ID is required" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
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
                            </div>

                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Button CssClass="btn btn-success btn-lg" ID="Button1" runat="server" Text="Login" Width="100%" OnClick="Button1_Click" />

                        </div>
                        <br />
                        <div class="form-group">
                            <a href="userSignup.aspx">
                                <input class="btn  btn-lg" id="Button2" type="button" value="Sign Up" style="width: 100%;background-color:mediumblue;color:white" /></a>

                        </div>

                    </div>

                </div>
                <div>
                    <a href="Default.aspx" style="color:red"><< Back to Home</a>
                </div>

            </div>

        </div>
    </div>
    <br />
        </div>
</asp:Content>
