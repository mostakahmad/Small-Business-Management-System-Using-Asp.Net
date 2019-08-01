using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public int Add(Category category)
        {
            return _categoryRepository.Add(category);
        }
        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }
        public bool Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }
        public Category GetByID(int id)
        {
            return _categoryRepository.GetByID(id);
        }
        public bool Update(Category category)
        {
            return _categoryRepository.Update(category);
        }
    }
}
