using System;
using System.Collections.Generic;
using Craftgate.Model;
using Craftgate.Request;
using Craftgate.Request.Common;
using NUnit.Framework;

namespace Test
{
    public class RequestQueryParamsBuilderTest
    {
        [Test, TestCaseSource(nameof(TestCases))]
        public void Should_Build_Query_Param_For_Request(object request, string expected)
        {
            //when
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(request);

            //then
            Assert.AreEqual(expected, Uri.UnescapeDataString(queryParam));
        }

        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(
                new SearchWalletTransactionsRequest()
                {
                    WalletTransactionTypes = new HashSet<WalletTransactionType>()
                    {
                        WalletTransactionType.LOYALTY,
                        WalletTransactionType.WITHDRAW,
                        WalletTransactionType.REMITTANCE
                    },
                    MinCreatedDate = DateTime.Parse("04/25/2023 16:51:34"),
                    Page = 1,
                    MaxAmount = new decimal(1234.987654321)
                },
                "?walletTransactionTypes=LOYALTY,WITHDRAW,REMITTANCE&minCreatedDate=2023-04-25T16:51:34&maxAmount=1234.987654321&page=1&size=10&"
            );
            
            yield return new TestCaseData(
                new SearchPaymentsRequest()
                {
                    MaxPaidPrice = new decimal(1234.987654321),
                    PaymentType = PaymentType.CARD_PAYMENT,
                    IsThreeDS = false,
                    PaymentId = 1511,
                    PaymentChannel = "MobileApp",
                    MinCreatedDate = DateTime.Parse("03/25/2023 16:51:34"),
                },
                "?paymentId=1511&paymentType=CARD_PAYMENT&paymentChannel=MobileApp&maxPaidPrice=1234.987654321&isThreeDS=False&minCreatedDate=2023-03-25T16:51:34&page=0&size=10&");
        }
    }
}