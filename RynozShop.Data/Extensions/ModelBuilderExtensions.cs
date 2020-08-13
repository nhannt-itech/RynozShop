using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RynozShop.Data.Entities;
using RynozShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RynozShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of RShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of RShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of RShop" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
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
                    SortOrder = 1,
                    Status = Status.Active
                }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời gian nam",
                    SeoTitle = "Sản phẩm áo thời gian nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời gian nữ",
                    SeoTitle = "Sản phẩm áo thời gian nữ"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt products for women",
                    SeoTitle = "The shirt products for women"
                }
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
                    Name = "Áo sơ mi trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-trang-viet-tien",
                    SeoDescription = "Áo sơ mi trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi trắng Việt Tiến",
                    Details = "Áo sơ mi trắng Việt Tiến",
                    Description = "Áo sơ mi trắng Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viettien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viettien-men-t-shirt",
                    SeoDescription = "Viettien Men T-Shirt",
                    SeoTitle = "Viettien Men T-Shirt",
                    Details = "Viettien Men T-Shirt",
                    Description = "Viettien Men T-Shirt"
                }
                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            var ROLE_ID = new Guid("999EDBAF-D1B4-4731-BC78-E1DFE968AADD");
            var ADMIN_ID = new Guid("61171D84-C0F4-4998-94E4-2315D1EF146F");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "rynoz2k@gmail.com",
                NormalizedEmail = "rynoz2k@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Nhan",
                LastName = "Nguyen",
                Dob = new DateTime(2000,05,21)

            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
