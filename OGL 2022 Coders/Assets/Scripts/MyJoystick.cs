using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJoystick : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        Vector2 direction = Vector2.right * this.variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime);
    }
}