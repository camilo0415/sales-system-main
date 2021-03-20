using System;

namespace Ventas
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Objectlist objectlist = new Objectlist();   // Esto es una instancia, asignacion

            Seller v1 = new Seller();
            v1.Name = " Camilo Aguirre";
            v1.Age = 36;
            v1.Id = "A1002314";                         //el objectlist.AddVendedores es una lista que guarda esos atributos y esos parámetros
            v1.Gender = "Hombre";
            objectlist.AddVendedores(v1);


            Seller v2 = new Seller();
            v2.Name = "Paco ";
            v2.Age = 24;
            v2.Id = "B193120";
            v2.Gender = "Hombre";
            objectlist.AddVendedores(v2);

            Seller v3 = new Seller();
            v3.Name = "Helver ";
            v3.Age = 33;
            v3.Id = "C10015347";
            v3.Gender = "Hombre";
            objectlist.AddVendedores(v3);

            Seller v4 = new Seller();
            v4.Name = "Ricardo ";
            v4.Age = 40;
            v4.Id = "D12321E";
            v4.Gender = "Hombre";
            objectlist.AddVendedores(v4);

            Seller v5 = new Seller();
            v5.Name = "Stephanie ";
            v5.Age = 26;
            v5.Id = "B1234415";
            v5.Gender = "Hombre";
            objectlist.AddVendedores(v5);

            Product p1 = new Product();
            p1.Name = "Queso";
            p1.Price = 5;
            p1.Categoria = "Lacteos";
            objectlist.AddProductos(p1);

            Product p2 = new Product();
            p2.Name = "Gaseositas";
            p2.Price = 3;
            p2.Categoria = "Soda";
            objectlist.AddProductos(p2);

            Product p3 = new Product();
            p3.Name = "Arequipe";
            p3.Price = 8;
            p3.Categoria = "Dulce";
            objectlist.AddProductos(p3);

            Product p4 = new Product();
            p4.Name = "Yorgursito";
            p4.Price = 4;
            p4.Categoria = "Lacteos";
            objectlist.AddProductos(p4);

            Product p5 = new Product();
            p5.Name = "Whisky";
            p5.Price = 150;
            p5.Categoria = "Licor";
            objectlist.AddProductos(p5);

            Product p6 = new Product();
            p6.Name = "De todito";
            p6.Price = 6;
            p6.Categoria = "Dulce";
            objectlist.AddProductos(p6);

            Product p7 = new Product();
            p7.Name = "Cepillo de Dientes";
            p7.Price = 2;
            p7.Categoria = "Aseo";
            objectlist.AddProductos(p7);

            Product p8 = new Product();
            p8.Name = "Limpido";
            p8.Price = 7;
            p8.Categoria = "Aseo";
            objectlist.AddProductos(p8);

            Product p9 = new Product();
            p9.Name = "Reloj";
            p9.Price = 100;
            p9.Categoria = "Accesorios";
            objectlist.AddProductos(p9);

            Product p10 = new Product();
            p10.Name = "Oreo";
            p10.Price = 1;
            p10.Categoria = "Dulce";
            objectlist.AddProductos(p10);

            Sale s1 = new Sale();
            s1.comments = "VentasRealizadas";
            s1.Ventas = 11;
            objectlist.AddSales(s1);

            Sale s2 = new Sale();
            s2.comments = "VentasRealizadas";
            s2.Ventas = 34;
            objectlist.AddSales(s2);

            Sale s3 = new Sale();
            s3.comments = "VentasRealizadas";
            s3.Ventas = 21;
            objectlist.AddSales(s3);

            Sale s4 = new Sale();
            s4.comments = "VentasRealizadas";
            s4.Ventas = 39;
            objectlist.AddSales(s4);

            Sale s5 = new Sale();
            s5.comments = "VentasRealizadas";
            s5.Ventas = 45;
            objectlist.AddSales(s5);

            Sale s6 = new Sale();
            s6.comments = "VentasRealizadas";
            s6.Ventas = 56;
            objectlist.AddSales(s6);

            Sale s7 = new Sale();
            s7.comments = "VentasRealizadas";
            s7.Ventas = 60;
            objectlist.AddSales(s7);

            Sale s8 = new Sale();
            s8.comments = "VentasRealizadas";
            s8.Ventas = 71;
            objectlist.AddSales(s8);

            Sale s9 = new Sale();
            s9.comments = "VentasRealizadas";
            s9.Ventas = 31;
            objectlist.AddSales(s9);

            Sale s10 = new Sale();
            s10.comments = "VentasRealizadas";
            s10.Ventas = 19;
            objectlist.AddSales(s10);


            objectlist.CheaperProduct();
            objectlist.AverageProductPrice();
            objectlist.Soldproducts();
            objectlist.MostExpensiveProduct();
        }
    }
}

