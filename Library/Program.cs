// See https://aka.ms/new-console-template for more information
using Library.Logic;

Console.WriteLine("Hello, World!");
RentalLogic.RentBook(12345678, Guid.Parse("0cbc19bc-0882-4572-8f2f-b5919b303bed"));
RentalLogic.RentBook(42345678, Guid.Parse("0cbc19bc-0882-4572-8f2f-b5919b303bed"));

RentalLogic.EndRental(12345678, Guid.Parse("0cbc19bc-0882-4572-8f2f-b5919b303bed"));