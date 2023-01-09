using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TerraformDemo.Models;

namespace TerraformDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatementController : ControllerBase
    {
        private readonly StatementDBContext _context;

        public StatementController(StatementDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<Statement[]> GetAll()
        {
            return this._context.Statements.ToArray();
        }

        [HttpPost]
        public ActionResult<Statement> Post([FromBody] Statement statement)
        {
            return this._context.Statements.Add(statement).Entity;
        }
    }
}
