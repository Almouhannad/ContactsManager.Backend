using ContactsManager.API.Data;
using ContactsManager.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsContext context;

        public ContactsController(ContactsContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetContactById ([FromRoute] int id)
        {
            var contact = context.Contacts.First(c => c.Id == id);

            return Ok(contact);
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = context.Contacts.ToList();

            return Ok(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] CreateRequest request)
        {
            var domainModel = request.ToDomainModel();
            context.Contacts.Add(domainModel);
            await context.SaveChangesAsync();

            return Ok(domainModel);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateContact([FromRoute] int id, [FromBody] EditRequest request)
        {
            var domainModel = request.ToDomainModel(id);
            context.Contacts.Update(domainModel);
            await context.SaveChangesAsync();

            return Ok(domainModel);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteContact ([FromRoute] int id)
        {
            var contact = context.Contacts.First(c => c.Id == id);
            context.Contacts.Remove(contact);
            await context.SaveChangesAsync();

            return Ok(contact);
        }
    }
}
