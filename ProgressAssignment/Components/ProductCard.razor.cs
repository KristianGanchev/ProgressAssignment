using Microsoft.AspNetCore.Components;

namespace ProgressAssignment.Components;

public partial class ProductCard : ComponentBase
{
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public decimal Price { get; set; }

    [Parameter]
    public int Stock { get; set; }

    [Parameter]
    public string Category { get; set; }

    [Parameter]
    public string Image { get; set; }
}
