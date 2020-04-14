﻿using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(

                new AppConfig() { Key = "HomeTitle", Value = "This is a Home page" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is a Home page" },
                new AppConfig() { Key = "HomeDescription", Value = "This is a Home page" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng VIệt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
            );



            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },

                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                    CategoryTranslations = new List<CategoryTranslation>() {

                    }
                }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id=1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo Nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0
                }
            );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam",
                    SeoDescription = "Sản phẩm áo thời trang áo sơ mi nam",
                    SeoTitle = "Sản phẩm áo thời trang áo sơ mi nam",
                    Details = "Mô tả sản phẩm",
                    Description = "Áo sơ mi trắng"
                },
                new ProductTranslation()
                {
                    Id =2,
                    ProductId = 1,
                    Name = "Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "Men T-Shirt",
                    SeoTitle = "Men T-Shirt",
                    Details = "Men T-Shirt",
                    Description = "Men T-Shirt"
                }    
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
               new ProductInCategory() { ProductId = 1, CategoryId = 1 }
            );
        }
    }
}
