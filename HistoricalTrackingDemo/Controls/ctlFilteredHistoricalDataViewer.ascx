<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlFilteredHistoricalDataViewer.ascx.cs" Inherits="HistoricalTrackingDemo.Controls.ctlFilteredHistoricalDataViewer" %>

<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false&language=en&key=AIzaSyBwj3Xpcnn2FB0zuqe8T4Zs3sxAtozOXNw"></script>

<script type="text/javascript">

    $(function () {
        var pos = new google.maps.LatLng('<%= this.DataSource.First().Coordinates.First().Latitude %>', '<%= this.DataSource.First().Coordinates.First().Longitude %>');

        var mapOpts = {
            zoom: 13,
            center: pos,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        var map = new google.maps.Map(document.getElementById('map'), mapOpts);

        <% foreach (var period in this.DataSource) { %>

                var path = [];

                <% foreach (var item in period.Coordinates) { %>
                        var latlng = new google.maps.LatLng('<%= item.Latitude %>', '<%= item.Longitude %>');
                        path.push(latlng);
                <% } %>

        $('#key').find('#<%= period.SessionID%>').css('background-color', '#000000');

        var lineSymbol = {
            path: google.maps.SymbolPath.FORWARD_CLOSED_ARROW,
            scale: 3,
            strokeColor: '#CC0000'
        };

        poly = new google.maps.Polyline({
            path: path,
            strokeColor: '#000000',
            strokeOpacity: 1.0,
            icons: [{
                icon: lineSymbol,
                offset: '0'
            }]
        });

        poly.setMap(map);

        <% } %>

    });

    function animateCircle() {
        var count = 0;
        offsetId = window.setInterval(function () {
            count = (count + 1) % 200;

            var icons = poly.get('icons');
            icons[0].offset = (count / 2) + '%';
            poly.set('icons', icons);
        }, 50);
    }

    window.setTimeout(animateCircle, 1000);

</script>

<div id="home" class="segment-active">
    <div class="section">
        <div id="map">
        </div>

        <div id="key">
            <asp:Repeater runat="server" ID="rptSessionKeys">
                <ItemTemplate>
                    <span id='<%#Eval("SessionID") %>' style="width:10px;height:10px;display:inline-block"></span> 
                    =
                    <asp:Label runat="server" ID="lnkFilter" CssClass="filter" Text='<%#DataBinder.Eval(Container.DataItem, "Display")%>'></asp:Label>
                    <br />
                </ItemTemplate>
            </asp:Repeater>

            <asp:LinkButton runat="server" ID="lnkRemoveFilter" CssClass="filter" CommandName="Back" OnCommand="lnkRemoveFilter_Command" Text="Back"></asp:LinkButton>
        </div>
    </div>
</div>
