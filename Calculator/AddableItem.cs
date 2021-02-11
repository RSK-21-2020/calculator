namespace Calculator
{
    public class AddableItem
    {
        public bool isNotNegative { get; private set; }
        public double value { get; private set; }
        public bool isImagine { get; private set; }

        public AddableItem(double value, bool isImagine, bool isNotNegative)
        {
            this.value = value;
            this.isImagine = isImagine;
            this.isNotNegative = isNotNegative;
        }
    }
}