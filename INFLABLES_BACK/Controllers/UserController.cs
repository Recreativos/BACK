using Microsoft.AspNetCore.Mvc;

namespace INFLABLES_BACK.Controllers;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    #region Recuperar de contraseña
    // POST: registerUser
    /// <summary>
    /// Crear un usuario
    /// </summary>
    /// <remarks>
    /// Método que permite registrar un nuevo usuario
    /// </remarks>
    /// <response code="401">Unauthorized. No se ha indicado o es incorrecto el token JWT de acceso</response>
    [HttpPost]
    [Route("registerUser")]
    public async Task<IActionResult> RecoverPasswordByEmail([FromBody] dynamic request)
    {
        return Ok();
    }
    #endregion
}
