using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BPM.Business.Configuration;
using BPM.Dto.Configuration;


namespace BPM.Controllers
{
    public class RepresentanteController : Controller

    {
        RepresentanteBusiness Business = new RepresentanteBusiness();
        EmpresaBusiness BussinesE = new EmpresaBusiness();
        //[AuthorizeUser(Module: "Representantes")]
        public ActionResult Representante()
        {
            try
            {
                var RepresentanteObjects = new RepresentanteCreationDto();

                RepresentanteObjects.RepresentanteList = Business.GetRepresentanteTras();
                RepresentanteObjects.EmpresaList = BussinesE.GetEmpresaTras();

                return View(RepresentanteObjects); 

            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

       // [AuthorizeUser(Module: "Representantes")]
        public ActionResult Add(
             string Tipo,
                    string NumeroDocumento,
                   string NombreCompleto,
                  
                    string Direccion,
                    string Ciudad,
                    string Departamento,
                    string Pais,
                    string Telefono,
                    string SelectedEmpresa
            )
        {
            try
            {

                var RepresentanteDtos = new RepresentanteDto
                {
                    Tipo = Tipo,
                    NumeroDocumento = NumeroDocumento,
                    NombreCompleto = NombreCompleto,
                    Direccion = Direccion,
                    Ciudad = Ciudad,
                    Departamento = Departamento,
                    Pais = Pais,
                    Telefono = Telefono,
                    IdEmpresa = Convert.ToInt32(SelectedEmpresa),


                };

                var CreatedStatus = Business.SaveRepresentante(RepresentanteDtos);

                if (CreatedStatus == 1)
                {
                    return RedirectToAction("Representante", "Representante");
                }
                else if (CreatedStatus == 2)
                {
                    ViewBag.Error = "El Representante ya existe.";
                    return View();
                }
                else
                {
                    return RedirectToAction("Representante", "Representante");
                    //ViewBag.Error = "Hay un error en el sistema, contacte al administrador.";
                    //return View();
                }
            }
            catch (Exception e)
            {

                ViewBag.Error = e.Message;
                return View();
            }
        }

     

        [HttpPost]
        // [AuthorizeUser(Module: "Representantes")]
        //public ActionResult Edit(int IdRepresentanteTra, string Name)
        public ActionResult Edit(int IdRepresentante)
        {
            var RepresentanteObjects = new RepresentanteCreationDto();
            RepresentanteObjects.RepresentanteList = new List<RepresentanteDto>() { Business.GetRepresentanteTra(Convert.ToInt32(IdRepresentante)) };

            RepresentanteObjects.EmpresaList = BussinesE.GetEmpresaTras();
            RepresentanteObjects.SelectedEmpresa = RepresentanteObjects.EmpresaList.FirstOrDefault().IdEmpresa;

  


            return View(RepresentanteObjects);

        }

        [HttpPost]

        public ActionResult Edit(
            string IdRepresentante,
                    string Tipo,
                    string NumeroDocumento,
                   string NombreCompleto,

                    string Direccion,
                    string Ciudad,
                    string Departamento,
                    string Pais,
                    string Telefono,
                    string SelectedEmpresa
           
             )
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var Representantes = new RepresentanteDto()
                    {
                        IdRepresentante = Convert.ToInt32(IdRepresentante),
                        Tipo = Tipo,
                        NumeroDocumento = NumeroDocumento,
                        NombreCompleto = NombreCompleto,
                        Direccion = Direccion,
                        Ciudad = Ciudad,
                        Departamento = Departamento,
                        Pais = Pais,
                        Telefono = Telefono,
                        IdEmpresa = Convert.ToInt32(SelectedEmpresa)
                       


                    };

                    var CreatedStatus = Business.EditRepresentanteTra(Representantes);

                    if (CreatedStatus == 1)
                    {
                        return RedirectToAction("Representante", "Representante");
                    }
                    else
                    {
                        return RedirectToAction("Representante", "Representante");
                        //ViewBag.Error = "Hay un error en el sistema, contacte al administrador.";
                        //return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }



        // [AuthorizeUser(Module: "Representantes")]
        public ActionResult Remove(string IdRepresentante)
        {
            try
            {

                var Business = new RepresentanteBusiness();
                var RemoveStatus = Business.RemoveRepresentanteTra(Convert.ToInt32(IdRepresentante));

                if (RemoveStatus == 1)
                {
                    return RedirectToAction("Representante", "Representante");
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
