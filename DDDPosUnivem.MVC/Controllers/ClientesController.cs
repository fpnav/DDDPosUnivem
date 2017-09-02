using AutoMapper;
using DDDPosUnivem.Application.Interfaces;
using DDDPosUnivem.Domain.Entities;
using DDDPosUnivem.Domain.Interfaces.Services;
using DDDPosUnivem.Infra.Data.Repositories;
using DDDPosUnivem.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDPosUnivem.MVC.Controllers
{
    public class ClientesController : Controller
    {
        //Old School - chamando direto da infra/Repositórios
        //private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        //Old School - chamando direto da camada de serviço no domain
        //private readonly IClienteService _clienteService;

        private readonly IClienteAppService _clienteAppService;


        public ClientesController(IClienteAppService clienteService)
        {
            //NINJECT - DI
            _clienteAppService = clienteService;
        }
        
        // GET: Clientes
        public ActionResult Index()
        {
            var clientesViewModel = Mapper.Map<IEnumerable<Cliente>, 
                IEnumerable<ClienteViewModel>>(_clienteAppService.GetAll());
            return View(clientesViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clientModel = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteAppService.Add(clientModel);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
