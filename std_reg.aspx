<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="std_reg.aspx.cs" Inherits="Student_Registration.std_reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <section id="main-content">
          <section class="wrapper">
              <div class="row">
                  <div class="col-lg-12">
                      <section class="panel">
                          <header class="panel-heading">
                              <div class="col-md-4 col-md-offset-4">
                                  <h1>Student Registration</h1>
                              </div>
                          
                          </header>
                          <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                          <asp:Label runat="server" AssociatedControlID="txtStdname"><b>Student Name</b></asp:Label><br />
                                          <asp:TextBox runat="server" required="required" Enabled="True" name="BrandName" ID="txtStdname" class="form-control input-sm" placeholder="Student Name"></asp:TextBox>

                                       </div> 
                                   </div>
                                        <div class="col-md-4 col-md-offset-1">
                                            <div class="form-group">
                                             <asp:Label runat="server" AssociatedControlID="txtfname"><b>Father Name</b></asp:Label><br />
                                              <asp:TextBox runat="server" required="required" Enabled="True" name="BrandName" ID="txtfname" class="form-control input-sm" placeholder="Father Name"></asp:TextBox>
                                           </div>
                                        </div>
                                   </div>
                              
                               <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                       <div class="form-group">
                                         <asp:Label runat="server" AssociatedControlID="txtdob"><b>DOB</b></asp:Label><br />
                                          <asp:TextBox runat="server" required="required" TextMode="Date" Enabled="True" name="BrandName" ID="txtdob" class="form-control input-sm" placeholder="DOB "></asp:TextBox>
                                       </div> 
                                  </div>
                                        <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtprogram" ><b>Program</b></asp:Label><br />
                                         <asp:TextBox runat="server" required="required"  Enabled="True" name="BrandName" ID="txtprogram" class="form-control input-sm" placeholder="Program"></asp:TextBox>    
                                    </div>
                                    </div>
                                   </div>
                               <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                  <div class="form-group">
                                       <asp:Label runat="server" AssociatedControlID="txtregion"><b>Region</b></asp:Label><br />
                                      <asp:DropDownList ID="txtregion" CssClass="form-control input-sm" runat="server" >
                                          <asp:ListItem Text="Pakistan" />
                                          <asp:ListItem Text="Iran" />
                                          <asp:ListItem Text="Iraq" />
                                          <asp:ListItem Text="Turkey" />
                                          <asp:ListItem Text="India" />
                                          <asp:ListItem Text="China" />
                                      </asp:DropDownList>
                                       </div> 
                                  </div>
                                        <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                      <asp:Label runat="server" AssociatedControlID="txtaddress"><b>Address</b></asp:Label><br />
                                       <asp:TextBox runat="server" required="required" Enabled="True" name="BrandName" ID="txtaddress" class="form-control input-sm" placeholder="  Address "></asp:TextBox>

                                        
                                  </div>
                                    </div>
                                   </div>


                              <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                       <div class="form-group">
                                         <asp:Label runat="server" AssociatedControlID="txtcell"><b>Cell No</b></asp:Label><br />
                                          <asp:TextBox runat="server" required="required" TextMode="Number" Enabled="True" name="BrandName" ID="txtcell" class="form-control input-sm" placeholder="Cell Number "></asp:TextBox>
                                       </div> 
                                  </div>
                                        <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtgender" ><b>Gender</b></asp:Label><br />
                                        <asp:RadioButtonList CssClass="form-group" ID="txtgender" runat="server">
                                            <asp:ListItem Text="Male" />
                                            <asp:ListItem Text="Female" />
                                        </asp:RadioButtonList>

                                    </div>
                                    </div>
                                   </div>

                               <div class="row">
                                    <div class="col-md-10 col-md-offset-1">
                                  <div class="form-group">
                                      <asp:Button Text="Save" ID="btnsave" OnClick="btnsave_Click"  CssClass="btn btn-primary btn-lg" Width="220px" runat="server" />
                                      <asp:Button Text="Update" ID="btnupdate"  OnClick="btnupdate_Click" CssClass="btn btn-primary btn-lg" Width="220px" runat="server" />
                                     <asp:Button Text="Delete" ID="btndlt"  OnClick="btndlt_Click"  CssClass="btn btn-danger btn-lg" Width="220px" runat="server" />
                                      <asp:Label Text="" ForeColor="Green" Font-Bold="true" ID="lblmessage" CssClass="label label-success" runat="server" />
                                       </div> 
                                  </div>
                                  
                                   </div>
                              <div class="row">
                                  <div class="col-md-10 col-md-offset-1">
                                      <div class="form-group">
                                          <div class="table-responsive">
                                              <asp:GridView ID="gv"  Width="100%" AutoGenerateSelectButton="true" SelectedRowStyle-BackColor="Green" OnSelectedIndexChanged="gv_SelectedIndexChanged" runat="server"></asp:GridView>
                                          </div>
                                      </div>
                                  </div>
                              </div>
                                    
                               </div>
                      </section>
              </div>
            </div>
         </section>
     </section>      


</asp:Content>
