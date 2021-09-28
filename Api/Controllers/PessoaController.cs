using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly DataContext _context;
        public PessoaController(DataContext context)
        {
            _context = context;
        }

        // POST: api/pessoa/create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody] Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
            await _context.SaveChangesAsync();
            return Created("", pessoa);
        }

        // GET: api/pessoa/list
        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> ListAsync() => Ok(await _context.Pessoa.ToListAsync());

        // GET: api/pessoa/getbyid/5
        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            Pessoa pessoa = await _context.Pessoa.FindAsync(id);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return NotFound();
        }

        // DELETE: api/pessoa/delete/bolacha
        [HttpDelete]
        [Route("delete/{name}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string name)
        {
            //Retorna o primeiro elemento com base na expressão lambda
            Pessoa pessoa = _context.Pessoa.FirstOrDefault
            (
                pessoa => pessoa.Nome == name
            );
            _context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // PUT: api/pessoa/delete/bolacha
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] Pessoa pessoa)
        {
            _context.Pessoa.Update(pessoa);
            await _context.SaveChangesAsync();
            return Ok(pessoa);
        }
    }
}