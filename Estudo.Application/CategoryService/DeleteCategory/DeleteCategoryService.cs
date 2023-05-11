using Estudo.Context;
using Estudo.Domain.Dto;
using Estudo.Domain.Dto.Category;
using System;
using System.Threading.Tasks;

namespace Estudo.Application.CategoryService.DeleteCategory
{
    public class DeleteCategoryService : IDeleteCategoryService
    {
        private readonly DataContext _context;

        public DeleteCategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<Message> DeleteCategory(DeleteCategoryRequest request)
        {
            if (request.Id <= 0)
                return new Message { SucessMessage = "O id nao pode ser igual a 0 ou vazio" };

            var hasCategory = await _context.Categories.FindAsync(request.Id);

            if (hasCategory == null)
            {
                return new Message { SucessMessage = "Categoria não encontrada" };
            }

            _context.Categories.Remove(hasCategory);

            await _context.SaveChangesAsync();

            return new Message { SucessMessage = "Categoria deletada" };

        }
    }
}
