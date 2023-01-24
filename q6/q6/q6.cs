namespace OIC
{
    class Furniture
    {
        protected string material;
        protected float price;

        public void setFurniture()
        {
            Console.WriteLine("Enter the furniture material: ");
            material = Console.ReadLine();
            Console.WriteLine("Enter the furniture price: ");
            price = float.Parse(Console.ReadLine());
        }

        public void getFurniture()
        {
            Console.WriteLine($"The furniture material is: {material}");
            Console.WriteLine($"The furniture price is: {price}");
        }
    }

    class Table : Furniture
    {
        private float height;
        private float surface_area;

        public void setTable()
        {
            setFurniture();
            Console.WriteLine("Enter the table height in cm: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the surface area of table in cm: ");
            surface_area = float.Parse(Console.ReadLine());
        }

        public void getTable()
        {
            getFurniture();
            Console.WriteLine($"The table height is: {height} cm");
            Console.WriteLine($"The table surface area is: {surface_area} sq cm");
        }

    }

    class InheritanceTask
    {
        static void Main()
        {
            Console.WriteLine("abhinna question 6");

            Table table = new Table();
            Console.WriteLine("\nreading table data:");
            table.setTable();
            Console.WriteLine("\ndisplaying table data:");
            table.getTable();
        }
    }
    

}
