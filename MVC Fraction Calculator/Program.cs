
using MVC_Fraction_Calculator;

Console.WriteLine("Hello, World!");
FractionPresenter presenter = new FractionPresenter();
FractionView view = new FractionView(presenter);
view.Run();
