using _2._0.ServiceLayer.Generic;
using _2._0.ServiceLayer.ServiceObject;
using _3._0.BusinessLayer.Business.Galllery;
using _3._0.BusinessLayer.Business.User;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [Route("[controller]")]
    public class GalleryController : ControllerGeneric<BusinessGallery, SoGallery>
    {
        [HttpPost]
        [Route("[action]")]
        public  ActionResult<SoGallery> Insert([FromForm] IFormFile imagen, [FromForm] string description)
        {
            try
            {
                if (imagen == null || imagen.Length == 0)
                {
                    return BadRequest("No se ha proporcionado una imagen válida.");
                }

                string base64Image;
                using (var memoryStream = new MemoryStream())
                {
                    imagen.CopyTo(memoryStream);
                    byte[] bytes = memoryStream.ToArray();
                    base64Image = Convert.ToBase64String(bytes);
                }

                // Obtener el nombre y la extensión de la imagen
                string imageName = Path.GetFileNameWithoutExtension(imagen.FileName);
                string imageExtension = Path.GetExtension(imagen.FileName);

                _so.mo = _business.insert(base64Image, description, imageName, imageExtension);
            }
            catch (Exception ex)
            {
                _so.mo.listMessage.Add(ex.Message);
                _so.mo.exception();
            }

            return _so;
        }

        
    }
}
