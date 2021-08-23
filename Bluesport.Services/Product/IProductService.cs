using System.Collections.Generic;
using System.Threading.Tasks;
using Bluesport.Common.ModelsDTO;

namespace Bluesport.Services.Product
{
    public interface IProductService
    {
        public Task<List<ProductModelDTO>> Get();
        public Task<ProductModelDTO> GetById(string id);
        public Task<ProductModelDTO> GetBySlug(string slug);
        public Task<List<ProductModelDTO>> GetAllPaging(int pageIndex, int pageSize);
        public Task<List<ProductModelDTO>> GetByCategory(string cateId);
        public Task<int> Create();
        public Task<int> Update();
        public Task<int> Delete();
    }
}