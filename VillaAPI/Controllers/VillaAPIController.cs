using Microsoft.AspNetCore.Mvc;
using VillaAPI.Data;
using VillaAPI.Models.DTOs;

namespace VillaAPI.Controllers
{
    // use [controller] could let us get the name of the controller, but then if we change the name of the controller
    // the route will be updated automatically, so the client code needs to be updated as well
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            // Instead of explose the model object directly, we can use the DTO object in the endpoint to only expose the
            // properties that we want to expose
            return VillaStore.VillaList;
        }

        // this id is the parameter name, it indicates this request is expecting a parameter called id
        // if we don't have this parameter, the API will have another AMBIGUOUS endpoint api/VillaAPI/GET
        [HttpGet("{id:int}")]
        public VillaDTO? GetVilla(int id)
        {
            return VillaStore.VillaList.FirstOrDefault(villa => villa.Id == id);
        }
    }
}
