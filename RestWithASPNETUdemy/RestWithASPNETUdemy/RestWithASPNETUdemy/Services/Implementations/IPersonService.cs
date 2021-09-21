using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        Person Update(Person person);
        void Delete(long id);
        List<Person> FindAll();
    }
}
