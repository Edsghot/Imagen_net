using _0._0.DataTransferLayer.Objects;
using _0._0.DataTransferLayer.OtherObjects;
using _3._0.BusinessLayer.Generic;
using System.Buffers.Text;
using System.Transactions;
using System.Xml;

namespace _3._0.BusinessLayer.Business.Galllery
{
    public partial class BusinessGallery : BusinessGeneric
    {
        public DtoMessageObject insert(string image, string description,string imageName,string imageExtension)
        {
            using TransactionScope transactionScope = new();


            if (image is null || image  == string.Empty)
            {
                _mo.addMessage("No se pudo convertir a base 64");
                return _mo;
            }

            ExtensionValidation(imageExtension);

            if (_mo.exsistsMessage())
            {
                return _mo;
            }


            var dto = new DtoGallery();

            dto.idGallery = Guid.NewGuid().ToString();
            dto.imageValue = image;
            dto.name = imageName;
            dto.extension = imageExtension;
            dto.description = description;

            repoGalllery.insert(dto);

            transactionScope.Complete();

            _mo.addMessage("Operación realizada correctamente.");
            _mo.success();

            return _mo;
        }

    }
}