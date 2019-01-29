using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marco.AspNetCore.WebApi.BootStrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marco.CleanArchitecture.WebApi.Controllers
{
    [AllowAnonymous]
    public class ProductsController : ApiBaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            await Task.CompletedTask;

            return Ok();
        }
    }
}