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

        public async Task<List<Person>> CreatePerson(CreatePersonRequest newPerson)
        {
            var person = new Person
            { 
                Id = Guid.NewGuid(),
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Age = newPerson.Age
            };
            //_context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT Person ON");
            await _context.Person.AddAsync(person);
            await _context.SaveChangesAsync();
            //_context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT Person OFF");
            return await _context.Person.ToListAsync();
        }

        public async Task<List<Person>> GetPeople()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person?> GetPersonById(Guid id)
        {
            var person = await GetById(id);
            return person;
        }

        public async Task<List<Person>?> RemovePersonById(Guid id)
        {
            var person = await GetById(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return await _context.Person.ToListAsync();
        }

        public async Task<List<Person>?> UpdatePersonById(Guid id, Person request)
        {
            var person = await GetById(id, request);

            person.FirstName = request.FirstName;
            person.LastName = request.LastName;
            person.Age = request.Age;

            await _context.SaveChangesAsync();

            return await _context.Person.ToListAsync();
        }

        private async Task<Person?> GetById(Guid id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null) return null;
            return person;
        }

        private async Task<Person?> GetById(Guid id, Person request)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null) return null;
            return person;
        }
    }
}
