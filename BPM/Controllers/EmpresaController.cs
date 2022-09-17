using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BPM.Business.Configuration;
using BPM.Dto.Configuration;


namespace BPM.Controllers
{
    public class EmpresaController : Controller
    {
        //[AuthorizeUser(Module: "Empresas")]
        public ActionResult Empresa()
        {
            try
            {
                var Business = new EmpresaBusiness();
                var ListEmpresaTras = Business.GetEmpresaTras();
                return View(ListEmpresaTras);

            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

       // [AuthorizeUser(Module: "Empresas")]
        public ActionResult Add(EmpresaDto EmpresaTra)
        {
            try
            {

                    var Business = new EmpresaBusiness();
                    var CreatedStatus = Business.AddEmpresaTra(EmpresaTra);

                    if (CreatedStatus == 1)
                    {
                        return RedirectToAction("Empresa", "Empresa");
                    }
                    else if (CreatedStatus == 2)
                    {
                        ViewBag.Error = "La Empresa ya existe.";
                        return View();
                    }
                    else
                    {
                        ViewBag.Error = "Hay un error en el sistema, contacte al administrador.";
                        return View(EmpresaTra);
                    }
                
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

       // [AuthorizeUser(Module: "Empresas")]
        public ActionResult Edit(int IdEmpresa)
        {
            var Business = new EmpresaBusiness();
            var EmpresaTra = Business.GetEmpresaTra(IdEmpresa);
            return View(EmpresaTra);

        }

        [HttpPost]
       // [AuthorizeUser(Module: "Empresas")]
        //public ActionResult Edit(int IdEmpresaTra, string Name)
        public ActionResult Edit(EmpresaDto EmpresaTra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var Empresa = new EmpresaDto()
                    //{
                    //    IdEmpresa = IdEmpresa,
                    //    Name = Name,
                    //};

                    var Business = new EmpresaBusiness();
                    var CreatedStatus = Business.EditEmpresaTra(EmpresaTra);

                    if (CreatedStatus == 1)
                    {
                        return RedirectToAction("Empresa", "Empresa");
                    }
                    else
                    {
                        ViewBag.Error = "Hay un error en el sistema, contacte al administrador.";
                        return View();
                    }
                }
                else
                {
                    return View(EmpresaTra);
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

     

       // [AuthorizeUser(Module: "Empresas")]
        public ActionResult Remove(string IdEmpresa)
        {
            try
            {

                var Business = new EmpresaBusiness();
                var RemoveStatus = Business.RemoveEmpresaTra(Convert.ToInt32(IdEmpresa));

                if (RemoveStatus == 1)
                {
                    return RedirectToAction("Empresa", "Empresa");
                }
                else
                {
                    ViewBag.Error = "Hay un error en el sistema, contacte al administrador.";
                    return View();
                }

            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

    }
}
