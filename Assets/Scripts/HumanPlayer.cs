using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UnityEngine;

public class HumanPlayer : Player
{
    public PlayerInterface intFace;
    public Board board;
    int fish;
    int position = 0;

    public override void StartTurn(Action endTurn)
    {
        StartCoroutine(MoveToSpace(board.Size));
    }

    public void ShowInterface()
    {
        intFace.ShowInterface();
    }

    public IEnumerator MoveToSpace(int index)
    {

        for (int i = position+1; i < index; i++)
        {
            Vector3 startPosition = transform.position;
            float t = -2;
            transform.LookAt(board[i].position + Vector3.up);
            while (t <= 2.001)
            {
                transform.position = new Vector3(Mathf.Lerp(startPosition.x, board[i].position.x, (t + 2) / 4.0f), 3 - (t * t)*1/2, Mathf.Lerp(startPosition.z, board[i].position.z, (t + 2) / 4.0f));
                
                yield return new WaitForSeconds(0.009f);
                t += 2f/10f;
            }
        }

    }
}
