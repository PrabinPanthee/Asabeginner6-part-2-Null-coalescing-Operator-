using System;
class Program
{
    static void Main()
    {
        int? TicketOnSale = 100;
        int AvailableTicket = TicketOnSale ?? 0;
        Console.WriteLine(AvailableTicket);
         
    }
}