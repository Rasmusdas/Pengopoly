using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject spaces;
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
        board = new Space[spaces.transform.childCount];
        for (int i = 0; i < spaces.transform.childCount; i++)
        {
            board[i] = spaces.transform.GetChild(i).GetComponent<Space>();
        }
        currentPlayer.StartTurn(() => { Debug.Log("TURN ENDED"); });
    }

    void Update()
    {
       
    }
}
