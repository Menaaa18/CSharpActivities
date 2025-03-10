using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AuthorRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Author Create(Author author)
        {
            _applicationDbContext.Authors.Add(author);
            _applicationDbContext.SaveChanges();
            return author;
        }

        public void Delete(Author author)
        {
            _applicationDbContext.Remove(author);
            _applicationDbContext.SaveChanges();
        }

        public void Delete()
        {
            
        }

        public List<Author> Get()
        {
            return _applicationDbContext.Authors.ToList();
        }

        public int GetById(int id)
        {
            Author? authors = _applicationDbContext.Users.Find(id);
            return authors;
        }

        public Author Update(Author author)
        {
            Author? existingAuthor = _applicationDbContext.Users.Find(author.Id);
        }
    }
}
