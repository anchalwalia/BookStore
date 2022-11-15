using AnchalsBooks.DatacAccess.Repository.IRepository;
using AnchalsBooks.Models;
using AnchalsBookStore.DataAccess.Data;
using AndrewsBooks.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Update(Category category)
        {
            //use .Net LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID
            var objFromDb =  _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
