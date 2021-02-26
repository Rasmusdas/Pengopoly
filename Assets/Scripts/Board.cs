using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject spaces;
    public Space[] board;
    public Player currentPlayer;
    public Player[] players;
    public int currentPlayerIndex = 0;
    public int startBonus = 1000;

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
        StartCoroutine(NextTurn());
        
    }

    IEnumerator NextTurn()
    {
        bool winner = false;
        bool nextTurn = true;
        while (!winner)
        {
            if (nextTurn)
            {
                nextTurn = false;
                currentPlayer.StartTurn(() => {
                    currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
                    nextTurn = true;
                    currentPlayer = players[currentPlayerIndex];
                });
            }

            yield return new WaitForSeconds(0.1f);

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].fish < 0)
                {
                    Debug.Log("Player " + (i+1) + " has 'won' he no longer has to play this shit game");
                    winner = true;
                }
            }
        }
        EndGame();
    }

    public void EndGame()
    {

    }
}
