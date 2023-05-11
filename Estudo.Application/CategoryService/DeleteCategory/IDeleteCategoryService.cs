using Estudo.Domain.Dto;
using Estudo.Domain.Dto.Category;
using System.Threading.Tasks;

namespace Estudo.Application.CategoryService.DeleteCategory
{
    public interface IDeleteCategoryService
    {
        Task<Message> DeleteCategory(DeleteCategoryRequest request);
    }
}
