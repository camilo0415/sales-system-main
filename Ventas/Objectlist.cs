using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class Objectlist
    {
        int count = 0;

        Seller[] Vendedores = new Seller[20];  //Vendedores es el nombre de la lista, el 20 significa posiciones de 0 a 19
        int countVendedor = 0;

        Product[] Productos = new Product[20];//estas listas tranajaran con length
        int countProducto = 0;

        List<Sale> Sales = new List<Sale>();    //lista vacia va a trabajar count
        int countSale = 0;

        public void AddVendedores(Seller seller)
        {
            Vendedores[countVendedor] = seller;
            countVendedor++;
        }

        public void AddProductos(Product product)
        {
            Productos[countProducto] = product;
            countProducto++;
        }

        public void AddSales(Sale sale)
        {
            if (count < countVendedor)
            {
                Sales.Add(new Sale()
                {
                    Seller = Vendedores[count],
                    Product = Productos[countSale],
                    Ventas = sale.Ventas,
                    comments = sale.comments
                });
                countSale++;
                count++;
            }
            else
            {
                count = 0;
                Sales.Add(new Sale()
                {
                    Seller = Vendedores[count],
                    Product = Productos[countSale],
                    Ventas = sale.Ventas,
                    comments = sale.comments
                });
                countSale++;
                count++;
            }

        }

        public void CheaperProduct()
        {
            string nombreVendedores = "";
            string nombreProductos = "";
            double precioProducto = 0;
            string categoriaProducto = "";
            double value = 0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double price = Sales[i].Product.Price;

                if (value == 0)
                {
                    nombreVendedores = Sales[i].Seller.Name;
                    nombreProductos = Sales[i].Product.Name;
                    precioProducto = Sales[i].Product.Price;
                    categoriaProducto = Sales[i].Product.Categoria;
                    value = precioProducto;
                }
                else if (price < value)
                {
                    nombreVendedores = Sales[i].Seller.Name;
                    nombreProductos = Sales[i].Product.Name;
                    precioProducto = Sales[i].Product.Price;
                    categoriaProducto = Sales[i].Product.Categoria;
                    value = precioProducto;
                }
            }

            Console.WriteLine("Vendedor y producto mas barato");
            Console.WriteLine("Nombre: " + nombreVendedores);
            Console.WriteLine("Producto: " + nombreProductos);
            Console.WriteLine("Precio: " + precioProducto);
            Console.WriteLine("Categoria: " + categoriaProducto);
        }

        public void AverageProductPrice()      //Precio Medio De Productos
        {
            double precioProductos = 0;//priceproduct
            double preciodelproducto = 0;//productprice
            double averagePriceProducts = 0;

            for (int i = 0; i < countProducto; i++)
            {
                preciodelproducto = Productos[i].Price;
                precioProductos = precioProductos + preciodelproducto;
            }

            averagePriceProducts = precioProductos / countProducto;
            Console.WriteLine("Precio medio de los productos.");
            Console.WriteLine("Precio promedio: " + averagePriceProducts);
        }

        public void Soldproducts()
        {
            string nombreProducto = "";
            double cantidad = 0;


            for (int i = 0; i < Sales.Count; i++)
            {

                nombreProducto = Sales[i].Product.Name;
                cantidad = Sales[i].Ventas;

                Console.WriteLine("Cuántas unidades del producto se han vendido.");
                Console.WriteLine("Nombre Del producto" + nombreProducto);
                Console.WriteLine("Cantidad producto " + cantidad);

            }


        }

        public void MostExpensiveProduct()
        {
            string nameProduct = "";
            double priceProduct = 0;
            double value = 0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double price = Sales[i].Product.Price;

                if (value == 0)
                {
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    value = priceProduct;
                }
                else if (price > value)
                {
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    value = priceProduct;
                }
            }

            Console.WriteLine("el producto más caro");
            Console.WriteLine("Producto: " + nameProduct);
            Console.WriteLine("Precio: " + priceProduct);





        }   }
}
