using System;
using System.Collections.Generic;

class PaymentGateway
{
    public bool ProcessPayment ( decimal amount )
    {
        // Duplicate payment processing logic
        Console.WriteLine($"Payment of $ {amount} processed successfully.");
        return true;
    }
}