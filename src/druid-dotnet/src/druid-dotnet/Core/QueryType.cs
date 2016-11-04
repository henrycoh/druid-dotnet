using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace druid_dotnet.Core
{
    public enum QueryType
    {
        [Description("timeseries")]
        Timeseries,
        [Description("topN")]
        TopN,
        [Description("groupBy")]
        GroupBy,
        [Description("timeBoundary")]
        TimeBoundary,
        [Description("segmentMetadata")]
        SegmentMetadata,
        [Description("dataSourceMetadata")]
        DataSourceMetadata,
        [Description("search")]
        Search
    }
}
