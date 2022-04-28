using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranjeroController : MonoBehaviour
{
     private Rigidbody rb;
      public float speed;   
    // Start is called before the first frame update
    void Start()
    {
          rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movimiento * speed);
    }
}
