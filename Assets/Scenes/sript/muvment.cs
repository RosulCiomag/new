using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muvment : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;
    public bool jumpTime = false;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") && jumpTime)  
      {
        jumpTime = false;
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
      }
      if (Input.GetKeyDown("space"))  
      {
        if(!hasSwithedLayers)
        {
        this.transform.position = new Vector3(
          this.transform.position.x,
          this.transform.position.y,
          10
        );
        }
        else{
        this.transform.position = new Vector3(
          this.transform.position.x,
          this.transform.position.y,
          0
        );
        }
        hasSwithedLayers = !hasSwithedLayers;
      }
    }

    void OnCollisionEnter(Collision collision) {
      jumpTime = true;
      if(collision.gameObject.name=="END")
      {
        this.transform.position = new Vector3(
          202.29f,
          this.transform.position.y,
          this.transform.position.z
        );
      }
    }
}
