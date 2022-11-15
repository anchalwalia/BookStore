using AnchalsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnchalsBooks.DatacAccess.Repository.IRepository
{
   public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
