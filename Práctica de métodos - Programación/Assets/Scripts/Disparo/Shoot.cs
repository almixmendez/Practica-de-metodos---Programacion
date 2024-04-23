using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    public void ShootProjectile(Vector3 position, float speed)
    {
        GameObject pro = Instantiate(projectile, position, Quaternion.identity);
        Destroy(pro, 1f);
    }
}
