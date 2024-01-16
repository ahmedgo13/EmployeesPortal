<%@ Page Title="Edit Employee Record" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="EmployeeDeps.EditEmpolyee" %>
<asp:Content ID="EditEmployee" ContentPlaceHolderID="MainContent" runat="server">
    <h1>New Employee Record </h1>
<div class="form-text text-decoration-underline">
    * All fields Are required
</div>
<div>
    <asp:Literal ID="vlError" runat="server" />
</div>
<div>
    <label>- First Name: </label>
    <asp:TextBox ID="FirstName" runat="server" CssClass="input-group-text" />
    <asp:RequiredFieldValidator ID="rqFirstName" runat="server" ControlToValidate="FirstName" CssClass="bg-danger" ErrorMessage="First name is required" Display="Dynamic"/>
</div>
<div>
    <label>- Last Name: </label>
    <asp:TextBox ID="LastName" runat="server" CssClass="input-group-text" />
    <asp:RequiredFieldValidator ID="rqLastName" runat="server" ControlToValidate="LastName" CssClass="bg-danger" ErrorMessage="Last name is required" Display="Dynamic"/>    
</div>
<div>
    <label>- Position Title: </label>
    <asp:TextBox ID="Position" runat="server" CssClass="input-group-text" />
    <asp:RequiredFieldValidator ID="rqPosition" runat="server" ControlToValidate="Position" CssClass="bg-danger" ErrorMessage="Positon title is required" Display="Dynamic"/>    

</div>
<div>
    <label>- Salary (QAR): </label>
    <asp:TextBox ID="Salary" runat="server" CssClass="input-group-text" Display="Dynamic"/>
    <asp:CompareValidator ID="vldSalary" runat="server" ControlToValidate="Salary" Operator="GreaterThan" ValueToCompare="0" Type="Integer" CssClass="bg-danger" ErrorMessage="Salary must be a positive integer value."/>
</div>
<br />
<div>
    <%--<asp:Button ID="btnAddEmployee" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btnAddEmployee_Click"/>--%>
    <%-- Add Return to list page button --%>
</div>
    
</asp:Content>
