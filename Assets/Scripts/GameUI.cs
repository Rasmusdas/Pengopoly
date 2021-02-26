using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text[] fishMeters;
    public Board board;
    private void Start()
    {
        for (int i = 0; i < board.players.Length; i++)
        {
            fishMeters[i].gameObject.SetActive(true);
        }
    }

    void Update()
    {
        for (int i = 0; i < board.players.Length; i++)
        {
            fishMeters[i].text = board.players[i].fish + "";
        }
    }
}
