<%@ Page Title="Projects" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HistoricalTrackingDemo._Default" %>

<%@ Register TagPrefix="ctl" TagName="HistoricalDataViewer" Src="~/Controls/ctlHistoricalDataViewer.ascx" %>
<%@ Register TagPrefix="ctl" TagName="FilteredHistoricalDataViewer" Src="~/Controls/ctlFilteredHistoricalDataViewer.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <ctl:HistoricalDataViewer runat="server" ID="ctlHistoricalDataViewer" Visible="true" />
    <ctl:FilteredHistoricalDataViewer runat="server" ID="ctlFilteredHistoricalDataViewer" Visible="false" />
</asp:Content>