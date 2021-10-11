using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FeUmbAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {

        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Pessoa Get(string nomePessoa)
        {
            Pessoa pessoaRetorno = new Pessoa();

            if (nomePessoa != null)
            {

                if (nomePessoa == "fernanda")
                {
                    pessoaRetorno = new Pessoa
                    {
                        nome = "Fe Umb",
                        idade = 22,
                        nomeGato = "Mingau",
                        personagemAnimeFav = "Aisaka Taiga"
                    };
                }
                else if (nomePessoa == "lucas")
                {
                    pessoaRetorno = new Pessoa
                    {
                        nome = "Lucas Mozi",
                        idade = 22,
                        nomeGato = "Yoshica",
                        personagemAnimeFav = "Mickey Mouse"
                    };
                }
                return pessoaRetorno;
            }
            else
            {
                pessoaRetorno = new Pessoa
                {
                    nome = "Steve do Minecraft",
                    idade = 99,
                    nomeGato = "Jaguatirica",
                    personagemAnimeFav = "Creeper"
                };
                return pessoaRetorno;
            }
        }
    }
}
