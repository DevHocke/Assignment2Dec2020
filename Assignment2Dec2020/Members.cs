using System;


namespace Assignment2Dec2020
{
    class Members
    {
        // Field.
        public string name;
        public int age;
        public int height;
        public string fromCity;
        public string hobbies;
        public string favouriteFood;
        public string favouriteDrink;
        public string favouriteMusic;
        public int children;
        public string driveToCode;
        // Empty constructor.
        public Members()
        {

        }
        // Populated constructor.
        public Members(
            string name,
            int age,
            int height,
            string fromCity,
            string hobbies,
            string favouriteFood,
            string favouriteDrink,
            string favouriteMusic,
            int children,
            string driveToCode)

        {   // Reference to the field in the start of this class Members.
            this.name = name;
            this.age = age;
            this.height = height;
            this.fromCity = fromCity;
            this.hobbies = hobbies;
            this.favouriteFood = favouriteFood;
            this.favouriteDrink = favouriteDrink;
            this.favouriteMusic = favouriteMusic;
            this.children = children;
            this.driveToCode = driveToCode;
        }
        // Properties.
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Height { get => height; set => height = value; }
        public string FromCity { get => fromCity; set => fromCity = value; }
        public string Hobbies { get => hobbies; set => hobbies = value; }
        public string FavouriteFood { get => favouriteFood; set => favouriteFood = value; }
        public string FavouriteMusic { get => favouriteMusic; set => favouriteMusic = value; }
        public int Children { get => children; set => children = value; }
        public string DriveToCode { get => driveToCode; set => driveToCode = value; }

        // This method prints the users choice of member with all of the members details and some filler text. 
        // This method runs if the user 
        public void DetailedMember()
        {
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"City: {fromCity}");
            Console.WriteLine($"Hobbies: {hobbies}");
            Console.WriteLine($"Favourite Food: {favouriteFood}");
            Console.WriteLine($"Favourite Drink: {favouriteDrink}");
            Console.WriteLine($"Favourite Music: {favouriteMusic}");
            Console.WriteLine($"Children: {children}");
            Console.WriteLine($"Motivation to code: {driveToCode}");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
