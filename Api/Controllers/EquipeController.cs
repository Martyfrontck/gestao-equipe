using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/equipe")]

        public class EquipeController : ControllerBase
        {
            // POST: api/equipe/create
            [HttpPost]
            [Route("create")]
            public Equipe Post(Equipe equipe)
            {
                equipe.Nome +=" Alterado";
                return equipe;
            }

        }

}
