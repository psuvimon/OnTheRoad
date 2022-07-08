using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_service.Controllers
{
    [ApiController]
    public class OnTheRoadController : ControllerBase
    {
        // private readonly ILogger<OnTheRoadController> _logger;

        // public OnTheRoadController(ILogger<OnTheRoadController> logger)
        // {
        //     _logger = logger;
        // }

        [HttpGet]
        [Route("[controller]/TrickyCalculator")]
        public int TrickyCalculator(int a, int b)
        {
            var total = 0;
            if (b >= 0)
            {
                for(var i=0; i < b; i++)
                {
                    total -= (-a);
                }
            }
            else
            {
                for (var i=0; i > b; i--)
                {
                    total -= (a);
                }
            }

            return total;
        }

        [HttpGet]
        [Route("[controller]/LuckyTickets")]
        public Int64 LuckyTickets(int digits)
        {
            var luckyTicketCouter = 0;
            var maxNumber = 0;
            if(digits % 2 == 0)
            {
                var repeatString = new StringBuilder("9".Length * digits).Insert(0, "9", digits).ToString();
                maxNumber = Convert.ToInt32(repeatString);
                var maxDigitsNumber = Convert.ToInt32(Math.Pow(10, digits - 1));
                var splitLength = digits / 2;
                for(int i = 0; i <= maxNumber; i++)
                {
                    var currentStringNumber = string.Empty;
                    if(i < maxDigitsNumber)
                    {
                        currentStringNumber = i.ToString(new StringBuilder("0".Length * digits).Insert(0, "0", digits).ToString());
                    }
                    else
                    {
                        currentStringNumber = i.ToString();
                    }
                    var firstHalf = currentStringNumber.Substring(0,splitLength);
                    var sum1 = firstHalf.Sum(digit=>Convert.ToInt32(digit));
                    var secondHalf = currentStringNumber.Substring(splitLength,splitLength);
                    var sum2 = secondHalf.Sum(digit=>Convert.ToInt32(digit));
                    if(sum1 == sum2)
                    {
                        luckyTicketCouter++;
                    }
                }
            }
            
            return luckyTicketCouter;
        }

        [HttpGet]
        [Route("[controller]/Overlap")]
        public bool Overlap(string dateRangeA, string dateRangeB)
        {
            bool isOverlapped = false;

            // var dateRangeA = "2022-06-01 00:17:22,2022-06-06 13:11:48";
            // var dateRangeB = "2022-05-05 13:11:48,2022-05-30 17:36:09";
            var start1 = dateRangeA.Split(',')[0];
            var end1 = dateRangeA.Split(',')[1];
            var start2 = dateRangeB.Split(',')[0];
            var end2 = dateRangeB.Split(',')[1];

            var startDate1 = DateTime.ParseExact(start1, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            var endDate1 = DateTime.ParseExact(end1, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            var startDate2 = DateTime.ParseExact(start2, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            var endDate2 = DateTime.ParseExact(end2, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            
            if (startDate2 <= endDate1 && endDate2 >= startDate1)
            {
                isOverlapped = true;
            }

            return isOverlapped;
        }
    }
}
