using HistoricalTrackingDemoLibrary.Objects;
using SqlDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HistoricalTrackingDemoLibrary.Helper;
using System.Data.SqlClient;

namespace HistoricalTrackingDemoLibrary.DAL
{
    public static class HistoricalDataServer
    {
        public static List<HistoricalData> GetHistoricalDataList()
        {
            using (DataSet oSet = SqlHelper.ExecuteDataset(ConnectionString.GetConnectionString(), CommandType.StoredProcedure, "[DEMO].[GET_DEMO_HISTORICAL_DATA]"))
            {
                return oSet.ToHistoricalDataList();
            }
        }

        public static List<HistoricalData> GetFilteredHistoricalData(int iSessionID)
        {
            using (DataSet oSet = SqlHelper.ExecuteDataset(ConnectionString.GetConnectionString(), CommandType.StoredProcedure, "[DEMO].[GET_FILTERED_DEMO_HISTORICAL_DATA]", new SqlParameter("@IP_SESSION_ID", iSessionID)))
            {
                return oSet.ToFilteredHistoricalData();
            }
        }
    }
}
