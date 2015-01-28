<%@ Page Title="Employee List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EmployeeRegistration.EmployeeList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
     <div>
           <h4>REI Employees List</h4>
        <hr />
    <asp:GridView runat ="server" ID  ="grdEmployees" AllowPaging="true"  width="60%" DataKeyNames ="Id" AllowSorting="true" AutoGenerateColumns ="false">

        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" ></asp:BoundField>
            <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName"></asp:BoundField>
            <asp:BoundField DataField="DateofBirth" HeaderText="Date of Birth" SortExpression="DateofBirth" DataFormatString="{0:MM/dd/yyyy}"></asp:BoundField>
            <asp:BoundField DataField="HireDate" HeaderText="Hire Date" SortExpression="HireDate" DataFormatString ="{0:MM/dd/yyyy}"></asp:BoundField>
        </Columns>
    </asp:GridView>
    </div>
  </asp:Content>
