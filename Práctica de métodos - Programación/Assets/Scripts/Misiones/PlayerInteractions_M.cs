using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteractions_M : MonoBehaviour
{
    // Misiones.
    [SerializeField] GameObject panel1;
    //[SerializeField] GameObject panel2;
    //[SerializeField] GameObject panel3;
    [SerializeField] GameObject missionCompletePanel;

    // Recolectables.
    [SerializeField] private int collectableCount = 0;
    [SerializeField] float points;
    [SerializeField] TextMeshProUGUI coinsText;

    private void Update()
    {
        Missions(1);
        //Missions(2);
        //Missions(3);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Misiones activas.
        if (other.gameObject.CompareTag("Mission1"))
        {
            MissionActive(1, panel1);
        } /*else if (other.gameObject.CompareTag("Mission2"))*/
        //{
        //    MissionActive(2, panel2);
        //} else if (other.gameObject.CompareTag("Mission3"))
        //{
        //    MissionActive(3, panel3);
        //}

        // Recolección de monedas.
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("You´ve found a coin!");
            Destroy(other.gameObject);
            AddToInventory(other.gameObject, 1);
        }
    }

    public void CoinsUpdate(int coins)
    {
        points = points + coins;

        coinsText.text = "" + points;
    }

    public void AddToInventory(GameObject collectable, int collectableNum)
    {
        collectableCount += collectableNum;
        CoinsUpdate(1);
    }


    public void MissionActive(int mission, GameObject panel)
    {
        Debug.Log("Mission state: active");
        panel.SetActive(true);
    }

    public void Missions(int mission)
    {
        if (mission == 1 && collectableCount == 5)
        {
            missionCompletePanel.SetActive(true);
        }
        //else if (mission == 2 && collectableCount == 10)
        //{
        //    missionCompletePanel.SetActive(true);
        //}
        //else if (mission == 3 && collectableCount == 15)
        //{
        //    missionCompletePanel.SetActive(true);
        //}
    }

    public void CancelMission(int mission)
    {
        if (mission == 1)
        {
            panel1.SetActive(false);
        }
        //if (mission == 2)
        //{
        //    panel2.SetActive(false);
        //}
        //if (mission == 3)
        //{
        //    panel3.SetActive(false);
        //}
    }
}
