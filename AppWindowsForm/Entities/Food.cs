namespace AppWindowsForm
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Price { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }

        public Food(int id, string name, int time, int price, int calories, bool vegan)
        {
            this.Id = id;
            this.Name = name;
            this.Time = time;
            this.Price = price;
            this.Calories = calories;
            this.Vegan = vegan;
        }
    }
}
