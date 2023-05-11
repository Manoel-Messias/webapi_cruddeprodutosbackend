using Estudo.Domain.Dto.Category;
using System.Threading.Tasks;

namespace Estudo.Application.CategoryService.CreateCategory
{
     public interface ICreateCategoryService
    {
        Task<CreateCategoryResponse> CreateCategory(CreateCategoryRequest request);
    }
}
