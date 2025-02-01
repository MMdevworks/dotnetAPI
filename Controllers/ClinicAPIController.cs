using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnetAPI.Models;
using dotnetAPI.Data;

namespace dotnetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicAPIController : ControllerBase
    {
        private readonly ApiContext _context;

        public ClinicAPIController(ApiContext context)
        {
            _context = context;
        }

        //Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(CareRoom room)
        {
            if (room.Id == 0)
            {
                _context.Rooms.Add(room);
            }
            else
            {
                var roomInDb = _context.Rooms.Find(room.Id);
                if (roomInDb == null)
                    return new JsonResult(NotFound());

                roomInDb = room;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(room));
        }
    }
}
