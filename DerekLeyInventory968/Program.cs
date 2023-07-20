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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekLeyInventory968
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Dummy Parts and Products for testing
            InHouse nPart1 = new InHouse(1, "Seat", Convert.ToDecimal(9.99), 10, 5, 10, 123);
            OutSource nPart2 = new OutSource(2, "Frame", Convert.ToDecimal(35.99), 5, 1, 5, "ACME Co.");
            InHouse nPart3 = new InHouse(3, "Chain", Convert.ToDecimal(2.99), 5, 1, 5, 456);
            Product nProduct1 = new Product(1, "EZ-Rider", Convert.ToDecimal(79.99), 5, 5, 0);
            Product nProduct2 = new Product(2, "Mountaineer", Convert.ToDecimal(99.99), 3, 5, 0);
            Inventory.AddPart(nPart1);
            Inventory.AddPart(nPart2);
            Inventory.AddPart(nPart3);
            Inventory.AddProduct(nProduct1);
            Inventory.AddProduct(nProduct2);
            nProduct1.AddAssociatedPart(nPart3);
            nProduct1.AddAssociatedPart(nPart2);
            nProduct1.AddAssociatedPart(nPart1);
            nProduct2.AddAssociatedPart(nPart3);
            nProduct2.AddAssociatedPart(nPart2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
