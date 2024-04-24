using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int collectableCount = 0;
    [SerializeField] float points; 
    [SerializeField] TextMeshProUGUI coinsText;

    public void CoinsUpdate(int coins)
    {
        points = points + coins;

        coinsText.text = "" + points;
    }
    public void AddToInventory(GameObject collectable, int collectableNum)
    {
        collectableCount += collectableNum;
        CoinsUpdate(collectableNum);
    }

    public void RemoveFromInventory(GameObject collectable, int collectableNum)
    {
        if ()
        {

        }
        collectableCount -= collectableNum;
        CoinsUpdate(-collectableNum);
    }
}
