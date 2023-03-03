using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ada.CodeAtCs.Aula1.Application.Inputs;
using Ada.CodeAtCs.Aula1.Application.Interfaces;
using Ada.CodeAtCs.Aula1.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ada.CodeAtCs.Aula1.Controllers
{
    [Route("api/[controller]")]
    public class AnimaisController : Controller
    {
        private readonly ICadastrarAnimalUseCase _cadastrarAnimalUseCase;

        public AnimaisController(ICadastrarAnimalUseCase cadastrarAnimalUseCase)
        {
            _cadastrarAnimalUseCase = cadastrarAnimalUseCase;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value: {id}";
        }

        
        [HttpPost]
        public IActionResult Post([FromBody]CadastrarAnimalInput input)
        {
            var response = _cadastrarAnimalUseCase.Execute(input);

            ///////// Deixar o retorno genérico exemplo:
            /// DE ACORDO COM O STATUS CODE
            // return MinhaResponseBonita(response);
            if (response.HasErrors)
            {
                return BadRequest(response.Errors); 
            }
            else
            {
                return Ok(response.Data);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

