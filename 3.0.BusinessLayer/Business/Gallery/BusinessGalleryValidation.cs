using _0._0.DataTransferLayer.Objects;
using _3._0.BusinessLayer.Generic;

namespace _3._0.BusinessLayer.Business.Galllery;

public partial class BusinessGallery 
{
    private void ExtensionValidation(string extension)
    {
        if (extension is null)
        {
            _mo.addMessage("No se pudo extraer la extensión de su archivo.");
        }
        else if (extension.ToLower() != ".jpg" && extension.ToLower() != ".png" && extension.ToLower() != ".jpeg")
        {
            _mo.addMessage("Inserte una imagen con una extensión correcta (jpg, png o jpeg): " + extension);
        }
    }
}