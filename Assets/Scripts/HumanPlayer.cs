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
    
    int position = 0;
    Action endTurn;
    public override void StartTurn(Action endTurn)
    {
        ShowInterface();
        this.endTurn = endTurn;
    }

    public void ShowInterface()
    {
        intFace.ShowInterface();
    }

    public void EndTurn()
    {
        endTurn.Invoke();
    }


    public IEnumerator MoveToSpace(int num)
    {

        for (int i = 0; i < num; i++)
        {
            int index = (position + i + 1)%board.Size;
            Vector3 startPosition = transform.position;
            float t = -2;
            transform.LookAt(board[index].position);
            transform.Rotate(0, 180, 0);
            while (t <= 2.001)
            {
                transform.position = new Vector3(Mathf.Lerp(startPosition.x, board[index].position.x, (t + 2) / 4.0f), board[index].position.y+1 - (t * t)/4, Mathf.Lerp(startPosition.z, board[index].position.z, (t + 2) / 4.0f));
                
                yield return new WaitForSeconds(0.009f);
                t += 2f/10f;
            }
        }

        position = (position + num) % board.Size;

        board[position].LandOn(this);
    }
}
