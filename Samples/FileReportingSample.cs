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
        }
    }
}