using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muvment : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;
    public bool jumpTime = false;
    public bool CanJump = false;
    bool hasSwithedLayers = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() 
    {
      if (Input.GetKey("a"))  
      {
        GetComponent<Rigidbody>().velocity = new Vector3(
            -moveForce * Time.deltaTime,
            GetComponent<Rigidbody>().velocity.y,
            GetComponent<Rigidbody>().velocity.z
        );
      }
      if (Input.GetKey("d"))  
      {
        GetComponent<Rigidbody>().velocity = new Vector3(
            moveForce * Time.deltaTime,
            GetComponent<Rigidbody>().velocity.y,
            GetComponent<Rigidbody>().velocity.z
        );
      }
      if (Input.GetKey("w"))  
      {
        GetComponent<Rigidbody>().velocity = new Vector3(
            GetComponent<Rigidbody>().velocity.x,
            GetComponent<Rigidbody>().velocity.y,
            moveForce * Time.deltaTime
        );
      }
      if (Input.GetKey("s"))  
      {
        GetComponent<Rigidbody>().velocity = new Vector3(
            GetComponent<Rigidbody>().velocity.x,
            GetComponent<Rigidbody>().velocity.y,
            -moveForce * Time.deltaTime
        );
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(CanJump==true)
      {
        if (Input.GetKey("space") && jumpTime)  
      {
        jumpTime = false;
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
      }
      }
    }

    void OnCollisionEnter(Collision collision) {
      jumpTime = true;
      if(collision.gameObject.name=="can you jump")
      {
      CanJump=true;
      }
    }
}
