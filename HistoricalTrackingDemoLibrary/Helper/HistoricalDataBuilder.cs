using HistoricalTrackingDemoLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HistoricalTrackingDemoLibrary.Helper
{
    public static class HistoricalDataBuilder
    {
        public static List<HistoricalData> ToHistoricalDataList(this DataSet oSet)
        {
            return (from item in oSet.FirstDataTableAsEnumerable()
                   orderby item.Field<int>("HISTORICAL_SESSION_ID") descending, item.Field<DateTime>("TIMESTAMP") ascending
                   group item by new { SessionID = item.Field<int>("HISTORICAL_SESSION_ID"), TimeStamp = item.Field<DateTime>("TIMESTAMP").Date } into g
                   select new HistoricalData()
                   {
                       Display = g.Key.SessionID + " - " + g.Key.TimeStamp.ToShortDateString(),
                       SessionID = g.Key.SessionID,
                       TimeStamp = g.Key.TimeStamp.ToShortDateString(),
                       Coordinates = (from item in g
                                     select new Coordinate()
                                              {
                                                  Latitude = item.Field<decimal>("LATITUDE"),
                                                  Longitude = item.Field<decimal>("LONGITUDE"),
                                              }).ToList()
                   }).ToList();
        }

        public static List<HistoricalData> ToFilteredHistoricalData(this DataSet oSet)
        {
            return (from item in oSet.FirstDataTableAsEnumerable()
                    orderby item.Field<int>("HISTORICAL_SESSION_ID") descending, item.Field<DateTime>("TIMESTAMP") ascending
                    group item by new { SessionID = item.Field<int>("HISTORICAL_SESSION_ID"), TimeStamp = item.Field<DateTime>("TIMESTAMP").Date } into g
                    select new HistoricalData()
                    {
                        Display = g.Key.SessionID + " - " + g.Key.TimeStamp.ToShortDateString(),
                        SessionID = g.Key.SessionID,
                        TimeStamp = g.Key.TimeStamp.ToShortDateString(),
                        Coordinates = (from item in g
                                      select new Coordinate()
                                               {
                                                   Latitude = item.Field<decimal>("LATITUDE"),
                                                   Longitude = item.Field<decimal>("LONGITUDE"),
                                               }).ToList()
                    }).ToList();
        }
    }
}
