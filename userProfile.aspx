<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="Students_Record_Management_System.userProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .rounded-image {
            width: 150px; /* Adjust the width and height as needed */
            height: 150px;
            border-radius: 50%; /* Make the image round */
            object-fit: cover; /* Maintain aspect ratio */
            overflow: hidden; /* Hide overflow */
        }

        .rounded-border {
            display: inline-block;
            padding: 5px 10px;
            background-color: silver; /* Background color */
            border-radius: 10px; /* Adjust the radius as needed */
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
            margin-top: 20px;
        }
    </style>
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body" style="background-color: aliceblue">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <asp:Image ID="UserProfileImage" runat="server" CssClass="rounded-image" />
                                </center>

                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>
                                        <asp:Label ID="StudentName" runat="server"></asp:Label>
                                    </h3>
                                </center>

                            </div>

                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <label class="form-label required-size">Status :</label>
                                <asp:Label ID="StatusLabel" runat="server" CssClass="form-label rounded-border required-size"></asp:Label>
                            </div>
                            <div class="col">
                                <label class="form-label required-size">Grade :</label>
                                <asp:Label ID="gradeLable" runat="server" CssClass="form-label required-size"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-7">
                <div class="boxed-section">
                    <asp:GridView ID="GridView1" class="table table-condensed table-responsive  table-cuz table-bordered" runat="server" AllowPaging="true" AutoGenerateColumns="false" HeaderStyle-BackColor="MidnightBlue" HeaderStyle-ForeColor="White">
                        <Columns>
                            <asp:BoundField DataField="Student_RollNo" HeaderText="Role No" SortExpression="Student_RollNo" />
                            <asp:BoundField DataField="Student_name" HeaderText="Name" SortExpression="Student_name" />
                            <asp:BoundField DataField="Tamil" HeaderText="Tamil" SortExpression="Tamil" />
                            <asp:BoundField DataField="English" HeaderText="English" SortExpression="English" />
                            <asp:BoundField DataField="Maths" HeaderText="Maths" SortExpression="Maths" />
                            <asp:BoundField DataField="Science" HeaderText="Science" SortExpression="Science" />
                            <asp:BoundField DataField="Social" HeaderText="Social" SortExpression="Social" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <center>
                        <div style="height: 10rem; background-color: midnightblue; color: white; width: 16rem; border-radius: 10px; position: center;">
                            <h5>Total Mark</h5>
                            <asp:Label ID="TotalMarksLabel" runat="server" CssClass="form-label display-2"></asp:Label>
                            <!-- You can add the total marks value here -->
                        </div>
                    </center>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

