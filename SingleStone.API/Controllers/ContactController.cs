using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SingleStone.API.Entities;
using SingleStone.API.LiteDb;
using System.Collections.Generic;

namespace SingleStone.API.Controllers
{
    [ApiController]
    [Route("/contacts/")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IDbContactService _contactDbService;

        public ContactController(ILogger<ContactController> logger, IDbContactService contactDbService)
        {
            _contactDbService = contactDbService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return _contactDbService.FindAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            var result = _contactDbService.FindOne(id);
            if (result != default)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult<Contact> Insert(Contact dto)
        {
            var id = _contactDbService.Insert(dto);
            if (id != default)
                return CreatedAtRoute(new { id = id }, dto);
            else
                return BadRequest();
        }

        [HttpPut]
        public ActionResult<Contact> Update(Contact dto)
        {
            var result = _contactDbService.Update(dto);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult<Contact> Delete(int id)
        {
            var result = _contactDbService.Delete(id);
            if (result > 0)
                return NoContent();
            else
                return NotFound();
        }
    }
}