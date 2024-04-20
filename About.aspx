<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Students_Record_Management_System.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid" style="background-image: url(images/pexels-rodrigo-souza-2531709.jpg)">
        <br />
        <div class="row">
            <div class="col-md-3">
                <div class="box-container">
                    <div class="rectangle-container">
                        <div class="rectangle total-students">
                            <img src="images/group-of-people%20(1).png" class="rectangle-image" />
                            <asp:Label ID="TotalStudentsCountLabel" runat="server" CssClass="count text-white display-4"></asp:Label>
                        </div>
                        <br />
                        <p class="label">TOTAL STUDENTS</p>
                    </div>
                    <div class="rectangle-container">
                        <div class="rectangle pass-students">
                            <img src="images/checked.png" class="rectangle-image" />
                            <asp:Label ID="PassStudentsCountLabel" runat="server" CssClass="count text-white display-4"></asp:Label>
                        </div>
                        <br />
                        <p class="label">PASS STUDENTS</p>
                    </div>
                    <div class="rectangle-container">
                        <div class="rectangle fail-students">
                            <img src="images/x-button.png" class="rectangle-image" />
                            <asp:Label ID="FailStudentsCountLabel" runat="server" CssClass="count text-white display-4"></asp:Label>
                        </div>
                        <br />
                        <p class="label">FAIL STUDENTS</p>
                    </div>
                </div>
                <br />
            </div>
            <div class="col-md-9">

                <div class="box-container-circle">
                    
                                    <div class="rectangle-container-title">
                    
                    <h2 style="font-family: Arial, Helvetica, sans-serif;color:midnightblue">SUBJECTS AVERAGE</h2>
                        
                </div>
                        
                    <div class="circle-container" style="justify-content: space-between; margin-bottom: 50px">
                        <div class="circle-wrapper">
                            <div class="circle">
                                <asp:Label ID="TamilAverage" runat="server" CssClass="circle-value"></asp:Label>
                            </div>
                            <div class="circle-title">
                                <asp:Label ID="TamilTitle" runat="server" Text="T A M I L"></asp:Label>
                            </div>

                        </div>
                        <div class="circle-wrapper">
                            <div class="circle">
                                <asp:Label ID="EngAverage" runat="server" CssClass="circle-value"></asp:Label>
                            </div>
                            <div class="circle-title">
                                <asp:Label ID="EngTitle" runat="server" Text="E N G L I S H"></asp:Label>
                            </div>
                        </div>
                        <div class="circle-wrapper">
                            <div class="circle">
                                <asp:Label ID="MathsAvg" runat="server" CssClass="circle-value"></asp:Label>
                            </div>
                            <div class="circle-title">
                                <asp:Label ID="MathsTitle" runat="server" Text="M A T H S"></asp:Label>
                            </div>

                        </div>
                        <div class="circle-wrapper">
                            <div class="circle">
                                <asp:Label ID="ScienceAvg" runat="server" CssClass="circle-value"></asp:Label>
                            </div>
                            <div class="circle-title">
                                <asp:Label ID="SciTitle" runat="server" Text="S C I E N C E"></asp:Label>
                            </div>
                        </div>
                        <div class="circle-wrapper">
                            <div class="circle">
                                <asp:Label ID="SociAvg" runat="server" CssClass="circle-value"></asp:Label>
                            </div>
                            <div class="circle-title">
                                <asp:Label ID="SociTitle" runat="server" Text="S O C I A L"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div>
                    <asp:GridView ID="GridView1" class="table table-condensed table-responsive  table-cuz table-bordered" runat="server" AllowPaging="true" AutoGenerateColumns="false" HeaderStyle-BackColor="#007bff" HeaderStyle-ForeColor="White" BackColor="Transparent"  BorderStyle="Dashed">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="STAFF ID" SortExpression="ID" ItemStyle-ForeColor="White"  ItemStyle-Font-Size="Larger" ItemStyle-Font-Bold="true"/>
                            <asp:BoundField DataField="Teacher_Name" HeaderText="STAFF NAME" SortExpression="Teacher_Name" ItemStyle-ForeColor="White"  ItemStyle-Font-Size="Larger" ItemStyle-Font-Bold="true"/>
                            <asp:BoundField DataField="Subject_Taken" HeaderText="SUBJECT" SortExpression="Subject_Taken" ItemStyle-ForeColor="White" ItemStyle-Font-Size="Larger" ItemStyle-Font-Bold="true"/>
                        </Columns>
                       
                    </asp:GridView>

                </div>

        </div>
    </div>
    </div>

    <style>
        /* Container Styles */
        .box-container {
            border: 2px solid #dee2e6;
            border-radius: 25px;
            padding: 25px;
        }

        /* Rectangle Styles */
        .rectangle-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin-bottom: 20px;
        }

        .rectangle {
            width: 250px;
            height: 100px;
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 20px;
            font-weight: bold;
            background-color: transparent; /* Transparent background */
            border: 4px solid; /* Border style */
            box-shadow: 0 8px 16px rgba(255, 255, 255, 0.2);
            border-radius: 15px;
        }

        .rectangle-image {
            position: absolute;
            left: 5px;
            max-width: 70px;
            max-height: 70px;
        }

        .count {
            font-size: 2em;
        }

        .label {
            font-size: x-large;
            color: white;
            text-align: center;
            font-family: 'Century Gothic';
        }

        .total-students {
            border-color: #007bff;
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif
        }

        .pass-students {
            border-color: #28a745;
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif
        }


        .fail-students {
            border-color: #dc3545;
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif
        }

        .subject-rectangle {
            background-color: #007bff;
        }

        .box-container-circle {
            border-radius: 30px;
            padding: 15px;
            height:20rem;
            background-color: white
        }

        .circle-container {
            display: flex;
        }

        /* Circle styles */
        .circle {
            width: 128px;
            height: 128px;
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 30px;
            margin: 10px;
            background-image: url(images/graph1.png)
        }



        .circle-value {
            color: midnightblue;
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }

        .circle-wrapper {
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .circle-title {
            /* Center-align the text */
            text-align: center;
            font-size: x-large; /* Adjust the font size as needed */
            margin-top: 20px; /* Add some space between the circle and the title */
            color: midnightblue;
            font-family: Arial, Helvetica, sans-serif
        }

        .rectangle-container-title {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin-bottom: 20px;
        }

        .rectangle-title {
            width: 200px;
            height: 60px;
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 20px;
            font-weight: bold;
            background-color: white; /* Transparent background */
            border: 4px solid; /* Border style */
            box-shadow: 0 8px 16px rgba(255, 255, 255, 0.2);
            border-radius: 15px;
        }
    </style>

</asp:Content>

