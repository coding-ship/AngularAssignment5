using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace assignmentapi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		// GET: api/<ValuesController>
		[HttpGet]
		[Route("Getdetails")]
		public IActionResult Getdetails()
		{
			var list = Helper.HelperClass.Userdatalist.ToList();
			return Ok(list);
		}
		[HttpDelete]
		[Route("DeleteTracer")]
		public IActionResult DeleteTracer(int id)
		{
			var list = Helper.HelperClass.Userdatalist.Find(s => s.id == id);
			Helper.HelperClass.Userdatalist.Remove(list);
			return Ok();

		}

		
	}
}
