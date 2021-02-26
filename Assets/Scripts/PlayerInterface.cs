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
    public GameObject rollDiceButton;
    public GameObject endTurnButton;

    public void ShowInterface()
    {
        gameObject.SetActive(true);
        rollDiceButton.SetActive(true);
    }

    public void EndTurn()
    {
        endTurnButton.SetActive(false);
        gameObject.SetActive(false);
        player.EndTurn();
    }

    public void RollDice()
    {
        rollDiceButton.SetActive(false);
        int diceRoll = UnityEngine.Random.Range(1, 7) + UnityEngine.Random.Range(1, 7);

        rollDice.text = diceRoll + "";

        StartCoroutine(player.MoveToSpace(diceRoll));
    }


}