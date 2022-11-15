using AnchalsBooks.DatacAccess.Repository.IRepository;
using AnchalsBooks.Models;
using AnchalsBookStore.DataAccess.Data;
using AndrewsBooks.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnchalsBooks.DatacAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
    }
}
