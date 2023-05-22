global using Homework_6.Model;

namespace Homework_6.Services.PeopleService
{
    public interface IPeopleService
    {
        Task<List<Person>> GetPeople();
        Task<Person?> GetPersonById(Guid id);
        Task<List<Person>> CreatePerson(CreatePersonRequest newPerson);
        Task<List<Person>?> RemovePersonById(Guid id);
        Task<List<Person>?> UpdatePersonById(Guid id, Person request);
    }
}
