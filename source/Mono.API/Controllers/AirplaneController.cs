// <copyright file="AirplaneController.cs" company="Acme Sprocket Co">
// Copyright (c) Acme Sprocket Co. All rights reserved.
// </copyright>

namespace Mono.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <inheritdoc />
    [ApiController]
    [Route("airplane")]
    public class AirplaneController : ControllerBase
    {
        /// <summary>
        /// Returns all airplanes.
        /// </summary>
        /// <returns>A <see cref="IActionResult"/>.</returns>
        [HttpGet("", Name = "GetAirplanes")]
        public IActionResult Get()
        {
            return Ok(new List<string> { "Boeing", "Airbus" });
        }
    }
}