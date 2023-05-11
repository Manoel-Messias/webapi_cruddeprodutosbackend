using Estudo.Application.CategoryService.CreateCategory;
using Estudo.Application.CategoryService.DeleteCategory;
using Estudo.Application.CategoryService.GetAllCategory;
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
        private readonly IDeleteCategoryService _deleteCategoryService;
        private readonly IGetAllCategoryService _getAllCategoryService;

        public CategoryController(ICreateCategoryService createCategoryService, 
                                  IDeleteCategoryService deleteCategoryService,
                                  IGetAllCategoryService getAllCategoryService)
        {
            _createCategoryService = createCategoryService;
            _deleteCategoryService = deleteCategoryService;
            _getAllCategoryService = getAllCategoryService;
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

        [HttpDelete("api/[controller]/DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([FromBody]DeleteCategoryRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("ocorreu um erro");
                }
                var result = await _deleteCategoryService.DeleteCategory(request);

                return Ok(result);

            }
            catch (System.Exception error)
            {

                return BadRequest(error);
            }
        }

        [HttpGet("api/[controller]/GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            try
            {               
                var result = await _getAllCategoryService.GetAll();

                return Ok(result);

            }
            catch (System.Exception error)
            {

                return BadRequest(error);
            }
        }
    }
}
