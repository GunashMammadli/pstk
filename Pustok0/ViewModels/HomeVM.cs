using Pustok0.Areas.Admin.ViewModels.ProductVM;

namespace Pustok0.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<SliderListItemVM> Sliders { get; set; }
        public IEnumerable<AdminProductListItemVM> Products { get; set; }
    }
}
