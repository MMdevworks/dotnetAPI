using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnetAPI.Models;
using dotnetAPI.Data;

namespace dotnetAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]

    public class ClinicAPIController : ControllerBase
    {
        private readonly ApiContext _context;

        public ClinicAPIController(ApiContext context)
        {
            _context = context;
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Rooms.Find(id);

            if (result == null) 
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Get all
        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Rooms.ToList();

            return new JsonResult(Ok(result));
        }

        // Create/Update
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

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Rooms.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Rooms.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }
    }
}
