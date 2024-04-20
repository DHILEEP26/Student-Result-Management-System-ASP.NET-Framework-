<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Students_Record_Management_System._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="card mb-3" style="border:none">
    <br />
  <div class="row g-0">
    <div class="col-md-8"> 
      <div class="card-body">
        <h2 class="card-title"  style="font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Welcome </h2>
        <div class="row mb-3">
          <div class="col-md-6">
            <div class="card">
                <img src="images/pexels-pixabay-46798.jpg"  class="card-img-top" style="height:350px"/>
              <div class="card-body">
                <h5 class="card-title">SPORT'S CLUB</h5>
              </div>
            </div>
          </div>
          <div class="col-md-6">
            <div class="card">
                <img src="images/pexels-rafael-cosquiere-2041540.jpg" class="card-img-top" style="height:350px" />
              <div class="card-body">
                <h5 class="card-title">LIBRARIES</h5>
              </div>
            </div>
          </div>
        </div>
        
        <div class="row">
          <div class="col-md-6">
            <div class="card">
                <img src="images/pexels-vishnu-r-nair-1105666.jpg"class="card-img-top" style="height:300px" />
              <div class="card-body">
                <h5 class="card-title">CULTURALS</h5>
              </div>
            </div>
          </div>
          <div class="col-md-6">
            <div class="card">
                <img src="images/pexels-pramod-tiwari-13316037.jpg" class="card-img-top" style="height:300px"  />
              <div class="card-body" style="background-color:floralwhite">
                <h5 class="card-title">NCC CLUB</h5>
              </div>
            </div>
          </div>
        </div>
        
      </div>


    </div>

    <div class="col-md-4"  style="background-color:gainsboro"> 
      <div class="card-body">
        <h2 class="card-title" style="font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Explore Our Clubs</h2>
          <br />
        <p class="card-text" style="font-family:'Century Gothic';font-size:large">
          <strong>Sports:</strong> Our sports club provides students with opportunities to engage in various physical activities, including team sports, individual sports, and fitness programs. Through participation in sports, students learn important values such as teamwork, discipline, and sportsmanship.
        </p>
          <br />
        <p class="card-text"  style="font-family:'Century Gothic';font-size:large">
          <strong>Libraries:</strong> Our libraries are vibrant hubs of learning, providing students with access to a wide range of books, resources, and digital materials. From classic literature to contemporary research, our libraries support and enhance the academic journey of our students.
        </p>
          <br />
        <p class="card-text"  style="font-family:'Century Gothic';font-size:large">
          <strong>Culturals:</strong> Our cultural club celebrates diversity and creativity, offering students opportunities to explore and showcase their talents in various cultural activities such as music, dance, drama, and art. Through participation in cultural events, students develop a deeper appreciation for different cultures and traditions.
        </p>
          <br />
        <p class="card-text"  style="font-family:'Century Gothic';font-size:large">
          <strong>NCC Club:</strong> Our NCC (National Cadet Corps) club instills qualities of leadership, discipline, and patriotism in students. Through various training programs and activities, students develop essential life skills and a sense of responsibility towards the nation.
        </p>
      </div>
    </div>
  </div>
</div>

</asp:Content>



