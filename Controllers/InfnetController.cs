using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{

    public class InfnetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            ViewData["Title"] = "Página de detalhes do Aluno";
            ViewData["Header"] = "Detalhes do Aluno";



            #region Exemplo 1 - Feito em aula com uso de Objeto
            // Criar novos objetos
            // Apresentar na View todos objetos
            //Aluno aluno = new Aluno()
            //{
            //    AlunoId = 1,
            //    Nome = "Jyanne Tainah",
            //    Campus = "São José",
            //    Curso = "ADS",
            //    Sexo = "F"
            // };
            #endregion

            #region Exemplo 2 - Feito aula com o uso de Lista  
            //// Desafio proposto
            // Fazer com o array

            // 
            //List<Aluno> alunoList;

            //alunoList = new List<Aluno>()
            //{
            //    new Aluno(){
            //    AlunoId = 1,
            //    Nome = "Jyanne Tainah",
            //    Campus = "São José",
            //    Curso = "ADS",
            //    Sexo = "F" },

            //    new Aluno(){
            //    AlunoId = 2,
            //    Nome = "Ruan",
            //    Campus = "São José",
            //    Curso = "ADS",
            //    Sexo = "M" },

            //    new Aluno(){
            //    AlunoId = 3,
            //    Nome = "Thyago",
            //    Campus = "São José",
            //    Curso = "ADS",
            //    Sexo = "M" },
            //};
            // ViewData["Aluno"] = alunoList;
            #endregion

            #region Exemplo 3 - Model Aluno
            //Aluno aluno = new Aluno()
            //{
            //    AlunoId = 1,
            //    Nome = "Jyanne Tainah",
            //    Campus = "São José",
            //    Curso = "ADS",
            //    Sexo = "F"
            //};
            //ViewData["Aluno"] = aluno;
            #endregion

            #region Exemplo 4 - Model Aluno com Lista
            List<Aluno> alunoList;

            alunoList = new List<Aluno>()
            {
                new Aluno(){
                AlunoId = 1,
                Nome = "Jyanne Tainah",
                Campus = "São José",
                Curso = "ADS",
                Sexo = "F" },

                new Aluno(){
                AlunoId = 2,
                Nome = "Ruan",
                Campus = "São José",
                Curso = "ADS",
                Sexo = "M" },

                new Aluno(){
                AlunoId = 3,
                Nome = "Thyago",
                Campus = "São José",
                Curso = "ADS",
                Sexo = "M" },
            };

            ViewData["Aluno"] = alunoList;
            #endregion

            return View();


        }
    }
}