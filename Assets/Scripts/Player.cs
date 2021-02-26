using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Player : MonoBehaviour
{
    public int fish;
    public abstract void StartTurn(Action endTurn);
}
