using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrabalhoWesley.API.Models;

namespace TrabalhoWesley.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LojaController : ControllerBase
    {

        public IEnumerable <Loja> _loja = new Loja[]{
               new Loja(){
                clienteId = 1, 
               nome = "Mateus",
               email = "mateus@gmail.com",
               telefone = "12345678"
               },
               new Loja(){
                clienteId = 2, 
               nome = "Maria",
               email = "maria@gmail.com",
               telefone = "12345679"
               }
           };
        public LojaController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Loja> Get()
        {
           return _loja;
        }

        
        [HttpGet("{id}")]
        public IEnumerable<Loja> GetbyId(int id)
        {
           return _loja.Where(Loja => Loja.clienteId == id);
        }

        [HttpPost]
        public String Post()
        {
           return "Post";
        }
        
    }
}
