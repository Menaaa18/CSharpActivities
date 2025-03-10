using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IAuthorRepository
    {
        Author Create(Author author);
        Author Update();
        void Delete();
        int Get();
        int GetById();
    }
}
