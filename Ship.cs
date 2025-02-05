﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public enum HitResult
    {
        Missed,
        Hit,
        Sunken
    }
    public class Ship
    {

        public readonly IEnumerable<Square> Squares;
        public Ship(IEnumerable<Square> squares)
        {
            Squares = squares;
        }
        public bool Contains(int row, int column)
        {
            return Squares.FirstOrDefault(sq => sq.Row == row && sq.Column == column) != null;
        }
        public HitResult Hit(int row, int column)
        {
            var square = Squares.FirstOrDefault(sq => sq.Row == row && sq.Column == column);
            if (square == null)
            {
                return HitResult.Missed;
            }

            square.Hit();

            if (Squares.All(sq => sq.IsHit))
            {
                foreach (var sq in Squares)
                {
                    sq.changeState(SquareState.Sunk);
                }
                return HitResult.Sunken;
            }
            square.changeState(SquareState.Hit);
            return HitResult.Hit;
        }
    }
}
