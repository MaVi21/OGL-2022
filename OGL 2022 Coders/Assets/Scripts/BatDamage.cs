using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatDamage : MonoBehaviour
{
    public GameObject explosion;

    // Update is called once per frame
    void TakeDamage()
    {
        Debug.Log("Bat take damage");
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
