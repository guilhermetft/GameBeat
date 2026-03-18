using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBeat
{
    public class Games
    {
        private string nameGame { get; set; }
        private double hoursPlayed { get; set; }
        private string genderGame { get; set; }
        private string plataformThrown { get; set; }
        private int nota { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }

        // Metodos Construtores
        public Games(string nameGame, double hoursPlayed, string genderGame, string plataformThrown, int nota, DateTime startDate, DateTime endDate)
        {
            this.nameGame = nameGame;
            this.hoursPlayed = hoursPlayed;
            this.genderGame = genderGame;
            this.plataformThrown = plataformThrown;
            this.nota = nota;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public Games(string nameGame, double hoursPlayed, string genderGame, string plataformThrown, int nota, DateTime startDate)
        {
            this.nameGame = nameGame;
            this.hoursPlayed = hoursPlayed;
            this.genderGame = genderGame;
            this.plataformThrown = plataformThrown;
            this.nota = nota;
            this.startDate = startDate;
        }

        public Games()
        {
            nameGame = null;
            hoursPlayed = 0;
            genderGame = null;
            plataformThrown = null;
            nota = 0;
            startDate = DateTime.MinValue;
            endDate = DateTime.MinValue;
        }

        // Construtor teste
        public Games(string nameGame, double hoursPlayed, string genderGame)
        {
            this.nameGame = nameGame;
            this.hoursPlayed = hoursPlayed;
            this.genderGame = genderGame;
        }

        // Metodos Getters e Setters
        public string GetNameGame()
        {
            return nameGame;
        }

        public void SetNameGame(string nome)
        {
            nameGame = nome;
        }

        public double GetHoursPlayed()
        {
            return hoursPlayed;
        }

        public void SetHoursPlayed(double horas)
        {
            hoursPlayed = horas;
        }

        public string GetGenderGame()
        {
            return genderGame;
        }

        public void SetGenderGame(string genero)
        {
            genderGame = genero;
        }


        // Override do ToString para exibir as informações do jogo
        public override string ToString()
        {
            return $"Nome do jogo: {nameGame}\nHoras jogadas: {hoursPlayed}";
        }
    }
}
