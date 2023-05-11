using Estudo.Application.CategoryService.CreateCategory;
using Estudo.Domain.Dto.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Estudo.Apresentacion.Controllers
{
    [ApiController]
    [Produces("application/json")]

    public class CategoryController : Controller
    {
        private readonly ICreateCategoryService _createCategoryService;
        public CategoryController(ICreateCategoryService createCategoryService)
        {
            _createCategoryService = createCategoryService;
        }

        [HttpPost("api/[controller]/CreateCategory")]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequest request)
        {
            try
            {
                if (request == null) 
                {
                    return BadRequest("ocorreu um erro");
                }
                var result = await _createCategoryService.CreateCategory(request);

                return Ok(result); 

            }
            catch (System.Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
