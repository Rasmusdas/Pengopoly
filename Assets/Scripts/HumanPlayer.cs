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
        StartCoroutine(MoveToSpace((position + 1) % board.Size));
    }

    public void ShowInterface()
    {
        intFace.ShowInterface();
    }

    public IEnumerator MoveToSpace(int index)
    {
        for (int i = position; i < index; i++)
        {
            float t = -2;
            while(t <= 2)
            {
                transform.position = new Vector3(Mathf.Lerp(transform.position.x,board[i].position.x,(t+2)/4),  5-(t*t), Mathf.Lerp(transform.position.z, board[i].position.z, (t+2)/4));
                yield return new WaitForSeconds(0.01f);
                Debug.Log((t + 2) / 4.0f);
                t += 0.05f;
            }
        }
    }
}
