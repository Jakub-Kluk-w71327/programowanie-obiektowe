namespace Lab03_ćwiczenia
{
    internal class Shape
    {
        //properties
        public float X { get; set; }
        public float Y { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        

        //methods
        public virtual void Draw()
        {
            Console.WriteLine("Narysowano kształt");
        }

    }
}
