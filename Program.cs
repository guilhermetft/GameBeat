namespace GameBeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Games game;

            Console.WriteLine("Nome do jogo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Horas jogadas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Gênero do jogo: ");
            string genero = Console.ReadLine();
            Console.WriteLine("Plataforma jogada: ");
            string plataforma = Console.ReadLine();
            Console.WriteLine("Nota do jogo: ");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de inicio: ");
            DateTime datainicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data em que zerou: ");
            DateTime datafim = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Platinado ou 100%: ");
            string platina = Console.ReadLine();

            game = new Games();

            Console.WriteLine();
            game.SetNameGame(nome);
            game.SetHoursPlayed(horas);
            game.SetGenderGame(genero);


            Console.WriteLine(game);
        }
    }
}
