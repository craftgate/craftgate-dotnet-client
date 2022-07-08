using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Craftgate;
using Craftgate.Model;
using Craftgate.Request;
using NUnit.Framework;

namespace Samples
{
    public class FileReportingSample
    {
        private readonly CraftgateClient _craftgateClient =
            new CraftgateClient("api-key", "secret-key", "https://sandbox-api.craftgate.io");

        [Test]
        public void Retrieve_Daily_Transaction_Report()
        {
            var request = new RetrieveDailyTransactionReportRequest
            {
                ReportDate = DateTime.Now.ToString("yyyy-MM-dd"),
                FileType = ReportFileType.CSV
            };

            var response = _craftgateClient.FileReporting().RetrieveDailyTransactionReport(request);

            Assert.NotNull(response);
            Assert.AreEqual("a,b,c\n10.00000000,username,0.00000000", Encoding.UTF8.GetString(response));
        }

        [Test]
        public void Retrieve_Daily_Transaction_Report_Xlsx()
        {
            var request = new RetrieveDailyTransactionReportRequest
            {
                ReportDate = DateTime.Now.ToString("yyyy-MM-dd"),
                FileType = ReportFileType.XLSX
            };

            var response = _craftgateClient.FileReporting().RetrieveDailyTransactionReport(request);

            Assert.NotNull(response);
        }
    }
}