using BlazingShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Category GetCategory(int categoryId)
        {
            return _db.Categories.FirstOrDefault(u => u.Id == categoryId);
        }

        public List<Category> GetCategories()
        {
            return _db.Categories.ToList();
        }

        public bool CreateCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateCategory(Category category)
        {
            var existingCateory = _db.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCateory != null)
            {
                existingCateory.Name = category.Name;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCategory(Category category)
        {
            var existingCateory = _db.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCateory != null)
            {
                _db.Categories.Remove(existingCateory);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
