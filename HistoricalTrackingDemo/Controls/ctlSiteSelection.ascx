<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlSiteSelection.ascx.cs" Inherits="HomeV2_WebForm.Controls.ctlSiteSelection" %>

<div class="navbar navbar-inverse navbar-fixed-top">
    <div class="navbar-inner">
        <div class="container">
            <button type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="brand" href="<% %>">David Russell - Graduate Software Developer</a>
            <div class="nav-collapse collapse">
                <asp:Repeater runat="server" ID="rptSiteSelection">
                    <HeaderTemplate>
                        <ul class="nav">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li>
                            <a target="<%#Eval("Target") %>" href="<%#Eval("URL") %>"><%#Eval("Display") %></a>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</div>
