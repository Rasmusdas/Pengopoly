using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Space : MonoBehaviour
{
    public Vector3 position;
    public abstract void LandOn(Player player, Action endInteraction);
}
