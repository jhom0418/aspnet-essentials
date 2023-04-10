using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;

public class TarefaController : Controller{
//view = a página web (site)

    public IActionResult Index(){

        ViewData["Cabecalho"] = "Tarefa Diária";
        ViewData["Titulo"] = "Planejar Aula Senai";
        ViewData["Descricao"] = "Criar nova PEUC";
        
        return View();
    }



}