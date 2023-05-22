using Homework_6.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework_6.Services.PeopleService
{
    public class PeopleService : IPeopleService
    {
        private readonly DataContext _context;

        public PeopleService(DataContext context)
        {
            _context = context;
        }

        public async Task<Person> CreatePerson(CreatePersonRequest newPerson)
        {
            var person = new Person
            { 
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Age = newPerson.Age
            };
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<List<Person>> GetPeople()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person?> GetPersonById(int id)
        {
            var person = await GetById(id);
            return person;
        }

        public async Task<List<Person>?> RemovePersonById(int id)
        {
            var person = await GetById(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return await _context.Person.ToListAsync();
        }

        public async Task<List<Person>?> UpdatePersonById(int id, Person request)
        {
            var person = await GetById(id, request);

            person.FirstName = request.FirstName;
            person.LastName = request.LastName;
            person.Age = request.Age;

            await _context.SaveChangesAsync();

            return await _context.Person.ToListAsync();
        }

        private async Task<Person?> GetById(int id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null) return null;
            return person;
        }

        private async Task<Person?> GetById(int id, Person request)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null) return null;
            return person;
        }
    }
}
