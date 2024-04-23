using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movimiento.
    [SerializeField] Rigidbody playerRb;
    [SerializeField] float playerSpeed = 10f;
    
    // Disparo.
    private Shoot shoot;
    [SerializeField] float proSpeed = 10f;
    [SerializeField] Transform proSpawnPoint;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        shoot = GetComponent<Shoot>();
    }

    void Update()
    {
        // Disparo.
        if (Input.GetMouseButtonDown(0))
        {
            shoot.ShootProjectile(proSpawnPoint.position, proSpeed);
        }
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
