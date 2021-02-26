using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropertyUI : MonoBehaviour
{
    public Button buyButton;

    public GameObject notOwnedButtons;

    public GameObject upgradeButtons;
    public GameObject[] iglooButtons;

    public PropertySpace prop;

    Player currentPlayer;
    public void ShowInterface(Player currentPlayer)
    {
        gameObject.SetActive(true);
        this.currentPlayer = currentPlayer;

        if(prop.owner)
        {
            notOwnedButtons.SetActive(false);

            if(prop.owner == currentPlayer)
            {
                upgradeButtons.SetActive(true);

                for (int i = 0; i < iglooButtons.Length; i++)
                {
                    if(prop.igloos[i].price <= currentPlayer.fish && !prop.igloos[i].bought)
                    {
                        iglooButtons[i].SetActive(true);
                    }
                    else
                    {
                        iglooButtons[i].SetActive(false);
                    }
                }
            }
        }
        else
        {
            notOwnedButtons.SetActive(true);
        }

        if(currentPlayer.fish < prop.price )
        {
            buyButton.interactable = false;
        }
    }

    public void BuyProperty()
    {
        currentPlayer.fish -= prop.price;
        prop.SetOwner(currentPlayer);
        HideInterface();
    }

    public void HideInterface()
    {
        gameObject.SetActive(false);
    }

    public void BuildIgloo(string num)
    {
        int index = int.Parse(num);

        currentPlayer.fish -= prop.igloos[index].price;
        prop.igloos[index].bought = true;
        prop.price *= prop.igloos[index].multiplier;
    }
}
