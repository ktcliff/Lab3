WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine(); // or use "49" in a notebook

if (int.TryParse(input!, out int age)) {

 WriteLine($"You are {age} years old.");

}

else {

 WriteLine("The age you entered is not a valid number format.");

}
WriteLine("After parsing");


Write("Enter an amount: ");
string amount = ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;


  if (decimal.TryParse(amount, out decimal amountValue)) {

  WriteLine($"Amount formatted as currency: {amountValue:C}");
}
else if (amount.Contains("$"))
{
  WriteLine("Amounts cannot use the dollar sign!");
}
else
{
  WriteLine("Amounts must only contain digits!");
}

