using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Slider control;
	public float speed = 2, steer = 100;
    float drift = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void FixedUpdate(){
         rb.velocity = ForwardVelocity() + RightVelocity() * drift;
         rb.AddForce(transform.up * speed);
         rb.angularVelocity = -1 * (control.value - 0.5f) * steer;
     }

     Vector2 ForwardVelocity(){
         return transform.up * Vector2.Dot(rb.velocity, transform.up);
     }

    Vector2 RightVelocity(){
         return transform.right * Vector2.Dot(rb.velocity, transform.right);
     }
}
