using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Fight
{
    public class AttackResultDto
    {
        public string Attacker { get; set; } = string.Empty;
        public string Opponent { get; set; } = string.Empty;
        public int AttackerHitpoints { get; set; }
        public int OpponentHitpoints { get; set; }
        public int Damage { get; set; }
    }
}