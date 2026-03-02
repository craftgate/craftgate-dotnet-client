using System;
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

        [Test]
        public void Retrieve_Report()
        {
            var request = new RetrieveReportRequest
            {
                FileType = ReportFileType.CSV
            };

            var reportId = 27;

            var response = _craftgateClient.FileReporting().RetrieveReport(request, reportId);
            Assert.NotNull(response);
        }
    }
}