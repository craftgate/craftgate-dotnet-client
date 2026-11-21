using System;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Common;
using NUnit.Framework;

namespace Test
{
    public class RetrieveReportRequestQueryTest
    {
        [Test]
        public void Should_Build_File_Type_Query_Param_For_Download()
        {
            var request = new RetrieveReportRequest {FileType = ReportFileType.XLSX};

            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);

            Assert.AreEqual("?fileType=XLSX&", Uri.UnescapeDataString(queryParam));
        }
    }
}
