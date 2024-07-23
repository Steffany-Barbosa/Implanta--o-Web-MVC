using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Steffany Barbosa", "000.000.000-01", "steh.barbosa@df.senai.br",  "Zyra");
        Cliente cliente2 = new Cliente(02, "Ivan Fonseca", "000.000.000-02", "ivan.fonseca@df.senai.br",  "Nero");
        Cliente cliente3 = new Cliente(03, "Valentina Lonara", "000.000.000-03", "valentina.lonara@df.senai.br",  "Rakan");
        Cliente cliente4 = new Cliente(04, "Leona Fonseca", "000.000.000-04", "leona.fonseca@df.senai.br",  "Morgana");
        Cliente cliente5 = new Cliente(05, "Marluce Silva", "000.000.000-05", "marluce.silva@df.senai.br",  "Ralf");

        // lista de Clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instancias do tipo fornecedor 
        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet s/a", "14.182.101/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.185.102/0001-80", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "16.186.103/0001-80", "boots@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "17.187.104/0001-80", "tiktok@dogs.midia.us");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.188.105/0001-80", "contato@bff.com");

        // lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
