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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekLeyInventory968
{
    public class OutSource : Part
    {
        public string CompanyName { get; set; }

        public OutSource() { }
        public OutSource(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public OutSource(int partID, string name, decimal price, int inStock, int min, int max, string compName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = compName;
        }
    }
}
