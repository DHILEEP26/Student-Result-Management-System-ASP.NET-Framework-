<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminWork.aspx.cs" Inherits="Students_Record_Management_System.adminWork" EnableViewState="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .rounded-border {
            display: inline-block;
            padding: 5px 10px;
            background-color: silver;
            border-radius: 10px;
        }

        .required-size {
            font-size: x-large;
            font-family: 'Century Gothic';
        }

        .table-cuz {
            border-radius: 15px;
            font-family: 'Century Gothic';
            font-size: x-large;
        }

        .boxed-section {
            border-radius: 10px;
            padding: 20px;
        }

        .boxed-section-card {
            border-radius: 10px;
            padding: 20px;
        }
    </style>
    <div class="container-fluid" style="background-image: url(images/joshua-woroniecki-TspYRqQrErc-unsplash.jpg)">
        <br />
        <div class="row">
            <div class="col-md-5">
                <div class="boxed-section-card">
                    <div class="card" style="background-color:transparent; color:aliceblue" >
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <img style="width:100px" src="images/edit.png" />
                                    </center>

                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h3>  Edit Box
                                        </h3>
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

                                    <asp:TextBox CssClass="form-control" ID="StudentId" runat="server" Width="100%" Height="40px" required=""></asp:TextBox>
                   
                                </div>
                                <div class="col">
                                    <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Student Name :</label>

                                    <asp:TextBox CssClass="form-control" ID="StudentName" runat="server" Width="100%" Height="40px" required=""></asp:TextBox>
                                </div>

                            </div>
                            <br />
                            <div class="row">
                                <div class="col">
                                    <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Tamil Mark :</label>

                                    <asp:TextBox CssClass="form-control" ID="TamilMark" runat="server" Width="100%" Height="40px" required=""></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">English Mark :</label>

                                    <asp:TextBox CssClass="form-control" ID="EnglishMark" runat="server" Width="100%" Height="40px" required=""></asp:TextBox>
                                </div>

                            </div>
                            <br />
                            <div class="row">
                                <div class="col">
                                    <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Maths Mark :</label>

                                    <asp:TextBox CssClass="form-control" ID="MathsMark" runat="server" Width="100%" Height="40px" required=""></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Science Mark :</label>

                                    <asp:TextBox CssClass="form-control" ID="ScienceMark" runat="server" Width="100%" Height="40px" required=""></asp:TextBox>
                                </div>

                            </div>
                            <br />

                            <div class="row">
                                <div class="col-md-6">
                                    <label class="form-label" style="font-family: 'Century Gothic'; font-size: large">Social Mark :</label>

                                    <asp:TextBox CssClass="form-control" ID="SocialMark" runat="server" Width="100%" Height="40px"></asp:TextBox>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-md-7">
                <div class="boxed-section">
                    <asp:GridView ID="GridView1" runat="server" class="table table-condensed table-responsive table-cuz table-bordered" PageSize="7" OnPageIndexChanging="GVStudentList_PageIndexChanging" AllowPaging="true" AutoGenerateColumns="false" HeaderStyle-BackColor="MidnightBlue" HeaderStyle-ForeColor="White"  BackColor="White" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Student_RollNo" EnableViewState="true" SelectionMode="FullRow">
                        <Columns>
                            <asp:BoundField DataField="Student_RollNo" HeaderText="Role No" SortExpression="Student_RollNo" />
                            <asp:BoundField DataField="Student_name" HeaderText="Name" SortExpression="Student_name" />
                            <asp:BoundField DataField="Tamil" HeaderText="Tamil" SortExpression="Tamil" />
                            <asp:BoundField DataField="English" HeaderText="English" SortExpression="English" />
                            <asp:BoundField DataField="Maths" HeaderText="Maths" SortExpression="Maths" />
                            <asp:BoundField DataField="Science" HeaderText="Science" SortExpression="Science" />
                            <asp:BoundField DataField="Social" HeaderText="Social" SortExpression="Social" />
                            <asp:CommandField HeaderText="Edit" ShowSelectButton="true" />
                        </Columns>
                    </asp:GridView>



                </div>
                <div class="boxed-section">
                    <div class="row">
                        <div class="col-3">
                            <asp:Button CssClass="btn btn-info btn-lg" ID="Button1" runat="server" Text="SAVE" Width="100%" OnClick="Button1_Click" />

                        </div>
                        <div class="col-3">
                            <asp:Button CssClass="btn btn-success btn-lg" ID="Button2" runat="server" Text="UPDATE" Width="100%" OnClick="Button2_Click" />

                        </div>
                        <div class="col-3">
                            <asp:Button CssClass="btn btn-danger btn-lg" ID="Button3" runat="server" Text="DELETE" Width="100%" OnClick="Button3_Click" />

                        </div>
                        <div class="col-3">
                            <asp:Button CssClass="btn btn-info btn-lg" ID="Button4" runat="server" Text="CLEAR" Width="100%" OnClick="Button4_Click" />

                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
