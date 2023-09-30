namespace Rifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Bienvenido al programa de rifas");
            Console.WriteLine("Ingrese la informaciòn referente a la rifa");
           
            Console.WriteLine("Digite la fecha de la rifa DD/MM/AAAA");
            string fechaSorteo = Console.ReadLine();
            int dia = int.Parse(fechaSorteo.Split('/')[0]);
            int mes = int.Parse(fechaSorteo.Split('/')[1]);
            int year = int.Parse(fechaSorteo.Split('/')[2]);
            DateTime fechaSorteoDate = new DateTime(year, mes, dia);
            Rifa rifa = new Rifa(fechaSorteoDate,//Descripcciòn )
        }
    }
}