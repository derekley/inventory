/*
 * Name:        Derek Ley
 * Student ID:  #001053885
 * Course:      C968
 * Date:        Sunday, December 1, 2019
 * Purpose:     This program will act as an inventory management system that allows for users to add/modify Parts
 *              in their inventory and add/modify Products and link the Parts to those Products.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekLeyInventory968
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        public static bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
            }
            return success;
        }

        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            Product returnProd = new Product();
            return returnProd;
        }

        public static void UpdateProduct(int productID, Product updatedProd)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.AssociatedParts = updatedProd.AssociatedParts;
                    currentProd.Name = updatedProd.Name;
                    currentProd.Price = updatedProd.Price;
                    currentProd.InStock = updatedProd.InStock;
                    currentProd.Min = updatedProd.Min;
                    currentProd.Max = updatedProd.Max;
                    return;
                }
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void UpdatePart(int partID, Part updatedPart)
        {
            foreach (Part currentPart in AllParts)
            {
                if (currentPart.PartID == partID)
                {
                    currentPart.Name = updatedPart.Name;
                    currentPart.Price = updatedPart.Price;
                    currentPart.InStock = updatedPart.InStock;
                    currentPart.Min = updatedPart.Min;
                    currentPart.Max = updatedPart.Max;
                    return;
                }
            }
        }

        public static int MaxProd()
        {
            int max = int.MinValue;
            foreach (Product prod in Inventory.Products)
            {
                if (prod.ProductID > max)
                {
                    max = prod.ProductID;
                }
            }
            return max;
        }

        public static int MaxPart()
        {
            int max = int.MinValue;
            foreach (Part part in Inventory.AllParts)
            {
                if (part.PartID > max)
                {
                    max = part.PartID;
                }
            }
            return max;
        }
    }
}
