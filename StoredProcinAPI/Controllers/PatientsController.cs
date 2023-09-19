using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoredProcinAPI.Data;
using StoredProcinAPI.Models;

namespace StoredProcinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        private readonly ApplicationDBContext _context;
        public PatientsController(ApplicationDBContext db)
        {
            _context = db;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Patient pvm)
        {
            var p = _context.Database.ExecuteSqlRaw("sp_Patients @ID, @FirstName,@LastName,@Age, @Adrress ,@PatientType ,@bednum ,@diagnosis, @ttype", new SqlParameter("@ID", pvm.Id), 
                new SqlParameter("@FirstName", pvm.FirstName),
                new SqlParameter("@LastName", pvm.LastName),
                new SqlParameter("@Age", pvm.Age),
                new SqlParameter("@Adrress", pvm.Adrress),
                new SqlParameter("@PatientType", pvm.PatientType),
                new SqlParameter("@bednum", pvm.bednum),
                new SqlParameter("@diagnosis", pvm.diagnosis),
                new SqlParameter("@ttype", "insert"));
            return Ok("added");
        }


        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var p = _context.Patients.FromSqlRaw("sp_Patients @ttype='select'").ToList();
            return Json(p);
        }

        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit(Patient pvm)
        {
            var p = _context.Database.ExecuteSqlRaw("sp_Patients  @Id="+pvm.Id+", @Age='"+pvm.Age+"', @Adrress='"+pvm.Adrress+"', @ttype='update'");
            return Ok("Updated");
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(Patient pvm)
        {
            var p = _context.Database.ExecuteSqlRaw("sp_Patients  @Id=" + pvm.Id +", @ttype='delete'");
            return Ok("Deleted");
        }
    }
}
