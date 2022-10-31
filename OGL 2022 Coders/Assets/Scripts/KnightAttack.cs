using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : MonoBehaviour
{
    [SerializeField] private float damageRange;

    // Update is called once per frame
    void CheckHit()
    {
        Debug.Log("check hit");
        
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, damageRange);

        GameObject currentGameObject;
        for (int i = 0; i < hitColliders.Length; i++)
        {
            currentGameObject = hitColliders[i].gameObject;
            Debug.Log("Within attack range: " + currentGameObject.name);
            if(currentGameObject.tag == "Enemy")
            {
                currentGameObject.SendMessage("TakeDamage");
            }
        }
    }
}
