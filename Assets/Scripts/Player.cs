using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Player : MonoBehaviour
{
    public Color playerColor;
    public int fish;
    public int jailTurns;
    public abstract void StartTurn(Action endTurn);
}
