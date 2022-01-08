namespace ExamplePOO.Models
{
    public class Rectangle
    {
        private double Height;
        private double Width;
        private Boolean Validate;


        public void SetMeasures(double height, double width)
        {

            if (height > 0 && width > 0)
            {

                this.Height = height;
                this.Width = width;
                this.Validate = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
        }

        public double CalcArea()
        {
            if (this.Validate)
                return this.Height * this.Width;
            System.Console.WriteLine("Informe valores válidos");
            return 0;
        }

    }
}