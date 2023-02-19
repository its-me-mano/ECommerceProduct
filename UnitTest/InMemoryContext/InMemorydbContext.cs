using ECommerceProduct.DbContexts;
using ECommerceProduct.Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

namespace ECommerceProduct.InMemoryContext
{
    public static class InMemorydbContext
    {
        /// <summary>
        /// This method is used to create the InMemeorydatabase
        /// </summary>
        public static ProductDetailsContext productDetailsContext()
        {
            var options = new DbContextOptionsBuilder<ProductDetailsContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            var context = new ProductDetailsContext(options);

            context.Products.Add(new Product()
            {
                Id = new Guid("8de4b55d-80d2-4313-9367-de5c561ef335"),
                Name = "Apple IPhone Xs Max",
                Category = new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"),
                ProductCount = 50,
                Price = 100000,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                Name = "Apple IPhone 14",
                Category = new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"),
                ProductCount = 500,
                Price = 150000,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                Name = "Fan",
                Category = new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"),
                ProductCount = 500,
                Price = 5000,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                Name = "Light",
                Category = new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"),
                ProductCount = 500,
                Price = 800,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                Name = "Ghee Bottle",
                Category = new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"),
                ProductCount = 250,
                Price = 250,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                Name = "Honey Bottle",
                Category = new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"),
                ProductCount = 250,
                Price = 300,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                Name = "Sony Alpha",
                Category = new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                ProductCount = 50,
                Price = 250000,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")
            });

            context.Products.Add(new Product()
            {
                Id = new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                Name = "Canon 5000D",
                Category = new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                ProductCount = 50,
                Price = 75000,
                CreateBy = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                Visibility = new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734")
            });

            string path = @"C:\Users\Manoj\source\repos\ECommerceProduct\ECommerceProduct\DbContexts\RefSet.csv";
            string ReadCSV = File.ReadAllText(path);
            foreach (string csvRow in ReadCSV.Split("\n"))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    string[] csvCols = csvRow.Split(",");
                    RefSet refSet = new RefSet();
                    refSet.Id = Guid.Parse(csvCols[0].ToString());
                    refSet.Key = csvCols[1].ToString();
                    refSet.Description = csvCols[2].ToString();
                    refSet.CreateBy = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
                    refSet.DateCreated = DateTime.Now;
                    context.RefSets.Add(refSet);
                }
            }
            string path1 = @"C:\Users\Manoj\source\repos\ECommerceProduct\ECommerceProduct\DbContexts\RefTerm.csv";
            string ReadCSV1 = File.ReadAllText(path1);
            foreach (string csvRow in ReadCSV1.Split("\n"))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    string[] csvCols = csvRow.Split(",");
                    RefTerm refTerm = new RefTerm();
                    refTerm.Id = Guid.Parse(csvCols[1].ToString());
                    refTerm.Key = csvCols[0].ToString();
                    refTerm.Description = csvCols[2].ToString();
                    refTerm.CreateBy = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
                    refTerm.DateCreated = DateTime.Now;
                    context.RefTerms.Add(refTerm);

                }
            }
            string path2 = @"C:\Users\Manoj\source\repos\ECommerceProduct\ECommerceProduct\DbContexts\SetRefTerm.csv";
            string ReadCSV2 = File.ReadAllText(path2);
            foreach (string csvRow in ReadCSV2.Split("\n"))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    string[] csvCols = csvRow.Split(",");
                    SetRefTerm setRefTerm = new SetRefTerm();
                    setRefTerm.RefSetid = Guid.Parse(csvCols[0].ToString());
                    setRefTerm.ReftermId = Guid.Parse(csvCols[1].ToString());
                    setRefTerm.Id = Guid.Parse(csvCols[2].ToString());
                    setRefTerm.CreateBy = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
                    setRefTerm.DateCreated = DateTime.Now;
                    context.SetRefTerms.Add(setRefTerm);
                }
            }
            context.SaveChanges();
            return context;
        }
    }
}
