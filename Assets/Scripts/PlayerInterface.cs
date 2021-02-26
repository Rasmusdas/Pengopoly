using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    public HumanPlayer player;

    public Text rollDice;

    public void ShowInterface()
    {

    }

    public void EndTurn()
    {
        player.EndTurn();
    }

    public void RollDice()
    {
        int diceRoll = UnityEngine.Random.Range(1, 7) + UnityEngine.Random.Range(1, 7);

        rollDice.text = diceRoll + "";

        StartCoroutine(player.MoveToSpace(diceRoll));
    }


}