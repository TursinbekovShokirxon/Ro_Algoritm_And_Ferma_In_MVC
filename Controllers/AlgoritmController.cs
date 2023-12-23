using Crypt.Interfaces;
using Crypt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crypt.Controllers
{
    public class AlgoritmController:Controller
    {
        private readonly IGCD _gCD;
        public AlgoritmController(IGCD gCD)
        {
            _gCD = gCD;
        }
        #region RoAlgoritmPollarda
        [HttpGet]
        public IActionResult RoAlgoritmPollarda()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RoAlgoritmPollardaOutPut(int N)
        {
           Pollard result= _gCD.PollardAlgoritm(N);
            return View(result);
        }
        #endregion
        #region AlgoritmFerma
                [HttpGet]
        public IActionResult AlgoritmFerma()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AlgoritmFermaOutPut(int N)
        {
            return View(N);
        }

        #endregion
    }
}
