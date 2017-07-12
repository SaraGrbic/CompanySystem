using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebUi.Models;
using Zesium.Project.CompanySystem.BussinesLaye;
using Zesium.Project.CompanySystem.BussinesLaye.IServices;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Controllers
{
	public class DepartmentsController : Controller
	{
		private ICompanySystemService systemService;
		public DepartmentsController(ICompanySystemService css)
		{
			systemService = css;
		}
		// GET: Departments
		[HttpGet]
		public ActionResult GetAllDepartments()
		{
			IEnumerable<Department> departments;
			departments = systemService.GetAllDepartments();
		   
			return View(new DepartmentModel {Departments=departments });
		}
		[HttpGet]
		public ActionResult CreateNewDepartmantView()
		{
			return View();
		}
		[HttpPost]
		public ActionResult CreateNewDepartmantView(DepartmentViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				systemService.AddNewDepartmentWeb(viewModel.Name,
					viewModel.Description, viewModel.ManagerId);
				return RedirectToAction("GetAllDepartments");

			}
			return View(viewModel);

		}
		[HttpGet]
		public ActionResult EditDepartment(int? id)
		{
			if (id==null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			}
			var department = systemService.FindDepartment(id);
			DepartmentViewModel viewModel = new DepartmentViewModel();
			viewModel.Id = department.Id;
			viewModel.Name = department.Name;
			viewModel.ManagerId = department.ManagerId;
			viewModel.IsDepartmentActive = department.IsDepartmentActive;

			return View(viewModel);

		}
		[HttpPost]
		public ActionResult EditDepartment(DepartmentViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				systemService.EditDepartment(viewModel.Id,
											 viewModel.Name,
											 viewModel.Description,
											 viewModel.ManagerId,
											 viewModel.IsDepartmentActive);
				return RedirectToAction("GetAllDepartments");
			}
			return View(viewModel);
		}
	
	}
}