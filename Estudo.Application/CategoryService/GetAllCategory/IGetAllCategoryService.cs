using Estudo.Domain.Dto.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estudo.Application.CategoryService.GetAllCategory
{
    public interface IGetAllCategoryService
    {
        Task<List<GetAllCategoryResponse>> GetAll();
    }
}
