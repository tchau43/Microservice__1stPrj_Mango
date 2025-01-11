using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 1,
				Name = "Samosa",
				Price = 15,
				Description = " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.",
				ImageUrl = "https://placehold.co/603x403",
				CategoryName = "Appetizer"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 2,
				Name = "Paneer Tikka",
				Price = 13.99,
				Description = " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.",
				ImageUrl = "https://placehold.co/602x402",
				CategoryName = "Appetizer"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 3,
				Name = "Sweet Pie",
				Price = 10.99,
				Description = " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.",
				ImageUrl = "https://placehold.co/601x401",
				CategoryName = "Dessert"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 4,
				Name = "Pav Bhaji",
				Price = 15,
				Description = " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.",
				ImageUrl = "https://placehold.co/600x400",
				CategoryName = "Entree"
			},

			new Product
			{
				ProductId = 5,
				Name = "Chicken Tikka Masala",
				Price = 13.99,
				Description = "Tender chicken pieces in a creamy spiced tomato sauce.",
				ImageUrl = "https://placehold.co/600x400?text=Chicken+Tikka+Masala",
				CategoryName = "Entree"
			},
new Product
{
	ProductId = 6,
	Name = "Beef Burger",
	Price = 11.99,
	Description = "Juicy beef patty with lettuce, tomato, and cheese in a toasted bun.",
	ImageUrl = "https://placehold.co/600x400?text=Beef+Burger",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 7,
	Name = "Vegetable Spring Rolls",
	Price = 6.99,
	Description = "Crispy spring rolls filled with fresh vegetables.",
	ImageUrl = "https://placehold.co/600x400?text=Vegetable+Spring+Rolls",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 8,
	Name = "Mango Lassi",
	Price = 4.99,
	Description = "Refreshing yogurt-based mango drink.",
	ImageUrl = "https://placehold.co/600x400?text=Mango+Lassi",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 9,
	Name = "Chocolate Lava Cake",
	Price = 7.99,
	Description = "Warm chocolate cake with a molten chocolate center.",
	ImageUrl = "https://placehold.co/600x400?text=Chocolate+Lava+Cake",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 10,
	Name = "Tomato Soup",
	Price = 5.99,
	Description = "Creamy tomato soup garnished with fresh herbs.",
	ImageUrl = "https://placehold.co/600x400?text=Tomato+Soup",
	CategoryName = "Soup"
},
// Products 11-100
new Product
{
	ProductId = 11,
	Name = "Grilled Salmon",
	Price = 18.99,
	Description = "Fresh salmon fillet grilled to perfection with lemon butter.",
	ImageUrl = "https://placehold.co/600x400?text=Grilled+Salmon",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 12,
	Name = "Garlic Bread",
	Price = 4.99,
	Description = "Toasted bread topped with garlic and herbs.",
	ImageUrl = "https://placehold.co/600x400?text=Garlic+Bread",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 13,
	Name = "Iced Tea",
	Price = 2.99,
	Description = "Chilled black tea served with ice and lemon.",
	ImageUrl = "https://placehold.co/600x400?text=Iced+Tea",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 14,
	Name = "Cheesecake",
	Price = 6.99,
	Description = "Classic creamy cheesecake with a graham cracker crust.",
	ImageUrl = "https://placehold.co/600x400?text=Cheesecake",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 15,
	Name = "French Onion Soup",
	Price = 6.50,
	Description = "Rich beef broth with caramelized onions and melted cheese.",
	ImageUrl = "https://placehold.co/600x400?text=French+Onion+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 16,
	Name = "BBQ Ribs",
	Price = 19.99,
	Description = "Tender pork ribs smothered in BBQ sauce.",
	ImageUrl = "https://placehold.co/600x400?text=BBQ+Ribs",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 17,
	Name = "Bruschetta",
	Price = 5.99,
	Description = "Grilled bread topped with fresh tomatoes, basil, and olive oil.",
	ImageUrl = "https://placehold.co/600x400?text=Bruschetta",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 18,
	Name = "Lemonade",
	Price = 3.50,
	Description = "Freshly squeezed lemonade with a hint of mint.",
	ImageUrl = "https://placehold.co/600x400?text=Lemonade",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 19,
	Name = "Tiramisu",
	Price = 6.50,
	Description = "Italian dessert with layers of coffee-soaked ladyfingers and mascarpone cream.",
	ImageUrl = "https://placehold.co/600x400?text=Tiramisu",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 20,
	Name = "Minestrone Soup",
	Price = 5.99,
	Description = "Hearty vegetable soup with beans and pasta.",
	ImageUrl = "https://placehold.co/600x400?text=Minestrone+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 21,
	Name = "Chicken Alfredo",
	Price = 16.99,
	Description = "Grilled chicken breast served over fettuccine in a creamy Alfredo sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Alfredo",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 22,
	Name = "Stuffed Mushrooms",
	Price = 7.99,
	Description = "Mushroom caps filled with cheese and herbs, baked to perfection.",
	ImageUrl = "https://placehold.co/600x400?text=Stuffed+Mushrooms",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 23,
	Name = "Espresso",
	Price = 3.00,
	Description = "Strong and rich Italian coffee served in a small cup.",
	ImageUrl = "https://placehold.co/600x400?text=Espresso",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 24,
	Name = "Apple Pie",
	Price = 5.99,
	Description = "Traditional apple pie with a flaky crust and cinnamon-spiced filling.",
	ImageUrl = "https://placehold.co/600x400?text=Apple+Pie",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 25,
	Name = "Clam Chowder",
	Price = 6.99,
	Description = "Creamy soup loaded with clams, potatoes, and vegetables.",
	ImageUrl = "https://placehold.co/600x400?text=Clam+Chowder",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 26,
	Name = "Steak Frites",
	Price = 21.99,
	Description = "Grilled steak served with crispy french fries and herb butter.",
	ImageUrl = "https://placehold.co/600x400?text=Steak+Frites",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 27,
	Name = "Mozzarella Sticks",
	Price = 6.50,
	Description = "Fried mozzarella cheese sticks served with marinara sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Mozzarella+Sticks",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 28,
	Name = "Green Smoothie",
	Price = 4.50,
	Description = "A blend of fresh spinach, banana, and almond milk.",
	ImageUrl = "https://placehold.co/600x400?text=Green+Smoothie",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 29,
	Name = "Cheesecake Brownie",
	Price = 7.50,
	Description = "Decadent brownie topped with creamy cheesecake.",
	ImageUrl = "https://placehold.co/600x400?text=Cheesecake+Brownie",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 30,
	Name = "Lentil Soup",
	Price = 5.50,
	Description = "Hearty lentil soup with vegetables and spices.",
	ImageUrl = "https://placehold.co/600x400?text=Lentil+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 31,
	Name = "Shrimp Scampi",
	Price = 17.99,
	Description = "Succulent shrimp sautéed in garlic butter sauce over linguine.",
	ImageUrl = "https://placehold.co/600x400?text=Shrimp+Scampi",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 32,
	Name = "Chicken Wings",
	Price = 8.99,
	Description = "Spicy grilled chicken wings served with blue cheese dip.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Wings",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 33,
	Name = "Iced Coffee",
	Price = 3.99,
	Description = "Chilled coffee served over ice with optional milk and sweetener.",
	ImageUrl = "https://placehold.co/600x400?text=Iced+Coffee",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 34,
	Name = "Banana Split",
	Price = 6.99,
	Description = "Classic banana split with ice cream, chocolate syrup, and cherries.",
	ImageUrl = "https://placehold.co/600x400?text=Banana+Split",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 35,
	Name = "Chicken Noodle Soup",
	Price = 5.99,
	Description = "Comforting soup with tender chicken, noodles, and vegetables.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Noodle+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 36,
	Name = "Fish and Chips",
	Price = 15.99,
	Description = "Crispy battered fish served with golden french fries and tartar sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Fish+and+Chips",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 37,
	Name = "Nachos Supreme",
	Price = 9.99,
	Description = "Tortilla chips topped with cheese, jalapeños, sour cream, and salsa.",
	ImageUrl = "https://placehold.co/600x400?text=Nachos+Supreme",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 38,
	Name = "Mojito",
	Price = 5.50,
	Description = "Refreshing cocktail with rum, lime, mint, sugar, and soda water.",
	ImageUrl = "https://placehold.co/600x400?text=Mojito",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 39,
	Name = "Apple Crumble",
	Price = 6.50,
	Description = "Warm apple dessert topped with a crumbly oat topping.",
	ImageUrl = "https://placehold.co/600x400?text=Apple+Crumble",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 40,
	Name = "Pumpkin Soup",
	Price = 5.99,
	Description = "Creamy pumpkin soup seasoned with spices and garnished with cream.",
	ImageUrl = "https://placehold.co/600x400?text=Pumpkin+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 41,
	Name = "Beef Stroganoff",
	Price = 17.99,
	Description = "Tender beef in a creamy mushroom sauce served over egg noodles.",
	ImageUrl = "https://placehold.co/600x400?text=Beef+Stroganoff",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 42,
	Name = "Garlic Knots",
	Price = 4.50,
	Description = "Soft dough knots brushed with garlic butter and herbs.",
	ImageUrl = "https://placehold.co/600x400?text=Garlic+Knots",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 43,
	Name = "Chai Latte",
	Price = 4.00,
	Description = "Spiced tea latte made with black tea, spices, milk, and sweetener.",
	ImageUrl = "https://placehold.co/600x400?text=Chai+Latte",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 44,
	Name = "Panna Cotta",
	Price = 6.99,
	Description = "Silky smooth Italian dessert made with sweetened cream and gelatin.",
	ImageUrl = "https://placehold.co/600x400?text=Panna+Cotta",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 45,
	Name = "Tom Yum Soup",
	Price = 6.99,
	Description = "Spicy and sour Thai soup with shrimp, mushrooms, and herbs.",
	ImageUrl = "https://placehold.co/600x400?text=Tom+Yum+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 46,
	Name = "Lamb Curry",
	Price = 18.99,
	Description = "Slow-cooked lamb in a rich and flavorful curry sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Lamb+Curry",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 47,
	Name = "Onion Rings",
	Price = 5.99,
	Description = "Crispy battered onion rings served with dipping sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Onion+Rings",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 48,
	Name = "Hot Chocolate",
	Price = 3.50,
	Description = "Rich and creamy hot chocolate topped with whipped cream.",
	ImageUrl = "https://placehold.co/600x400?text=Hot+Chocolate",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 49,
	Name = "Key Lime Pie",
	Price = 6.50,
	Description = "Tangy key lime pie with a graham cracker crust and whipped cream.",
	ImageUrl = "https://placehold.co/600x400?text=Key+Lime+Pie",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 50,
	Name = "French Lentil Soup",
	Price = 6.00,
	Description = "Hearty French lentil soup with vegetables and herbs.",
	ImageUrl = "https://placehold.co/600x400?text=French+Lentil+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 51,
	Name = "Vegetable Lasagna",
	Price = 15.99,
	Description = "Layers of pasta, vegetables, ricotta, and marinara sauce baked to perfection.",
	ImageUrl = "https://placehold.co/600x400?text=Vegetable+Lasagna",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 52,
	Name = "Buffalo Chicken Dip",
	Price = 7.99,
	Description = "Creamy and spicy dip made with shredded chicken and buffalo sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Buffalo+Chicken+Dip",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 53,
	Name = "Iced Matcha Latte",
	Price = 4.50,
	Description = "Chilled green tea latte made with matcha powder and milk.",
	ImageUrl = "https://placehold.co/600x400?text=Iced+Matcha+Latte",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 54,
	Name = "Strawberry Shortcake",
	Price = 6.99,
	Description = "Delicious shortcake layered with fresh strawberries and whipped cream.",
	ImageUrl = "https://placehold.co/600x400?text=Strawberry+Shortcake",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 55,
	Name = "Beef Pho",
	Price = 12.99,
	Description = "Traditional Vietnamese noodle soup with beef and aromatic herbs.",
	ImageUrl = "https://placehold.co/600x400?text=Beef+Pho",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 56,
	Name = "Teriyaki Chicken",
	Price = 14.99,
	Description = "Grilled chicken glazed with sweet and savory teriyaki sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Teriyaki+Chicken",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 57,
	Name = "Hummus Platter",
	Price = 8.99,
	Description = "Creamy hummus served with pita bread and fresh vegetables.",
	ImageUrl = "https://placehold.co/600x400?text=Hummus+Platter",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 58,
	Name = "Fresh Orange Juice",
	Price = 3.99,
	Description = "Cold-pressed orange juice made from fresh oranges.",
	ImageUrl = "https://placehold.co/600x400?text=Fresh+Orange+Juice",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 59,
	Name = "Chocolate Mousse",
	Price = 6.99,
	Description = "Light and airy chocolate mousse topped with whipped cream.",
	ImageUrl = "https://placehold.co/600x400?text=Chocolate+Mousse",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 60,
	Name = "Chicken Tortilla Soup",
	Price = 6.99,
	Description = "Spicy soup with chicken, tomatoes, beans, and tortilla strips.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Tortilla+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 61,
	Name = "Shrimp Alfredo",
	Price = 16.99,
	Description = "Succulent shrimp in creamy Alfredo sauce served over fettuccine.",
	ImageUrl = "https://placehold.co/600x400?text=Shrimp+Alfredo",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 62,
	Name = "Spinach Artichoke Dip",
	Price = 7.99,
	Description = "Creamy dip made with spinach, artichokes, and melted cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Spinach+Artichoke+Dip",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 63,
	Name = "Cold Brew Coffee",
	Price = 3.50,
	Description = "Smooth and rich cold brew coffee served over ice.",
	ImageUrl = "https://placehold.co/600x400?text=Cold+Brew+Coffee",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 64,
	Name = "Lemon Tart",
	Price = 6.50,
	Description = "Tangy lemon tart with a buttery crust and sweet glaze.",
	ImageUrl = "https://placehold.co/600x400?text=Lemon+Tart",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 65,
	Name = "Miso Soup",
	Price = 4.99,
	Description = "Traditional Japanese soup with miso paste, tofu, and seaweed.",
	ImageUrl = "https://placehold.co/600x400?text=Miso+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 66,
	Name = "Beef Tacos",
	Price = 13.99,
	Description = "Soft tortillas filled with seasoned beef, lettuce, and cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Beef+Tacos",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 67,
	Name = "Deviled Eggs",
	Price = 5.99,
	Description = "Classic deviled eggs with a creamy yolk filling.",
	ImageUrl = "https://placehold.co/600x400?text=Deviled+Eggs",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 68,
	Name = "Herbal Iced Tea",
	Price = 3.50,
	Description = "Refreshing iced tea infused with herbal flavors.",
	ImageUrl = "https://placehold.co/600x400?text=Herbal+Iced+Tea",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 69,
	Name = "Pavlova",
	Price = 7.99,
	Description = "Light meringue dessert topped with whipped cream and fresh fruits.",
	ImageUrl = "https://placehold.co/600x400?text=Pavlova",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 70,
	Name = "Clam Chowder",
	Price = 6.99,
	Description = "Creamy New England clam chowder with tender clams and potatoes.",
	ImageUrl = "https://placehold.co/600x400?text=Clam+Chowder",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 71,
	Name = "Eggplant Parmesan",
	Price = 14.99,
	Description = "Breaded eggplant slices layered with marinara and mozzarella cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Eggplant+Parmesan",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 72,
	Name = "Chicken Satay",
	Price = 7.99,
	Description = "Grilled chicken skewers served with peanut sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Satay",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 73,
	Name = "Matcha Green Tea",
	Price = 3.50,
	Description = "Traditional Japanese green tea made from matcha powder.",
	ImageUrl = "https://placehold.co/600x400?text=Matcha+Green+Tea",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 74,
	Name = "Baklava",
	Price = 6.99,
	Description = "Sweet pastry made of layers of filo filled with chopped nuts and honey.",
	ImageUrl = "https://placehold.co/600x400?text=Baklava",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 75,
	Name = "Pumpkin Bisque",
	Price = 5.99,
	Description = "Smooth and creamy pumpkin soup seasoned with spices.",
	ImageUrl = "https://placehold.co/600x400?text=Pumpkin+Bisque",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 76,
	Name = "Chicken Quesadilla",
	Price = 12.99,
	Description = "Grilled tortilla filled with seasoned chicken and melted cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Quesadilla",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 77,
	Name = "Stuffed Peppers",
	Price = 8.99,
	Description = "Bell peppers stuffed with rice, vegetables, and cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Stuffed+Peppers",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 78,
	Name = "Iced Matcha Smoothie",
	Price = 4.50,
	Description = "Blended matcha green tea with ice and milk for a refreshing smoothie.",
	ImageUrl = "https://placehold.co/600x400?text=Iced+Matcha+Smoothie",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 79,
	Name = "Fruit Tart",
	Price = 7.99,
	Description = "Colorful tart filled with custard and topped with fresh fruits.",
	ImageUrl = "https://placehold.co/600x400?text=Fruit+Tart",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 80,
	Name = "Vegetable Soup",
	Price = 5.99,
	Description = "Healthy vegetable soup packed with seasonal veggies.",
	ImageUrl = "https://placehold.co/600x400?text=Vegetable+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 81,
	Name = "Beef Burrito",
	Price = 13.99,
	Description = "Large flour tortilla filled with seasoned beef, beans, and cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Beef+Burrito",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 82,
	Name = "Bruschetta",
	Price = 5.99,
	Description = "Grilled bread topped with diced tomatoes, garlic, and basil.",
	ImageUrl = "https://placehold.co/600x400?text=Bruschetta",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 83,
	Name = "Green Tea Latte",
	Price = 4.50,
	Description = "Creamy latte made with green tea and steamed milk.",
	ImageUrl = "https://placehold.co/600x400?text=Green+Tea+Latte",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 84,
	Name = "Chocolate Chip Cookies",
	Price = 5.99,
	Description = "Freshly baked cookies loaded with chocolate chips.",
	ImageUrl = "https://placehold.co/600x400?text=Chocolate+Chip+Cookies",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 85,
	Name = "Tomato Basil Soup",
	Price = 5.99,
	Description = "Creamy tomato soup infused with fresh basil.",
	ImageUrl = "https://placehold.co/600x400?text=Tomato+Basil+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 86,
	Name = "Chicken Parmesan",
	Price = 16.99,
	Description = "Breaded chicken breast topped with marinara and melted cheese.",
	ImageUrl = "https://placehold.co/600x400?text=Chicken+Parmesan",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 87,
	Name = "Buffalo Cauliflower Bites",
	Price = 7.99,
	Description = "Spicy roasted cauliflower florets served with dipping sauce.",
	ImageUrl = "https://placehold.co/600x400?text=Buffalo+Cauliflower+Bites",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 88,
	Name = "Cappuccino",
	Price = 3.99,
	Description = "Espresso-based coffee drink with steamed milk foam.",
	ImageUrl = "https://placehold.co/600x400?text=Cappuccino",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 89,
	Name = "Molten Chocolate Cake",
	Price = 7.99,
	Description = "Warm chocolate cake with a gooey molten center.",
	ImageUrl = "https://placehold.co/600x400?text=Molten+Chocolate+Cake",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 90,
	Name = "Clam Chowder",
	Price = 6.99,
	Description = "Creamy chowder loaded with clams, potatoes, and vegetables.",
	ImageUrl = "https://placehold.co/600x400?text=Clam+Chowder",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 91,
	Name = "Vegetable Stir Fry",
	Price = 14.99,
	Description = "Mixed vegetables stir-fried in a savory sauce served over rice.",
	ImageUrl = "https://placehold.co/600x400?text=Vegetable+Stir+Fry",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 92,
	Name = "Garlic Shrimp",
	Price = 8.99,
	Description = "Shrimp sautéed with garlic and herbs.",
	ImageUrl = "https://placehold.co/600x400?text=Garlic+Shrimp",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 93,
	Name = "Berry Smoothie",
	Price = 4.50,
	Description = "Blend of mixed berries, yogurt, and honey.",
	ImageUrl = "https://placehold.co/600x400?text=Berry+Smoothie",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 94,
	Name = "Pecan Pie",
	Price = 6.99,
	Description = "Sweet and nutty pecan pie with a flaky crust.",
	ImageUrl = "https://placehold.co/600x400?text=Pecan+Pie",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 95,
	Name = "Beef and Barley Soup",
	Price = 6.99,
	Description = "Hearty soup with tender beef, barley, and vegetables.",
	ImageUrl = "https://placehold.co/600x400?text=Beef+and+Barley+Soup",
	CategoryName = "Soup"
},
new Product
{
	ProductId = 96,
	Name = "Pork Schnitzel",
	Price = 17.99,
	Description = "Breaded and fried pork cutlet served with lemon wedges.",
	ImageUrl = "https://placehold.co/600x400?text=Pork+Schnitzel",
	CategoryName = "Entree"
},
new Product
{
	ProductId = 97,
	Name = "Caprese Salad",
	Price = 7.99,
	Description = "Fresh mozzarella, tomatoes, and basil drizzled with balsamic glaze.",
	ImageUrl = "https://placehold.co/600x400?text=Caprese+Salad",
	CategoryName = "Appetizer"
},
new Product
{
	ProductId = 98,
	Name = "Fruit Infused Water",
	Price = 2.99,
	Description = "Refreshing water infused with a mix of fresh fruits.",
	ImageUrl = "https://placehold.co/600x400?text=Fruit+Infused+Water",
	CategoryName = "Beverage"
},
new Product
{
	ProductId = 99,
	Name = "Peach Cobbler",
	Price = 6.99,
	Description = "Warm cobbler filled with sweet peaches and topped with a biscuit crust.",
	ImageUrl = "https://placehold.co/600x400?text=Peach+Cobbler",
	CategoryName = "Dessert"
},
new Product
{
	ProductId = 100,
	Name = "Sweet Potato Soup",
	Price = 5.99,
	Description = "Creamy sweet potato soup seasoned with cinnamon and nutmeg.",
	ImageUrl = "https://placehold.co/600x400?text=Sweet+Potato+Soup",
	CategoryName = "Soup"
}

			);

		}
	}
}
