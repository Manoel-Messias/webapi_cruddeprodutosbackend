using Estudo.Context;
using Estudo.Domain.Dto.Category;
using Estudo.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo.Application.CategoryService.CreateCategory
{
    public class CreateCategoryService : ICreateCategoryService
    {
        private readonly DataContext _context;

        public CreateCategoryService(DataContext context)
        {
            _context = context;

        }

        public async Task<CreateCategoryResponse> CreateCategory(CreateCategoryRequest request)
        {
            #region ValidateRequest
            if (string.IsNullOrEmpty(request.Nome))
            {
                return new CreateCategoryResponse { Messenge = "Nome está vazio" };
            }
            #endregion

            var categoryList = _context.Categories.ToList();

            var hasCategory = categoryList.FirstOrDefault(o => o.Nome.Equals(request.Nome));

            if(hasCategory != null) return new CreateCategoryResponse { Messenge = "O nome ja existe " };

            var category = new Category { Nome = request.Nome,  Status = true};

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return new CreateCategoryResponse { Messenge = "Cadastrado Com sucesso" };
        }


    }
}
