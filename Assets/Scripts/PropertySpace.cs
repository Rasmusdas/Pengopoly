using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PropertySpace : Space
{
    public override void LandOn(Player player)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        position = transform.position;
    }
}