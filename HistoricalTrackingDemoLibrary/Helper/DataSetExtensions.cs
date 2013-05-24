using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HistoricalTrackingDemoLibrary.Helper
{
    public static class DataSetExtensions
    {
        public static IEnumerable<DataRow> FirstDataTableAsEnumerable(this DataSet oSet)
        {
            return oSet.Tables[0].AsEnumerable();
        }
    }
}
