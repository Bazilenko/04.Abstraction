using System;
public class PriceCalculator
{
	public PriceCalculator()
	{
	}
	public decimal PricePerDay
	{get;set;}
	public int NumberOfDays
	{get; set;}
	public Discount DiscountType
	{get; set;}
	public Seasons Season
	{	get; set;}
	public decimal Calculate()
	{
		decimal price = PricePerDay * (int)Season * NumberOfDays;
		decimal discount = price * (decimal)((int)DiscountType / 100.0m);
        return price - discount;
       
    }

}