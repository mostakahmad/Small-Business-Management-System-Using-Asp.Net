using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class CategoryRepository
    {
        InfinityDBContext db = new InfinityDBContext();
        public int Add(Category category)
        {
            int isAdd = 0;

            db.categories.Add(category);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return 1;
            return 0;
        }

        public List<Category> GetAll()
        {
            return db.categories.ToList();
        }
        public bool Delete(int id)
        {
            int isDelete = 0;
            Category category = new Category();

            category = db.categories.FirstOrDefault(c => c.ID == id);
            if (category != null)
            {
                db.categories.Remove(category);
                isDelete = db.SaveChanges();
            }
            if (isDelete > 0)
                return true;
            return false;
        }
        public Category GetByID(int id)
        {
            Category category = new Category();

            category = db.categories.FirstOrDefault(c => c.ID == id);
            return category;
        }
        public bool Update(Category category)
        {
            int isUpdate = 0;
            Category aCategory = new Category();

            aCategory = db.categories.FirstOrDefault(c => c.ID == category.ID);
            if (aCategory != null)
            {
                aCategory.CategoryCode = category.CategoryCode;
                aCategory.CategoryName = category.CategoryName;
                isUpdate = db.SaveChanges();
            }
            if (isUpdate > 0)
                return true;
            return false;
        }
    }
}
