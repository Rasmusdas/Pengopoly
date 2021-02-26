using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropertyUI : MonoBehaviour
{
    public Button buyButton;

    public GameObject notOwnedButtons;

    public GameObject ownedButtons;

    public PropertySpace prop;

    Player currentPlayer;
    public void ShowInterface(Player currentPlayer)
    {
        gameObject.SetActive(true);
        this.currentPlayer = currentPlayer;

        if(prop.owner)
        {
            notOwnedButtons.SetActive(false);
            ownedButtons.SetActive(true);
        }
        else
        {
            notOwnedButtons.SetActive(true);
            ownedButtons.SetActive(false);
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
}
