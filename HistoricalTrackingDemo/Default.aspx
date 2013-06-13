<%@ Page Title="Development Projects by Dave Russell" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HistoricalTrackingDemo._Default" %>

<%@ Register TagPrefix="ctl" TagName="HistoricalDataViewer" Src="~/Controls/ctlHistoricalDataViewer.ascx" %>
<%@ Register TagPrefix="ctl" TagName="FilteredHistoricalDataViewer" Src="~/Controls/ctlFilteredHistoricalDataViewer.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container page-container">

        <p>
            A demo of a module from my Final Year Project. Historical tracking data collected from smartphones is displayed on a map. The map can be filtered to show a single session; try #835.
        </p>
        <p>
            Code can be found at&nbsp;<a href="https://github.com/daveajrussell/HistoricalTrackingDemo" target="_blank">GitHub</a>.
        </p>

        <ctl:HistoricalDataViewer runat="server" ID="ctlHistoricalDataViewer" Visible="true" />
        <ctl:FilteredHistoricalDataViewer runat="server" ID="ctlFilteredHistoricalDataViewer" Visible="false" />
    </div>
</asp:Content>
