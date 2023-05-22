global using Homework_6.Model;

namespace Homework_6.Services.PeopleService
{
    public interface IPeopleService
    {
        Task<List<Person>> GetPeople();
        Task<Person?> GetPersonById(int id);
        Task<Person> CreatePerson(CreatePersonRequest newPerson);
        Task<List<Person>?> RemovePersonById(int id);
        Task<List<Person>?> UpdatePersonById(int id, Person request);
    }
}
