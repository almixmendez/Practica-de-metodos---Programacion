using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    // Recolección de monedas.
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("You´ve found a coin!");
            scoreManager.ScoreUpdate(1);
            Destroy(other.gameObject);
        }
    }
}
