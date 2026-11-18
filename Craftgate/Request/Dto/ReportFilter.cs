using System;
using System.Collections.Generic;

namespace Craftgate.Request.Dto
{
    public class ReportFilter
    {
        private const string ReportDateFilterName = "reportDate";

        public string Name { get; set; }
        public List<object> Values { get; set; }

        public static ReportFilter ReportDate(DateTime startDate, DateTime endDate)
        {
            return new ReportFilter
            {
                Name = ReportDateFilterName,
                Values = new List<object> {startDate, endDate}
            };
        }
    }
}
