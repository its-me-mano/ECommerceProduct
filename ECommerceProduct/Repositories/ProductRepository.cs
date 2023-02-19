using ECommerceProduct.Contracts;
using ECommerceProduct.DbContexts;
using ECommerceProduct.Entities.Model;
using ECommerceProduct.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProduct.Repositories
{
    public class ProductRepository : IProductRepositories
    {
        private readonly ProductDetailsContext _context;
        public ProductRepository(ProductDetailsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Get the All the products
        /// </summary>
        /// <param name="userResourceParameter"></param>
        /// <returns></returns>
        public PageList<Product> GetProducts(UserResourceParameter userResourceParameter,string role)
        {
            if (userResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(userResourceParameter));
            }
            IQueryable<Product> Collection = _context.Products as IQueryable<Product>;
            if (!string.IsNullOrWhiteSpace(userResourceParameter.searchQuery))
            {
                string Query = userResourceParameter.searchQuery.ToLower();
                Collection = Collection.Where(a => a.Name.ToLower().Contains(Query));
            }
            if (!string.IsNullOrWhiteSpace(userResourceParameter.category))
            {
                var categoryId = (_context.RefTerms.Where(a => a.Key == userResourceParameter.category).FirstOrDefault()).Id;
                Collection = Collection.Where(a => a.Category.Equals(categoryId));
            }
            if (userResourceParameter.OrderType != null)
            {
                bool check = role.Equals("User");
                if (userResourceParameter.OrderType.Equals("DESC"))
                {
                    Collection = Collection.OrderByDescending(a => a.Name);
                    if(check)
                        Collection=Collection.Where(a => a.Visibility.Equals(new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")));
                }
                else
                {
                    Collection = Collection.OrderBy(a => a.Name);
                    if (check)
                        Collection = Collection.Where(a => a.Visibility.Equals(new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae")));
                }
            }
            return PageList<Product>.Create(Collection, userResourceParameter.PageNo, userResourceParameter.PageSize);
        }

        /// <summary>
        /// Get the particular product from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Product GetProduct(Guid productId) {
            return _context.Products.Where(a => a.Id.Equals(productId)).FirstOrDefault();
        }

        ///<summary>
        ///update the users
        ///</summary>
        ///<param name="userId"></param>
        ///<param name="product"></param>
        public void UpdateProduct(Product product, Guid userId)
        {
            Product Data = _context.Products.Where(a => a.Id == userId).FirstOrDefault();
            _context.SaveChanges();
        }
        /// <summary>
        /// Check the productQuanity is available or not
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool CheckProdcutCount(int quantity, Guid productId)
        {
            return _context.Products.Where(a => a.Id == productId).FirstOrDefault().ProductCount >= quantity ? true : false;
        }
        /// <summary>
        /// Delete the product
        /// </summary>
        /// <param name="productId"></param>
        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }
        /// <summary>
        /// It will give the opposite of the current visibility id
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public Guid ChangeVisibilityId(Guid id) { 
            Guid GroupId= (_context.SetRefTerms.Where(a => a.ReftermId == id).FirstOrDefault()).RefSetid;
            return (_context.SetRefTerms.Where(a => a.RefSetid.Equals(GroupId) && !a.ReftermId.Equals(id))).FirstOrDefault().ReftermId;
        }
        /// <summary>
        /// Check the product in the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool CheckProduct(Guid userId) {
            return _context.Products.Any(a => a.Id ==userId);
        }
        ///<summary>
        ///save the users
        ///</summary>
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
        /// <summary>
        /// get the product quantity
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int GetProductCount(Guid productId) {
            return _context.Products.Where(a => a.Id == productId).FirstOrDefault().ProductCount;
        }

    }

}
