using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable]
public struct IglooInfo
{
    public int price;
    public int multiplier;
    public bool bought;

    public IglooInfo(int price, int multiplier)
    {
        this.price = price;
        this.multiplier = multiplier;
        bought = false;
    }
}