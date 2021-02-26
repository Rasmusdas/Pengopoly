using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PropertySpace : Space
{
    public PropertyUI ui;
    public int price;
    public Player owner;

    public override void LandOn(Player player)
    {
        ui.ShowInterface(player);
    }

    private void Start()
    {
        position = transform.position;
    }
}