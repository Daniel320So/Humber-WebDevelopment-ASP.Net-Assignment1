using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        ///     This API returns the value that the integer input {id} is times -1, add 5, square and times 3
        /// </summary>
        /// <param int name="id"> Any Integer Value </param>
        /// <returns> Returns the integer value that the input {id} is times -1, add 5, squared and times 3 </returns>
        /// <example> 
        ///     /api/NumberMachine/-2 => 147
        ///     /api/NumberMachine/-5 => 300
        ///     /api/NumberMachine/0 => 75
        ///     /api/NumberMachine/5 => 0
        /// </example>

        // GET /api/NumberMachine/{id}
        public int Get(int id)
        {
            int value0 = (id * (-1) + 5);
            return value0 * value0 * 3;
        }
    }
}
