using Microsoft.AspNetCore.Mvc;
using RabbitMQ.MessageProducer;

namespace RabbitMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMessageProducer _messageProducer;
        public EmployeesController(IMessageProducer messageProducer)
        {
            _messageProducer = messageProducer;
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            _messageProducer.SendMessage(employee, "employeeQueue");

            return Ok();
        }
    }
}