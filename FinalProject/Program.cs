using GoogleStore;

double subtotal = 0.0;

Book b = new Book();
b.Name = "The Underworld";
b.Author = "John Doe";
b.Price = 15.99;
subtotal += b.Price;
b.DisplayProduct();

Electronics e = new Electronics();
e.Name = "Iphone 16.3 XD Turbo edition";
e.Company = "Apple";
e.Price = 999.99;
subtotal += e.Price;
e.DisplayProduct();

PetSupplies p  = new PetSupplies();
p.Name = "Dog shoes";
p.Quantity = 2;
p.Price = 199.98;
subtotal += p.Price * p.Quantity;
p.DisplayProduct();

// Took subtotal variable by ref through a static class static method
// calculated total with current TaxRate
CalTotal.Total(ref subtotal);

// var subtotal is now the total cost
Console.WriteLine("Total after tax: {0:c}", subtotal);