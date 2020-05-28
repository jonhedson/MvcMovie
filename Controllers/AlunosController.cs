using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos

        #region Objeto/Model
        //Aluno aluno = new Aluno()
        //{
        //    AlunoId = 1,
        //    Nome = "Infnet",
        //    Campus = "Sao Jose",
        //    Curso = "ADS",
        //    Sexo = "Masculino"
        //};
        //return View(aluno);
        #endregion

        #region Create Aluno
        private static int contaId = 4;

        public static int AddId()
        {
            contaId = contaId + 1;
            return contaId;
        }

        public static int GetId()
        {
            return contaId;
        }

        private static List<Aluno> alunoList = new List<Aluno>
            {
                new Aluno(){ AlunoId = 1, Nome = "Jyanne Tainah", Campus = "São José", Curso = "ADS", Sexo = "F" },
                new Aluno(){ AlunoId = 2, Nome = "Ruan", Campus = "São José", Curso = "ADS", Sexo = "M" },
                new Aluno(){ AlunoId = 3, Nome = "Thyago", Campus = "São José", Curso = "ADS", Sexo = "M" },
            };

        public static void AddAluno(Aluno aluno)
        {
            alunoList.Add(aluno);
        }

        private static List<Aluno> GetalunoList()
        {
            return alunoList;
        }
        #endregion

        public static Aluno BuscarId(int id)
        {
            Aluno resultado = new Aluno();
            foreach (Aluno a in alunoList)
            {
                if (a.AlunoId == id)
                {
                    resultado.AlunoId = a.AlunoId;
                    resultado.Nome = a.Nome;
                    resultado.Campus = a.Campus;
                    resultado.Curso = a.Curso;
                    resultado.Sexo = a.Sexo;
                    break;
                }
            }
            return resultado;
        }

        public static void EditAluno(int id, Aluno alunoUpdate)
        {
            foreach (Aluno a in alunoList)
            {
                if (a.AlunoId == id)
                {
                    a.Nome = alunoUpdate.Nome;
                    a.Campus = alunoUpdate.Campus;
                    a.Curso = alunoUpdate.Curso;
                    a.Sexo = alunoUpdate.Sexo;
                    break;
                }
            }
        }

        public static void DeleteAluno(int id)
        {
            foreach (Aluno a in alunoList)
            {
                if (a.AlunoId == id)
                {
                    alunoList.Remove(a);
                    break;
                }
            }
        }

        public static List<Aluno> BuscarAluno(string pesquisa)
        {
            List<Aluno> resultados = new List<Aluno>();
            foreach (Aluno a in alunoList)
            {
                if (a.Nome.Contains(pesquisa))
                {
                    resultados.Add(a);
                }
            }
            return resultados;
        }

        public ActionResult Index()
        {
            return View(GetalunoList());
        }

        #region Methods Create
        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            Aluno aluno = new Aluno();
            aluno.AlunoId = GetId();
            aluno.Nome = collection["Nome"];
            aluno.Campus = collection["Campus"];
            aluno.Curso = collection["Curso"];
            aluno.Sexo = collection["Sexo"];
            
            AddId();

            AddAluno(aluno);
            return RedirectToAction("Index");
        }
        #endregion

        #region Methods Edit
        // GET: Alunos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(BuscarId(id));
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Nome = collection["Nome"];
                aluno.Campus = collection["Campus"];
                aluno.Curso = collection["Curso"];
                aluno.Sexo = collection["Sexo"];
                // aluno.Idade = Convert.ToInt32(collection["Idade"]);

                EditAluno(id, aluno);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Methods Delete
        // GET: Alunos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(BuscarId(id));
        }

        // POST: Alunos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                DeleteAluno(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Method Details
        // GET: Alunos/Details/5
        public ActionResult Details(int id)
        {
            return View(BuscarId(id));
        }
        #endregion

        public ActionResult Buscar()
        {
            string pesquisa = "";

            return View(BuscarAluno(pesquisa));
        }

        [HttpPost]
        public ActionResult Buscar(string pesquisa)
        {
            try
            {
                return View(BuscarAluno(pesquisa));
            }
            catch
            {
                return View();
            }
        }
    }


}