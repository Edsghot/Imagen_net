using _0._0.DataTransferLayer.Objects;
using _4._0.RepositoryLayer.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0.RepositoryLayer.Repository.Gallery
{
    public interface RepoGallery 
    {
        public int insert(DtoGallery dto);
    }
}
