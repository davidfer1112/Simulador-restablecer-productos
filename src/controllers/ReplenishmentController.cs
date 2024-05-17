using Microsoft.AspNetCore.Mvc;

namespace ReplenishmentSimulator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReplenishmentController : ControllerBase
    {
        [HttpPost]
        public IActionResult SimulateReplenishment()
        {
            // Simula la respuesta del sistema de reabastecimiento
            return Ok(new { message = "Listo mi broco se hizo el restablecimiento" });
        }
    }
}
