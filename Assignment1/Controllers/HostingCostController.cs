using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        ///     This API returns the hosting cost of web hosting and maintenance, plus an additional 13%HST
        /// </summary>
        /// <param name="id"> The number of web hosting and maintenance day in integer</param>
        /// <returns> 
        ///     Returns three strings as an array that shows the Hosting Cost without Tax, Tax Amount, and Hosting Cost with Tax:
        ///     “{id} fortnights at $5.50/FN = {fee} CAD”
        ///     “HST 13% = {fee}*13% CAD”
        ///     “Total = {fee} + {fee}*13% CAD"
        /// </returns>
        /// <example> 
        ///     /api/HostingCost/0 =>  return “1 fortnights at $5.50/FN = $5.50 CAD”, “HST 13% = $0.72 CAD”, “Total = $6.22 CAD"
        ///     /api/HostingCost/14 => return “2 fortnights at $5.50/FN = $11.00 CAD”, “HST 13% = $1.43 CAD”, “Total = $12.43 CAD”
        ///     /api/HostingCost/15 => return "2 fortnights at $5.50/FN = $11.00 CAD”, “HST 13% = $1.43 CAD”, “Total = $12.43 CAD”
        ///     /api/HostingCost/21 => return “2 fortnights at $5.50/FN = $11.00 CAD”, “HST 13% = $1.43 CAD”, “Total = $12.43 CAD”
        ///     /api/HostingCost/28 => return “3 fortnights at $5.50/FN = $16.50 CAD”, “HST 13% = $2.14 CAD”, “Total = $18.64 CAD”
        /// </example>

        // GET /api/HostingCost/{id}
        public IEnumerable<string> Get(int id)
        {   
            int fortnight = 14;
            int numberOfFortnight = id/fortnight + 1;
            double fee = numberOfFortnight * 5.5;
            double hst = fee * 0.13;
            double total = fee + hst;

            return new string[]
            {
                numberOfFortnight + " fortnights at $5.50 / FN = $" + Math.Round(fee, 2)  + " CAD",
                "HST 13% = $" + Math.Round(hst, 2) + " CAD",
                "Total = $" + Math.Round(total, 2) + " CAD"
            };
        }
    }
}
