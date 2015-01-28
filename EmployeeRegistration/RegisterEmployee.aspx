<%@ Page Title="New Employee" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registeraspx.cs" Inherits="EmployeeRegistration.RegisterEmployee" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
     <script type="text/javascript">
    $(function() {
        $("#<%=txtBirthDate.ClientID%>").datepicker({
            changeYear: true,
            yearRange: "-70:+0"
        });
        $("#<%=txtHireDate.ClientID%>").datepicker(
            {
                changeYear: true,
                yearRange: "-70:+0"
            });
    });    
    </script>
  
  <div class="form-horizontal">
        <h4>Register New </h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />       
        <div class="form-group">
             <asp:Label runat="server"  ID="lblSuccess" CssClass="text-success"></asp:Label>
            <br/>
            <asp:Label runat="server" AssociatedControlID="txtFirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFirstName"
                    CssClass="text-danger" ErrorMessage="First name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtLastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtLastName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtLastName"
                    CssClass="text-danger" ErrorMessage="Last Name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtBirthDate" CssClass="col-md-2 control-label">Date of birth</asp:Label>
            <div class="col-md-10">
         
                <asp:TextBox runat="server" ID="txtBirthDate"  CssClass="form-control" />
           <%--     <asp:RequiredFieldValidator runat="server" ControlToValidate="txtBirthDate"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="Date of birth field is required." />--%>
               
            </div>
        </div>

       <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtBirthDate" CssClass="col-md-2 control-label">Hire Date</asp:Label>
            <div class="col-md-10">
         
                <asp:TextBox runat="server" ID="txtHireDate"  CssClass="form-control" />
             <%--   <asp:RequiredFieldValidator runat="server" ControlToValidate="txtHireDate"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="Hire Date field is required." />--%>
               
            </div>
        </div>
        <div class="form-group">
             
            <div class="col-md-offset-2 col-md-10">
                 <asp:Button runat="server" OnClick="Clear_Click" Text="Clear" CssClass="btn btn-default"  ID ="btnClear" CausesValidation ="false"/>
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default"  ID ="btnRegister" />
            
               
            </div>
          
            
        </div>
    </div>
</asp:Content>
