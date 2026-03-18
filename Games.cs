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

        public Games(string nameGame, double hoursPlayed, string genderGame, string plataformThrown, int nota, DateTime startDate)
        {
            this.nameGame = nameGame;
            this.hoursPlayed = hoursPlayed;
            this.genderGame = genderGame;
            this.plataformThrown = plataformThrown;
            this.nota = nota;
            this.startDate = startDate;
        }

        public Games(string nameGame)
        {
            this.nameGame = nameGame;
        }

        public string GetNameGame()
        {
            return nameGame;
        }

        public void SetNameGame(string nome)
        {
            nameGame = nome;
        }

        public override string ToString()
        {
            return $"Nome do jogo: {nameGame}\nHoras jogadas: {hoursPlayed}";
        }
    }
}
