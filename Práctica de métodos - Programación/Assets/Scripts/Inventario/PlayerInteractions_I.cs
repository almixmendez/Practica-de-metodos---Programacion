using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractions_I : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] GameObject collectable;

    private void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("You´ve found a coin!");
            Destroy(other.gameObject);
            inventory.AddToInventory(other.gameObject, 1);
        }
    }

    public void RemoveCoin()
    {
        inventory.RemoveFromInventory(collectable, 1);
    }
}
