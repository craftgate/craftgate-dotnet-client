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
            new CraftgateClient("zG5jvjwWQyo3iIDyr6p1tvy1DzTXfnTb", "yzyiMbQD8cNGh6qHWbP0rLE56LDdmh8J", "http://localhost:8000");


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

        [Test]
        public void Retrieve_Daily_Payment_Report()
        {
            var request = new RetrieveDailyPaymentReportRequest
            {
                ReportDate = DateTime.Now.ToString("yyyy-MM-dd"),
                FileType = ReportFileType.CSV
            };

            var response = _craftgateClient.FileReporting().RetrieveDailyPaymentReport(request);

            Assert.NotNull(response);
        }

        [Test]
        public void Create_Report()
        {
            var request = new CreateReportRequest
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
                ReportType = ReportType.PAYMENT,
                ReportPeriod = ReportPeriod.INSTANT
            };

            var response = _craftgateClient.FileReporting().CreateReport(request);
            Assert.NotNull(response);
        }
    }
}