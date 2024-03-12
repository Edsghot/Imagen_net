using _0._0.DataTransferLayer.Objects;
using _4._0.RepositoryLayer.Repository.Gallery;
using _5._0.DataAccessLayer.Connection;
using _5._0.DataAccessLayer.Entities;

namespace _5._0.DataAccessLayer.Query
{
    public class QGalllery : RepoGallery
    {
        public int insert(DtoGallery dto)
        {
            using DataBaseContext dbc = new();

            dbc.Add(InitAutoMapper.mapper.Map<Gallery>(dto));

            return dbc.SaveChanges();
        }
    }
}
