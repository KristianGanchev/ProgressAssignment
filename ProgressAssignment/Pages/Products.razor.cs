using Microsoft.AspNetCore.Components;
using ProgressAssignment.Models;

namespace ProgressAssignment.Pages;

public partial class Products : ComponentBase
{
    private Product[] products;

    private enum ProductsWindowSize
    {
        Small,
        Medium,
        Large
    }

    private ProductsWindowSize WindowSize { get; set; }

    private int GridLayoutColumnsCount { get; set; }

    private void UpdateGridLayout()
    {
        GridLayoutColumnsCount = (WindowSize == ProductsWindowSize.Large) ? 3 : (WindowSize == ProductsWindowSize.Medium) ? 2 : 1;
    }

    private void SmallMediaQueryChange(bool matchesMediaQuery)
    {
        if (matchesMediaQuery)
        {
            WindowSize = ProductsWindowSize.Small;
            UpdateGridLayout();
        }
    }

    private void MediumMediaQueryChange(bool matchesMediaQuery)
    {
        if (matchesMediaQuery)
        {
            WindowSize = ProductsWindowSize.Medium;
            UpdateGridLayout();
        }
    }

    private void LargeMediaQueryChange(bool matchesMediaQuery)
    {
        if (matchesMediaQuery)
        {
            WindowSize = ProductsWindowSize.Large;
            UpdateGridLayout();
        }
    }
}
