﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
	//SOLID
	//O: Open Closed Principle
	class Program
	{
		static void Main(string[] args)
		{
			ProductTest();
			//CategoryTest();
			//ProductManager productManager = new ProductManager(new EfProductDal());

			//foreach (var product in productManager.GetProductsDetails().Data)
			//{
			//	Console.WriteLine(product.ProductName + "/"+ product.CategoryName);
			//}
		}

		private static void CategoryTest()
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());

			var result = productManager.GetProductsDetails();
			if (result.Success==true)
			{
				foreach (var product in result.Data)
				{
						Console.WriteLine(product.ProductName + "/"+ product.CategoryName);
				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}

			
		}
	}
}
