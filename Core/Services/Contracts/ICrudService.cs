using Core.Models;

namespace Core.Services.Contracts
{
    public interface ICrudService
    {

       public void Add(Entity entity);
       public void Delete(int id);
       public void Update(int id, Entity entity);
       public Entity Get(int id);
    }
}
