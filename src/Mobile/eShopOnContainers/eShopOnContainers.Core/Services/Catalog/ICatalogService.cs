﻿using eShopOnContainers.Core.Models.Catalog;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Catalog
{
    public interface ICatalogService
    {
        Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync();
        Task<ObservableCollection<CatalogItem>> FilterAsync(string catalogBrand, string catalogType);
        Task<ObservableCollection<CatalogType>> GetCatalogTypeAsync();
        Task<ObservableCollection<CatalogItem>> GetCatalogAsync();
        Task<CatalogItem> GetCatalogItemAsync(string id);
    }
}
