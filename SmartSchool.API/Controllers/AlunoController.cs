using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno
            {
                ID = 1,
                Nome = "Marcelo",
                Sobrenome = "Henrique",
                Telefone = "983796722"
            },
            new Aluno
            {
                ID = 2,
                Nome = "Rafael",
                Sobrenome = "Monteiro",
                Telefone = "981121633"
            },
            new Aluno
            {
                ID = 3,
                Nome = "Martha",
                Sobrenome = "Kent",
                Telefone = "123456"
            },
        };

        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(alunos);
        }

        // GET api/<AlunoController>/5
        [HttpGet("byID/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = alunos.FirstOrDefault(a => a.ID == id);
            if (aluno == null)
                return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );
            if (aluno == null)
                return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        // POST api/<AlunoController>
        [HttpPost]
        public IActionResult Post(PROGRAMAS_ANUAIS_DE_PRODUCAO_CAMPO xml)
        {
            return Ok(xml);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
