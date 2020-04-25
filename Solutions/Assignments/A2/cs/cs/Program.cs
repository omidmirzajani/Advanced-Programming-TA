using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    public enum ID
    {
        Mobile=1,
        Laptop=2,
        Tablet=3
    }
    public class Program
    {
        public static void Main(string[] args){}
    }
    public class Product
    {
        public ID Id;
        public string Name;
        public int Price;
        public double Rate;
        public Product(ID id , string name, int price, double rate)
        {
            Id = id;
            Name = name;
            Price = price;
            Rate = rate;
        }
    }

    public class Category
    {
        public ID Id;
        public List<Product> Products;
        public Category(ID id, List<Product> products)
        {
            Id = id;
            Products = products;
        }
        public void AddProduct(Product p)
        {
            if(Id==p.Id)
                Products.Add(p);
        }
        public List<Product> FilterByPrice(int lower,int upper)
        {
            List<Product> result=new List<Product>();
            foreach(Product p in Products)
            {
                if(p.Price>=lower && p.Price<=upper)
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }

    public class Cart
    {
        public string Owner;
        public List<Product> Products;
        public Cart(string owner, List<Product> products)
        {
            Owner = owner;
            Products = products;
        }
        public void AddProduct(Product p)
        {
            Products.Add(p);
        }
        public long CalculatePrice()
        {
            long total_price = 0;
            foreach (Product p in Products)
                total_price += p.Price;
            return total_price;
        }
        
    }

    public class Store
    {
        public string Name;
        public List<Category> Categories;
        public List<Cart> Carts;
        public Store(string name, List<Category> categories, List<Cart> carts)
        {
            Name = name;
            Categories = categories;
            Carts = carts;
        }
        public void AddCart(Cart c)
        {
            Carts.Add(c);
        }
        public void AddCategory(Category c)
        {
            Categories.Add(c);
        }

        public Product Bestselling()
        {
            Dictionary<Product, int> dic = new Dictionary<Product, int>();
            foreach(Cart c in Carts)
            {
                foreach(Product p in c.Products)
                {
                    if (dic.Keys.Contains(p))
                        dic[p]++;
                    else
                        dic[p] = 0;
                }
            }
            int repeat = -1;
            Product res = new Product(0, "", 0, 0);
            foreach(Product p in dic.Keys)
            {
                if(dic[p]>repeat)
                {
                    repeat = dic[p];
                    res = p;
                }
            }
            return res;
        }
        public Product MostPopular()
        {
            double popular = -1;
            Product res = new Product(0, "", 0, 0);
            foreach (Category c in Categories)
            {
                foreach (Product p in c.Products)
                {
                    if (p.Rate > popular)
                    {
                        popular = p.Rate;
                        res = p;
                    }
                }
            }
            return res;
        }
    }
}
