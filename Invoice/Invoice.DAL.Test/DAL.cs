using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Data.Common;

using System.Linq;
using Invoice.Model;
using System.Diagnostics;

namespace Invoice.ServiceLayer.MySql.Test
{
    [TestClass]
    public class DAL
    {
        string connectionString = "server=localhost;port=3306;database=invoice;uid=root;password=root;";

        [TestMethod]
        public void TestCreateDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create database if not exists
                using (Context contextDB = new Context(connection, false))
                {
                    contextDB.Database.CreateIfNotExists();
                }
            }
        }

        [TestMethod]
        public void TestProducerManagement()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create database if not exists
                using (Context contextDB = new Context(connection, false))
                {
                    var existingCount = contextDB.Producers.Count();

                    var producer = contextDB.Producers.Add(new Producer() { Name = "ИП 'Ткаченко'" });
                    contextDB.SaveChanges();

                    var id = producer.Id;
                    var secondProducer = contextDB.Producers.Single(x => x.Id == id);
                    secondProducer.Name = "ИП 'Ткаченко П.Г.'";
                    contextDB.SaveChanges();

                    contextDB.Producers.Remove(secondProducer);
                    contextDB.SaveChanges();
                }
            }
        }

        public void TestPacking()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create database if not exists
                using (Context contextDB = new Context(connection, false))
                {
                    contextDB.SaveChanges();
                }
            }
        }

        [TestMethod]
        public void TestAddInvoice()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create database if not exists
                using (Context contextDB = new Context(connection, false))
                {
                    var invoice = new Model.Invoice();
                    var item = new InvoiceItem();
                    item.Count = 111;
                    item.Product = contextDB.Products.First();
                    invoice.Items.Add(item);
                    invoice.Customer = contextDB.Customers.First();
                    invoice.Producer = contextDB.Producers.First();
                    invoice.Supplier = contextDB.Suppliers.First();
                    contextDB.Invoices.Add(invoice);
                    contextDB.SaveChanges();
                }
            }
        }
    }
}