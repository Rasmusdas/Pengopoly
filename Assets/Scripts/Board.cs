using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Space[] board;
    public Player currentPlayer;
    public Player[] players;

    public int Size { 
        get
        {
            return board.Length;
        }
    }

    public Space this[int i]
    {
        get
        {
            return board[i];
        }
    }

    void Start()
    {
        currentPlayer.StartTurn(() => { Debug.Log("TURN ENDED"); });
    }

    void Update()
    {
       
    }
}
