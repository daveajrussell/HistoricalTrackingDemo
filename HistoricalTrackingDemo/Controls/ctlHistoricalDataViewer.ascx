<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlHistoricalDataViewer.ascx.cs" Inherits="HistoricalTrackingDemo.Controls.ctlHistoricalDataViewer" %>

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

            var hex = getHex();

            $('#key').find('#<%= period.SessionID%>').css('background-color', hex); 

            poly = new google.maps.Polyline({
                path: path,
                strokeColor: hex,
                strokeOpacity: 1.0,
                strokeWeight: 3
            });

            poly.setMap(map);

        <% } %>

    });

    function getHex() {
        return '#' + Math.floor(Math.random() * 16777215).toString(16);
    }

</script>

<div id="home" class="segment-active">
    <div class="section">
        <div id="map">
        </div>

        <div id="key">
            <asp:Repeater runat="server" ID="rptSessionKeys">
                <ItemTemplate>
                    <span id="<%#Eval("SessionID") %>" style="width:10px;height:10px;display:inline-block"></span> 
                    =
                    <asp:LinkButton runat="server" ID="lnkFilter" CssClass="filter" OnCommand="lnkFilter_Command" CommandName="SessionID" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "SessionID") %>' Text='<%#DataBinder.Eval(Container.DataItem, "Display")%>'></asp:LinkButton>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</div>
