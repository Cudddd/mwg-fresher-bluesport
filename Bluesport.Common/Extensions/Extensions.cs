using Bluesport.Common.ModelsDTO;

namespace Bluesport.Common.Extensions
{
    public static class ProductsExt
    {
        public static ProductModelDTO ToModelDTO(this Data.Entities.Products product)
        {
            return new ProductModelDTO()
            {
                id = product.id,
                slug = product.slug,
                name = product.name,
                priceCurrent = product.priceCurrent,
                priceOld = product.priceOld,
                saleOff = product.saleOff,
                description = product.description,
                brandId = product.brandId,
                soldOut = product.soldOut,
                installment = product.installment
            };
        }
    }
}