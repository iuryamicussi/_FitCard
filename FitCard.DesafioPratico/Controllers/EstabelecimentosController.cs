using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using FitCard.DesafioPratico.DAL.Entity.Context;
using FitCard.DesafioPratico.Dominio;
using FitCard.DesafioPratico.Repositorios.Entity;
using FitCard.DesafioPratico.ViewModels;
using FitCard.Repositorios.Comum;

namespace FitCard.DesafioPratico.Controllers
{
    public class EstabelecimentosController : Controller
    {
        private IRepositorioGenerico<Estabelecimento, int> repositorioEstabelecimentos
            = new EstabelecimentosRepositorio(new DesafioPraticoDbContext());

        // GET: Estabelecimentos
        public ActionResult Index()
        {
            return View(Mapper.Map<IList<Estabelecimento>, IList<EstabelecimentoViewModel>>(repositorioEstabelecimentos.Selecionar()));
        }

        // GET: Estabelecimentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = repositorioEstabelecimentos.SelecionarPorId(id.Value);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Estabelecimento,EstabelecimentoViewModel>(estabelecimento));
        }

        // GET: Estabelecimentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estabelecimentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RazaoSocial,NomeFantasia,CNPJ,Email,Endereco,Cidade,Estado,Telefone,DataCadastro,Categoria,Status,Agencia,Conta")] EstabelecimentoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Estabelecimento estabelecimento = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(viewModel);
                try
                {
                    repositorioEstabelecimentos.Inserir(estabelecimento);
                }
                catch (CustomValidationException ex)
                {
                    ModelState.AddModelError(ex.NomeCampo, ex.Message);
                    return View(viewModel);
                }
                
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Estabelecimentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = repositorioEstabelecimentos.SelecionarPorId(id.Value);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Estabelecimento,EstabelecimentoViewModel>(estabelecimento));
        }

        // POST: Estabelecimentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RazaoSocial,NomeFantasia,CNPJ,Email,Endereco,Cidade,Estado,Telefone,DataCadastro,Categoria,Status,Agencia,Conta")] EstabelecimentoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Estabelecimento estabelecimento = Mapper.Map<EstabelecimentoViewModel, Estabelecimento> (viewModel);
                try
                {
                    repositorioEstabelecimentos.Alterar(estabelecimento);
                }
                catch (CustomValidationException ex)
                {
                    ModelState.AddModelError(ex.NomeCampo, ex.Message);
                    return View(viewModel);
                }
                
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Estabelecimentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = repositorioEstabelecimentos.SelecionarPorId(id.Value);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento));
        }

        // POST: Estabelecimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioEstabelecimentos.ExcluirPorId(id);   
            return RedirectToAction("Index");
        }
    }
}
