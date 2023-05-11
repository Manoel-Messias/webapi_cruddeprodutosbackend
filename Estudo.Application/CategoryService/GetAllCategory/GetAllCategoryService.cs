using Estudo.Context;
using Estudo.Domain.Dto.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo.Application.CategoryService.GetAllCategory
{
    public class GetAllCategoryService : IGetAllCategoryService
    {
        private readonly DataContext _context;

        public GetAllCategoryService(DataContext context)
        {
            _context = context;

        }

        public async Task<List<GetAllCategoryResponse>> GetAll()
        {
            List<GetAllCategoryResponse> lista = new List<GetAllCategoryResponse>();
            await Task.Run(() =>
            {
                var categories = _context.Categories.AsEnumerable()
                                     .Select(res => new GetAllCategoryResponse
                                     {
                                         Id = res.Id,
                                         Nome = res.Nome,
                                         Status = res.Status
                                     }).ToList();
                lista = categories;
            });

            

            return lista;
           
        }
    }
}
