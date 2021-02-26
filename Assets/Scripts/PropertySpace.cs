using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PropertySpace : Space
{
    public PropertyUI ui;
    public int price;
    public Player owner;
    public int rent;
    public IglooInfo[] igloos;


    public override void LandOn(Player player)
    {
        if(!owner || player == owner)
        {
            ui.ShowInterface(player);
        }
        else
        {
            player.fish -= rent;
            owner.fish += rent;
        }
    }

    private void Start()
    {
        position = transform.position;
    }

    public void SetOwner(Player newOwner)
    {
        owner = newOwner;
        GetComponent<MeshRenderer>().material.color = newOwner.playerColor;
    }
}