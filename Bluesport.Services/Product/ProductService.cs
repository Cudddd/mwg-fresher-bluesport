using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bluesport.Common.Extensions;
using Bluesport.Common.ModelsDTO;
using Bluesport.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace Bluesport.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly BluesportDbContext _context;
        public ProductService(BluesportDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductModelDTO>> Get()
        {
            var products = await _context.Products.ToListAsync();

            List<ProductModelDTO> productModelDtos = new List<ProductModelDTO>();
            foreach (var item in products)
            {
                productModelDtos.Add(item.ToModelDTO());
            }

            return productModelDtos;
        }

        public async Task<ProductModelDTO> GetById(string id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.id == id);
            
            if(product != null)
                product.ToModelDTO();
            return null;
        }

        public async Task<ProductModelDTO> GetBySlug(string slug)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.slug == slug);

            if(product != null)
                product.ToModelDTO();
            return null;
        }

        public async Task<List<ProductModelDTO>> GetAllPaging(int pageIndex, int pageSize)
        {
            var products = await _context.Products.ToListAsync();

            products = products.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();
                
            List<ProductModelDTO> productModelDtos = new List<ProductModelDTO>();
            foreach (var item in products)
            {
                productModelDtos.Add(item.ToModelDTO());
            }

            return productModelDtos;
        }

        public async Task<List<ProductModelDTO>> GetByCategory(string cateId)
        {
            var products = await (from p in _context.Products
                join pmc in _context.ProductMapCate on p.id equals pmc.productId
                join c in _context.Categories on pmc.cateId equals c.id
                where (c.id.Contains(cateId))
                select p).ToListAsync();

            List<ProductModelDTO> productModelDtos = new List<ProductModelDTO>();
            foreach (var item in products)
            {
                item.ToModelDTO();
            }
            
            return productModelDtos;
        }

        public Task<int> Create()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Update()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}