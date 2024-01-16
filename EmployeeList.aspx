<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EmployeeDeps.EmployeeList" %>

<asp:Content ID="EmployeeList" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row" aria-labelledby="elTitle">
            <h1 id="elTitle">List of Employees</h1>
        </section>
        <asp:GridView ID="elGird" runat="server" CssClass="table table-borderless" 
            AutoGenerateColumns="false" OnRowCommand="elGird_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="#" ItemStyle-Width="100">
                    <ItemTemplate>
                        <asp:Label ID="elRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HiddenField ID="hdEmpId" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField DataField="FullName" HeaderText="Name" />
                <%-- TODO: View Employee Departments --%>
               
                <asp:ButtonField Text="Edit" ButtonType="Button" CommandName="EditEmployee" />
                <asp:ButtonField Text="Delete" ButtonType="Button" CommandName="DeleletEmployee" />

            </Columns>

        </asp:GridView>
        <asp:Button ID="elAddEmployee" runat="server" Text="Add New Employee" CssClass="btn btn-primary" OnClick="elAddEmployee_Click"/>
    </main>
</asp:Content>
