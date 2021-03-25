using CollectionViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewDemo.ViewModels
{
    class MainPageViewModels
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainPageViewModels()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Yogurt",
                    Price = 1000.00m,
                    Image = "yogurt.png",
                    
                },
                new Product
                {
                    Name = "Watermelon",
                    Price = 30000.00m,
                    Image = "watermelon.png",
                   
                },
                new Product
                {
                    Name = "Water Bottle",
                    Price = 800000.00m,
                    Image = "water_bottle.png",
                    
                },
                new Product
                {
                    Name = "Tomato",
                    Price = 1000000.00m,
                    Image = "tomato.png",
                    
                },
                new Product
                {
                    Name = "Tea",
                    Price = 65.00m,
                    Image = "tea_bag.png",
                   
                },
                new Product
                {
                    Name = "Sparkling Drink",
                    Price = 35.00m,
                    Image = "sparkling_drink.png",
                   
                },
                new Product
                {
                    Name = "Spaguetti",
                    Price = 15.00m,
                    Image = "spaguetti.png",
                   
                },
                new Product
                {
                    Name = "Cream",
                    Price = 48.00m,
                    Image = "cream.png",
                    
                },
                new Product
                {
                    Name = "Snack",
                    Price = 25.00m,
                    Image = "snack.png",
                   
                },
                new Product
                {
                    Name = "Shrimp",
                    Price = 300.00m,
                    Image = "shrimp.png",
                    
                },
                new Product
                {
                    Name = "Seasoning",
                    Price = 185.00m,
                    Image = "seasoning.png",
                   
                },
                new Product
                {
                    Name = "Sauce",
                    Price = 220.00m,
                    Image = "sauce.png",
                    
                },
                new Product
                {
                    Name = "Rice",
                    Price = 48.00m,
                    Image = "rice.png",
                    
                },
                new Product
                {
                    Name = "Peas",
                    Price = 114.00m,
                    Image = "peas.png",
                    
                },
                new Product
                {
                    Name = "Ham",
                    Price = 215.00m,
                    Image = "ham_1.png",
                   
                },
                new Product
                {
                    Name = "Chicken Leg",
                    Price = 142.00m,
                    Image = "chicken_leg.png",
                    
                },
                new Product
                {
                    Name = "Pizza",
                    Price = 321.00m,
                    Image = "pizza.png",
                    
                },
                new Product
                {
                    Name = "Pineapple",
                    Price = 49.00m,
                    Image = "pineapple.png",
                   
                },
                new Product
                {
                    Name = "Pepper",
                    Price = 60.00m,
                    Image = "pepper.png",
                   
                },
                new Product
                {
                    Name = "Pasta",
                    Price = 52.00m,
                    Image = "pasta.png",
                    
                },
                new Product
                {
                    Name = "Oil Bottle",
                    Price = 152.00m,
                    Image = "oil_bottle",
                    
                },
                new Product
                {
                    Name = "Mushroom",
                    Price = 28.00m,
                    Image = "mushroom.png",
                    
                },
                new Product
                {
                    Name = "Milk Bottle",
                    Price = 85.00m,
                    Image = "milk_bottle.png",
                    
                },
                new Product
                {
                    Name = "Meat",
                    Price = 450.00m,
                    Image = "meat.png",
                    
                },
                new Product
                {
                    Name = "Lemon",
                    Price = 20.0m,
                    Image = "lemon.png",
                    
                },
                new Product
                {
                    Name = "Tomato Sauce",
                    Price = 15.0m,
                    Image = "tomato_sauce.png",
                    
                },
                new Product
                {
                    Name = "Juice",
                    Price = 60.0m,
                    Image = "juice.png",
                    
                },
                new Product
                {
                    Name = "Ice Cream",
                    Price = 251.0m,
                    Image = "ice_cream.png",
                   
                },
                new Product
                {
                    Name = "Ham",
                    Price = 290.0m,
                    Image = "ham.png",
                   
                },
                new Product
                {
                    Name = "Ice",
                    Price = 125.0m,
                    Image = "ice.png",
                    
                },
                new Product
                {
                    Name = "Flour",
                    Price = 86.0m,
                    Image = "flour.png",
                    
                },
                new Product
                {
                    Name = "Fish",
                    Price = 440.0m,
                    Image = "fish_1.png",
                    
                },
                new Product
                {
                    Name = "Fish 2",
                    Price = 425.0m,
                    Image = "fish.png",
                   
                },
                new Product
                {
                    Name = "Eggs",
                    Price = 150.0m,
                    Image = "eggs.png",
                    
                },
                new Product
                {
                    Name = "Cucumber",
                    Price = 35.0m,
                    Image = "cucumber.png",
                    
                },
                new Product
                {
                    Name = "Croissant",
                    Price = 68.0m,
                    Image = "croissant.png",
                   
                },
                new Product
                {
                    Name = "Cookies",
                    Price = 95.0m,
                    Image = "cookie.png",
                   
                },
                new Product
                {
                    Name = "Coffee",
                    Price = 154.0m,
                    Image = "toffee.png",
                   
                },
                new Product
                {
                    Name = "Chocolate Bar",
                    Price = 32.0m,
                    Image = "chocolate_bar.png",
                    
                },
                new Product
                {
                    Name = "Cheese",
                    Price = 36.0m,
                    Image = "cheese.png",
                   
                },
                new Product
                {
                    Name = "Carrot",
                    Price = 15.0m,
                    Image = "carrot.png",
                    
                },
                new Product
                {
                    Name = "Canned Food",
                    Price = 89.0m,
                    Image = "canned_food.png",
                   
                },
                new Product
                {
                    Name = "Soda",
                    Price = 45.0m,
                    Image = "can.png",
                    
                },
                new Product
                {
                    Name = "Candies",
                    Price = 55.0m,
                    Image = "candy.png",
                   
                },
                new Product
                {
                    Name = "Cake",
                    Price = 250.0m,
                    Image = "cake.png",
                   
                },
                new Product
                {
                    Name = "Bread",
                    Price = 100.0m,
                    Image = "bread_1.png",
                    
                },
                new Product
                {
                    Name = "Bread",
                    Price = 85.0m,
                    Image = "bread.png",
                    
                },
                new Product
                {
                    Name = "Banana",
                    Price = 15.0m,
                    Image = "banana.png",
                    
                },
                new Product
                {
                    Name = "Apple",
                    Price = 40.0m,
                    Image = "apple.png",
                   
                },
                new Product
                {
                    Name = "Alcohol",
                    Price = 370.0m,
                    Image = "apple.png",
                    
                },
            };

        }
    }
}
