namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Також ми можемо перевіряти більше ніж одну умову одночасно використовуючи
            //&& - означає "та"/"і"
            //або
            //|| - означає "або"
            //! - означає "не"/"заперечення"

            // bool g = num < num2 && a == false; //такий вираз буде дорівнювати true якщо обидва вирази будуть дорівнювати true
            // bool h = num < num2 || a == false; //такий вираз буде дорівнювати true якщо хоча б один з варіантів буде дорівнювати true

            // Console.WriteLine("Both conditions are true: " + g);
            // Console.WriteLine("At lear one condition is true: " + h);
        }
    }
}
