public abstract class Payment
{
    public abstract string name { get; }
    public int quantity { get; }
    public int total { get; }




    public abstract void CardPayment();
}




internal class Cash : Payment
{
    public override string name => "Cash"; // name for the payment type




    public string CashQuantity { get; set; }




    public override void CardPayment()
    {
   
        Console.WriteLine($"Processing credit card. You have bought ${total} products.");
        Console.WriteLine($"Payment successful.");
    }
}




internal class CreditCard : Payment{
       public override string name => "CreditCard";




    public string CardQuantity { get; set; }




public override void CardPayment()
    {
        Console.WriteLine($"Processing credit card. You have bought ${total} products.");
        Console.WriteLine($"Payment successful.");
    }
}
internal class Check : Payment{




    public override string name => "Check";




    public string CheckQuantity { get; set; }




public override void CardPayment()
    {
        Console.WriteLine($"You have bought ${total} products.");
        Console.WriteLine($"Payment successful.");
    }
}





