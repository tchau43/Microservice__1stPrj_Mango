using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "Entree", "Tender chicken pieces in a creamy spiced tomato sauce.", null, "https://placehold.co/600x400?text=Chicken+Tikka+Masala", "Chicken Tikka Masala", 13.99 },
                    { 6, "Entree", "Juicy beef patty with lettuce, tomato, and cheese in a toasted bun.", null, "https://placehold.co/600x400?text=Beef+Burger", "Beef Burger", 11.99 },
                    { 7, "Appetizer", "Crispy spring rolls filled with fresh vegetables.", null, "https://placehold.co/600x400?text=Vegetable+Spring+Rolls", "Vegetable Spring Rolls", 6.9900000000000002 },
                    { 8, "Beverage", "Refreshing yogurt-based mango drink.", null, "https://placehold.co/600x400?text=Mango+Lassi", "Mango Lassi", 4.9900000000000002 },
                    { 9, "Dessert", "Warm chocolate cake with a molten chocolate center.", null, "https://placehold.co/600x400?text=Chocolate+Lava+Cake", "Chocolate Lava Cake", 7.9900000000000002 },
                    { 10, "Soup", "Creamy tomato soup garnished with fresh herbs.", null, "https://placehold.co/600x400?text=Tomato+Soup", "Tomato Soup", 5.9900000000000002 },
                    { 11, "Entree", "Fresh salmon fillet grilled to perfection with lemon butter.", null, "https://placehold.co/600x400?text=Grilled+Salmon", "Grilled Salmon", 18.989999999999998 },
                    { 12, "Appetizer", "Toasted bread topped with garlic and herbs.", null, "https://placehold.co/600x400?text=Garlic+Bread", "Garlic Bread", 4.9900000000000002 },
                    { 13, "Beverage", "Chilled black tea served with ice and lemon.", null, "https://placehold.co/600x400?text=Iced+Tea", "Iced Tea", 2.9900000000000002 },
                    { 14, "Dessert", "Classic creamy cheesecake with a graham cracker crust.", null, "https://placehold.co/600x400?text=Cheesecake", "Cheesecake", 6.9900000000000002 },
                    { 15, "Soup", "Rich beef broth with caramelized onions and melted cheese.", null, "https://placehold.co/600x400?text=French+Onion+Soup", "French Onion Soup", 6.5 },
                    { 16, "Entree", "Tender pork ribs smothered in BBQ sauce.", null, "https://placehold.co/600x400?text=BBQ+Ribs", "BBQ Ribs", 19.989999999999998 },
                    { 17, "Appetizer", "Grilled bread topped with fresh tomatoes, basil, and olive oil.", null, "https://placehold.co/600x400?text=Bruschetta", "Bruschetta", 5.9900000000000002 },
                    { 18, "Beverage", "Freshly squeezed lemonade with a hint of mint.", null, "https://placehold.co/600x400?text=Lemonade", "Lemonade", 3.5 },
                    { 19, "Dessert", "Italian dessert with layers of coffee-soaked ladyfingers and mascarpone cream.", null, "https://placehold.co/600x400?text=Tiramisu", "Tiramisu", 6.5 },
                    { 20, "Soup", "Hearty vegetable soup with beans and pasta.", null, "https://placehold.co/600x400?text=Minestrone+Soup", "Minestrone Soup", 5.9900000000000002 },
                    { 21, "Entree", "Grilled chicken breast served over fettuccine in a creamy Alfredo sauce.", null, "https://placehold.co/600x400?text=Chicken+Alfredo", "Chicken Alfredo", 16.989999999999998 },
                    { 22, "Appetizer", "Mushroom caps filled with cheese and herbs, baked to perfection.", null, "https://placehold.co/600x400?text=Stuffed+Mushrooms", "Stuffed Mushrooms", 7.9900000000000002 },
                    { 23, "Beverage", "Strong and rich Italian coffee served in a small cup.", null, "https://placehold.co/600x400?text=Espresso", "Espresso", 3.0 },
                    { 24, "Dessert", "Traditional apple pie with a flaky crust and cinnamon-spiced filling.", null, "https://placehold.co/600x400?text=Apple+Pie", "Apple Pie", 5.9900000000000002 },
                    { 25, "Soup", "Creamy soup loaded with clams, potatoes, and vegetables.", null, "https://placehold.co/600x400?text=Clam+Chowder", "Clam Chowder", 6.9900000000000002 },
                    { 26, "Entree", "Grilled steak served with crispy french fries and herb butter.", null, "https://placehold.co/600x400?text=Steak+Frites", "Steak Frites", 21.989999999999998 },
                    { 27, "Appetizer", "Fried mozzarella cheese sticks served with marinara sauce.", null, "https://placehold.co/600x400?text=Mozzarella+Sticks", "Mozzarella Sticks", 6.5 },
                    { 28, "Beverage", "A blend of fresh spinach, banana, and almond milk.", null, "https://placehold.co/600x400?text=Green+Smoothie", "Green Smoothie", 4.5 },
                    { 29, "Dessert", "Decadent brownie topped with creamy cheesecake.", null, "https://placehold.co/600x400?text=Cheesecake+Brownie", "Cheesecake Brownie", 7.5 },
                    { 30, "Soup", "Hearty lentil soup with vegetables and spices.", null, "https://placehold.co/600x400?text=Lentil+Soup", "Lentil Soup", 5.5 },
                    { 31, "Entree", "Succulent shrimp sautéed in garlic butter sauce over linguine.", null, "https://placehold.co/600x400?text=Shrimp+Scampi", "Shrimp Scampi", 17.989999999999998 },
                    { 32, "Appetizer", "Spicy grilled chicken wings served with blue cheese dip.", null, "https://placehold.co/600x400?text=Chicken+Wings", "Chicken Wings", 8.9900000000000002 },
                    { 33, "Beverage", "Chilled coffee served over ice with optional milk and sweetener.", null, "https://placehold.co/600x400?text=Iced+Coffee", "Iced Coffee", 3.9900000000000002 },
                    { 34, "Dessert", "Classic banana split with ice cream, chocolate syrup, and cherries.", null, "https://placehold.co/600x400?text=Banana+Split", "Banana Split", 6.9900000000000002 },
                    { 35, "Soup", "Comforting soup with tender chicken, noodles, and vegetables.", null, "https://placehold.co/600x400?text=Chicken+Noodle+Soup", "Chicken Noodle Soup", 5.9900000000000002 },
                    { 36, "Entree", "Crispy battered fish served with golden french fries and tartar sauce.", null, "https://placehold.co/600x400?text=Fish+and+Chips", "Fish and Chips", 15.99 },
                    { 37, "Appetizer", "Tortilla chips topped with cheese, jalapeños, sour cream, and salsa.", null, "https://placehold.co/600x400?text=Nachos+Supreme", "Nachos Supreme", 9.9900000000000002 },
                    { 38, "Beverage", "Refreshing cocktail with rum, lime, mint, sugar, and soda water.", null, "https://placehold.co/600x400?text=Mojito", "Mojito", 5.5 },
                    { 39, "Dessert", "Warm apple dessert topped with a crumbly oat topping.", null, "https://placehold.co/600x400?text=Apple+Crumble", "Apple Crumble", 6.5 },
                    { 40, "Soup", "Creamy pumpkin soup seasoned with spices and garnished with cream.", null, "https://placehold.co/600x400?text=Pumpkin+Soup", "Pumpkin Soup", 5.9900000000000002 },
                    { 41, "Entree", "Tender beef in a creamy mushroom sauce served over egg noodles.", null, "https://placehold.co/600x400?text=Beef+Stroganoff", "Beef Stroganoff", 17.989999999999998 },
                    { 42, "Appetizer", "Soft dough knots brushed with garlic butter and herbs.", null, "https://placehold.co/600x400?text=Garlic+Knots", "Garlic Knots", 4.5 },
                    { 43, "Beverage", "Spiced tea latte made with black tea, spices, milk, and sweetener.", null, "https://placehold.co/600x400?text=Chai+Latte", "Chai Latte", 4.0 },
                    { 44, "Dessert", "Silky smooth Italian dessert made with sweetened cream and gelatin.", null, "https://placehold.co/600x400?text=Panna+Cotta", "Panna Cotta", 6.9900000000000002 },
                    { 45, "Soup", "Spicy and sour Thai soup with shrimp, mushrooms, and herbs.", null, "https://placehold.co/600x400?text=Tom+Yum+Soup", "Tom Yum Soup", 6.9900000000000002 },
                    { 46, "Entree", "Slow-cooked lamb in a rich and flavorful curry sauce.", null, "https://placehold.co/600x400?text=Lamb+Curry", "Lamb Curry", 18.989999999999998 },
                    { 47, "Appetizer", "Crispy battered onion rings served with dipping sauce.", null, "https://placehold.co/600x400?text=Onion+Rings", "Onion Rings", 5.9900000000000002 },
                    { 48, "Beverage", "Rich and creamy hot chocolate topped with whipped cream.", null, "https://placehold.co/600x400?text=Hot+Chocolate", "Hot Chocolate", 3.5 },
                    { 49, "Dessert", "Tangy key lime pie with a graham cracker crust and whipped cream.", null, "https://placehold.co/600x400?text=Key+Lime+Pie", "Key Lime Pie", 6.5 },
                    { 50, "Soup", "Hearty French lentil soup with vegetables and herbs.", null, "https://placehold.co/600x400?text=French+Lentil+Soup", "French Lentil Soup", 6.0 },
                    { 51, "Entree", "Layers of pasta, vegetables, ricotta, and marinara sauce baked to perfection.", null, "https://placehold.co/600x400?text=Vegetable+Lasagna", "Vegetable Lasagna", 15.99 },
                    { 52, "Appetizer", "Creamy and spicy dip made with shredded chicken and buffalo sauce.", null, "https://placehold.co/600x400?text=Buffalo+Chicken+Dip", "Buffalo Chicken Dip", 7.9900000000000002 },
                    { 53, "Beverage", "Chilled green tea latte made with matcha powder and milk.", null, "https://placehold.co/600x400?text=Iced+Matcha+Latte", "Iced Matcha Latte", 4.5 },
                    { 54, "Dessert", "Delicious shortcake layered with fresh strawberries and whipped cream.", null, "https://placehold.co/600x400?text=Strawberry+Shortcake", "Strawberry Shortcake", 6.9900000000000002 },
                    { 55, "Soup", "Traditional Vietnamese noodle soup with beef and aromatic herbs.", null, "https://placehold.co/600x400?text=Beef+Pho", "Beef Pho", 12.99 },
                    { 56, "Entree", "Grilled chicken glazed with sweet and savory teriyaki sauce.", null, "https://placehold.co/600x400?text=Teriyaki+Chicken", "Teriyaki Chicken", 14.99 },
                    { 57, "Appetizer", "Creamy hummus served with pita bread and fresh vegetables.", null, "https://placehold.co/600x400?text=Hummus+Platter", "Hummus Platter", 8.9900000000000002 },
                    { 58, "Beverage", "Cold-pressed orange juice made from fresh oranges.", null, "https://placehold.co/600x400?text=Fresh+Orange+Juice", "Fresh Orange Juice", 3.9900000000000002 },
                    { 59, "Dessert", "Light and airy chocolate mousse topped with whipped cream.", null, "https://placehold.co/600x400?text=Chocolate+Mousse", "Chocolate Mousse", 6.9900000000000002 },
                    { 60, "Soup", "Spicy soup with chicken, tomatoes, beans, and tortilla strips.", null, "https://placehold.co/600x400?text=Chicken+Tortilla+Soup", "Chicken Tortilla Soup", 6.9900000000000002 },
                    { 61, "Entree", "Succulent shrimp in creamy Alfredo sauce served over fettuccine.", null, "https://placehold.co/600x400?text=Shrimp+Alfredo", "Shrimp Alfredo", 16.989999999999998 },
                    { 62, "Appetizer", "Creamy dip made with spinach, artichokes, and melted cheese.", null, "https://placehold.co/600x400?text=Spinach+Artichoke+Dip", "Spinach Artichoke Dip", 7.9900000000000002 },
                    { 63, "Beverage", "Smooth and rich cold brew coffee served over ice.", null, "https://placehold.co/600x400?text=Cold+Brew+Coffee", "Cold Brew Coffee", 3.5 },
                    { 64, "Dessert", "Tangy lemon tart with a buttery crust and sweet glaze.", null, "https://placehold.co/600x400?text=Lemon+Tart", "Lemon Tart", 6.5 },
                    { 65, "Soup", "Traditional Japanese soup with miso paste, tofu, and seaweed.", null, "https://placehold.co/600x400?text=Miso+Soup", "Miso Soup", 4.9900000000000002 },
                    { 66, "Entree", "Soft tortillas filled with seasoned beef, lettuce, and cheese.", null, "https://placehold.co/600x400?text=Beef+Tacos", "Beef Tacos", 13.99 },
                    { 67, "Appetizer", "Classic deviled eggs with a creamy yolk filling.", null, "https://placehold.co/600x400?text=Deviled+Eggs", "Deviled Eggs", 5.9900000000000002 },
                    { 68, "Beverage", "Refreshing iced tea infused with herbal flavors.", null, "https://placehold.co/600x400?text=Herbal+Iced+Tea", "Herbal Iced Tea", 3.5 },
                    { 69, "Dessert", "Light meringue dessert topped with whipped cream and fresh fruits.", null, "https://placehold.co/600x400?text=Pavlova", "Pavlova", 7.9900000000000002 },
                    { 70, "Soup", "Creamy New England clam chowder with tender clams and potatoes.", null, "https://placehold.co/600x400?text=Clam+Chowder", "Clam Chowder", 6.9900000000000002 },
                    { 71, "Entree", "Breaded eggplant slices layered with marinara and mozzarella cheese.", null, "https://placehold.co/600x400?text=Eggplant+Parmesan", "Eggplant Parmesan", 14.99 },
                    { 72, "Appetizer", "Grilled chicken skewers served with peanut sauce.", null, "https://placehold.co/600x400?text=Chicken+Satay", "Chicken Satay", 7.9900000000000002 },
                    { 73, "Beverage", "Traditional Japanese green tea made from matcha powder.", null, "https://placehold.co/600x400?text=Matcha+Green+Tea", "Matcha Green Tea", 3.5 },
                    { 74, "Dessert", "Sweet pastry made of layers of filo filled with chopped nuts and honey.", null, "https://placehold.co/600x400?text=Baklava", "Baklava", 6.9900000000000002 },
                    { 75, "Soup", "Smooth and creamy pumpkin soup seasoned with spices.", null, "https://placehold.co/600x400?text=Pumpkin+Bisque", "Pumpkin Bisque", 5.9900000000000002 },
                    { 76, "Entree", "Grilled tortilla filled with seasoned chicken and melted cheese.", null, "https://placehold.co/600x400?text=Chicken+Quesadilla", "Chicken Quesadilla", 12.99 },
                    { 77, "Appetizer", "Bell peppers stuffed with rice, vegetables, and cheese.", null, "https://placehold.co/600x400?text=Stuffed+Peppers", "Stuffed Peppers", 8.9900000000000002 },
                    { 78, "Beverage", "Blended matcha green tea with ice and milk for a refreshing smoothie.", null, "https://placehold.co/600x400?text=Iced+Matcha+Smoothie", "Iced Matcha Smoothie", 4.5 },
                    { 79, "Dessert", "Colorful tart filled with custard and topped with fresh fruits.", null, "https://placehold.co/600x400?text=Fruit+Tart", "Fruit Tart", 7.9900000000000002 },
                    { 80, "Soup", "Healthy vegetable soup packed with seasonal veggies.", null, "https://placehold.co/600x400?text=Vegetable+Soup", "Vegetable Soup", 5.9900000000000002 },
                    { 81, "Entree", "Large flour tortilla filled with seasoned beef, beans, and cheese.", null, "https://placehold.co/600x400?text=Beef+Burrito", "Beef Burrito", 13.99 },
                    { 82, "Appetizer", "Grilled bread topped with diced tomatoes, garlic, and basil.", null, "https://placehold.co/600x400?text=Bruschetta", "Bruschetta", 5.9900000000000002 },
                    { 83, "Beverage", "Creamy latte made with green tea and steamed milk.", null, "https://placehold.co/600x400?text=Green+Tea+Latte", "Green Tea Latte", 4.5 },
                    { 84, "Dessert", "Freshly baked cookies loaded with chocolate chips.", null, "https://placehold.co/600x400?text=Chocolate+Chip+Cookies", "Chocolate Chip Cookies", 5.9900000000000002 },
                    { 85, "Soup", "Creamy tomato soup infused with fresh basil.", null, "https://placehold.co/600x400?text=Tomato+Basil+Soup", "Tomato Basil Soup", 5.9900000000000002 },
                    { 86, "Entree", "Breaded chicken breast topped with marinara and melted cheese.", null, "https://placehold.co/600x400?text=Chicken+Parmesan", "Chicken Parmesan", 16.989999999999998 },
                    { 87, "Appetizer", "Spicy roasted cauliflower florets served with dipping sauce.", null, "https://placehold.co/600x400?text=Buffalo+Cauliflower+Bites", "Buffalo Cauliflower Bites", 7.9900000000000002 },
                    { 88, "Beverage", "Espresso-based coffee drink with steamed milk foam.", null, "https://placehold.co/600x400?text=Cappuccino", "Cappuccino", 3.9900000000000002 },
                    { 89, "Dessert", "Warm chocolate cake with a gooey molten center.", null, "https://placehold.co/600x400?text=Molten+Chocolate+Cake", "Molten Chocolate Cake", 7.9900000000000002 },
                    { 90, "Soup", "Creamy chowder loaded with clams, potatoes, and vegetables.", null, "https://placehold.co/600x400?text=Clam+Chowder", "Clam Chowder", 6.9900000000000002 },
                    { 91, "Entree", "Mixed vegetables stir-fried in a savory sauce served over rice.", null, "https://placehold.co/600x400?text=Vegetable+Stir+Fry", "Vegetable Stir Fry", 14.99 },
                    { 92, "Appetizer", "Shrimp sautéed with garlic and herbs.", null, "https://placehold.co/600x400?text=Garlic+Shrimp", "Garlic Shrimp", 8.9900000000000002 },
                    { 93, "Beverage", "Blend of mixed berries, yogurt, and honey.", null, "https://placehold.co/600x400?text=Berry+Smoothie", "Berry Smoothie", 4.5 },
                    { 94, "Dessert", "Sweet and nutty pecan pie with a flaky crust.", null, "https://placehold.co/600x400?text=Pecan+Pie", "Pecan Pie", 6.9900000000000002 },
                    { 95, "Soup", "Hearty soup with tender beef, barley, and vegetables.", null, "https://placehold.co/600x400?text=Beef+and+Barley+Soup", "Beef and Barley Soup", 6.9900000000000002 },
                    { 96, "Entree", "Breaded and fried pork cutlet served with lemon wedges.", null, "https://placehold.co/600x400?text=Pork+Schnitzel", "Pork Schnitzel", 17.989999999999998 },
                    { 97, "Appetizer", "Fresh mozzarella, tomatoes, and basil drizzled with balsamic glaze.", null, "https://placehold.co/600x400?text=Caprese+Salad", "Caprese Salad", 7.9900000000000002 },
                    { 98, "Beverage", "Refreshing water infused with a mix of fresh fruits.", null, "https://placehold.co/600x400?text=Fruit+Infused+Water", "Fruit Infused Water", 2.9900000000000002 },
                    { 99, "Dessert", "Warm cobbler filled with sweet peaches and topped with a biscuit crust.", null, "https://placehold.co/600x400?text=Peach+Cobbler", "Peach Cobbler", 6.9900000000000002 },
                    { 100, "Soup", "Creamy sweet potato soup seasoned with cinnamon and nutmeg.", null, "https://placehold.co/600x400?text=Sweet+Potato+Soup", "Sweet Potato Soup", 5.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);
        }
    }
}
