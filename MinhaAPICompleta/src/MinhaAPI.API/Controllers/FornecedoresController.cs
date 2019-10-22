using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.API.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class FornecedoresController : MainController
    {
        private readonly IMapper _mapper;

        public FornecedoresController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedor = new FornecedorViewModel();

            return Ok(fornecedor);
        }
    }
}