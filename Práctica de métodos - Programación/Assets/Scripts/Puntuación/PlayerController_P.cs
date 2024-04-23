using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_P : MonoBehaviour
{
    // Movimiento.
    [SerializeField] Rigidbody playerRb;
    [SerializeField] float playerSpeed = 10f;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Movimiento.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * playerSpeed * Time.deltaTime;

        playerRb.MovePosition(transform.position + movement);
    }
}
