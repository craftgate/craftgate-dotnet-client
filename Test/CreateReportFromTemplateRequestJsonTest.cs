using System;
using System.Collections.Generic;
using Craftgate.Common;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Dto;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Test
{
    public class CreateReportFromTemplateRequestJsonTest
    {
        private readonly DateTime _startDate = new DateTime(2025, 11, 19, 9, 15, 31);
        private readonly DateTime _endDate = new DateTime(2025, 11, 27, 9, 15, 31);

        [Test]
        public void Should_Serialize_Report_Date_Filter_And_File_Format()
        {
            //given
            var request = new CreateReportFromTemplateRequest
            {
                Filters = new List<ReportFilter> {ReportFilter.ReportDate(_startDate, _endDate)},
                FileFormats = new HashSet<ReportFileType> {ReportFileType.XLSX}
            };

            //when
            var json = Serialize(request);

            //then
            Assert.AreEqual(
                "{\"filters\":[{\"name\":\"reportDate\",\"values\":[\"2025-11-19T09:15:31\",\"2025-11-27T09:15:31\"]}],\"fileFormats\":[\"XLSX\"]}",
                json);
        }

        [Test]
        public void Should_Omit_File_Formats_When_Not_Set()
        {
            //given
            var request = new CreateReportFromTemplateRequest
            {
                Filters = new List<ReportFilter> {ReportFilter.ReportDate(_startDate, _endDate)}
            };

            //when
            var json = Serialize(request);

            //then
            Assert.AreEqual(
                "{\"filters\":[{\"name\":\"reportDate\",\"values\":[\"2025-11-19T09:15:31\",\"2025-11-27T09:15:31\"]}]}",
                json);
        }

        [Test]
        public void Should_Keep_Filters_In_Insertion_Order()
        {
            //given
            var request = new CreateReportFromTemplateRequest
            {
                Filters = new List<ReportFilter>
                {
                    new ReportFilter {Name = "status", Values = new List<object> {"SUCCESS"}},
                    ReportFilter.ReportDate(_startDate, _endDate)
                },
                FileFormats = new HashSet<ReportFileType> {ReportFileType.CSV}
            };

            //when
            var json = Serialize(request);

            //then
            Assert.AreEqual(
                "{\"filters\":[{\"name\":\"status\",\"values\":[\"SUCCESS\"]},{\"name\":\"reportDate\",\"values\":[\"2025-11-19T09:15:31\",\"2025-11-27T09:15:31\"]}],\"fileFormats\":[\"CSV\"]}",
                json);
        }

        private static string Serialize(object request)
        {
            return JsonConvert.SerializeObject(request, CraftgateJsonSerializerSettings.RequestSettings);
        }
    }
}
