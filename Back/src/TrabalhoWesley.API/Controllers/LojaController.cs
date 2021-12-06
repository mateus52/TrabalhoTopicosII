using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrabalhoWesley.API.Data;
using TrabalhoWesley.API.Models;

namespace TrabalhoWesley.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LojaController : ControllerBase
    {

        public IEnumerable<Loja> _loja = new Loja[]{
              
           };
        private readonly DataContext _context;
        public LojaController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Loja> Get()
        {
            return _context.Loja;
        }


        [HttpGet("{id}")]
        public Loja GetbyId(int id)
        {
            return _context.Loja.FirstOrDefault(Loja => Loja.Id == id);
        }

        [HttpPost]
        public String Post()
        {
            return "Post";
        }

    }
}
