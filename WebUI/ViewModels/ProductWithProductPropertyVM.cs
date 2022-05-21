using ETicaretEntities.Concrete;

namespace WebUI.ViewModels
{
    public class ProductWithProductPropertyVM
    {
        public Product Product { get; set; } = default!;
        public ProductProperty ProductProperty { get; set; } = default!;

    }
}
