using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //print("touch");
            Touch touch = Input.GetTouch(0);
           
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up,
                0.6f, LayerMask.GetMask("PlatformLayer"));
            if(hit.collider != null)
            {
                print(hit.collider.gameObject.name);
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 0.1f, ForceMode2D.Impulse);
            }

        }
    }
}
