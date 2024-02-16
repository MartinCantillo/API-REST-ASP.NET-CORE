using Crud.Model;

namespace Crud.Repository
{
    interface IPersonRepository
    {
        Task<List<Person>> GetAll();
        Task<Person> GetPersonById(int Id);
        Task DeletePerson(Person person);
        Task AddPerson(Person person);
        Task UpdatePerson(Person person);

    }
}