using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        ///     This API returns the square of the integer input {id}
        /// </summary>
        /// <param int name ="id"> Any Integer Input </param>
        /// <returns> Return the integer value of the square of the integer input {id} </returns>
        /// <example> 
        ///     /api/Square/2 => 4
        ///     /api/Square/-2 => 4
        ///     /api/Square/0 => 0
        ///     /api/Square/10 => 100
        /// </example>

        // GET /api/Square/{id}
        public int Get(int id)
        {
            return id*id;
        }
    }
}
