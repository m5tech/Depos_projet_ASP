<%@ Page Title="" Language="C#" MasterPageFile="~/page_maitre.Master" AutoEventWireup="true" CodeBehind="Choix_client_ou_entreprise.aspx.cs" Inherits="ASP_Projet_MVC.Choix_client_ou_entreprise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content=""> 
  <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/shop-item.css" rel="stylesheet">
        <br />
        <br />
        <br />
    <h1 id="question">Vous Etes Entreprise ou Particulier?</h1>
        <br />
        <br />
        <br />
    <div id="RB">

        <asp:RadioButton ID="RadioButton1" value="Entreprise" class="form-radio" runat="server" />
        <asp:RadioButton ID="RadioButton2" value="Particulier" class="form-radio" runat="server" />

        <br />
        <br />  
                        <button type="button" id="confirmer">Confirmer</button>
    </div>


</asp:Content>
