using System;
enum Season
{
    Autum = 1,
    Spring = 2,
    Winter = 3,
    Summer = 4

}
enum Discount
{
    None = 0,
    SecondVisit = 10,
    VIP = 20
}
class PriceCalculator
{
    private decimal priceperday;
    private int numbersofdays;
    private Season season;
    private Discount discount;
    public PriceCalculator(decimal priceperday, int numbersofdays, Season season, Discount discount = Discount.None)
    {
        this.priceperday = priceperday;
        this.numbersofdays = numbersofdays;
        this.season = season;
        this.discount = discount;
    }
    public decimal CalculateTotalPrice()
    {
        decimal baseprice = priceperday * numbersofdays * (int)season;
        decimal discountAmount = baseprice * ((int)discount / 100m);
        return baseprice - discountAmount;
    }
}
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputParts = input.Split(' ');
        decimal priceperday = decimal.Parse(inputParts[0]);
        int numberofday = int.Parse(inputParts[1]);
        Season season = Enum.Parse<Season>(inputParts[2]);
        Discount discount = inputParts.Length > 3 ? Enum.Parse<Discount>(inputParts[3]) : Discount.None;

        PriceCalculator calculator = new PriceCalculator(priceperday, numberofday, season, discount);
        decimal totalPrice = calculator.CalculateTotalPrice();
        Console.WriteLine($"{totalPrice:F2}");
    }
}