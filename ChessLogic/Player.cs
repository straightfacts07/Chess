﻿namespace ChessLogic;

public enum Player
{
    None,
    White,
    Black
}


public static class PlayerExtension
{


    public static Player Opponent(this Player player)
    {
        switch (player)
        {
            case Player.White:
                return Player.Black;
            case Player.Black:
                return Player.White;
            default:
                return Player.None;
        }
    }
}
