<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlSiteSelection.ascx.cs" Inherits="HomeV2_WebForm.Controls.ctlSiteSelection" %>

<div id="div-site-selection">
        <asp:Repeater runat="server" ID="rptSiteSelection">
            <HeaderTemplate>
                <ul id="site-selection">
            </HeaderTemplate>
            <ItemTemplate>
                <li class="site-selection-item">
                    <a class="link" target="_parent" href="<%#Eval("URL") %>"><%#Eval("Display") %></a>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
</div>