using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll : MonoBehaviour
{
    Rigidbody Bollbody;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 2, 0);



        Bollbody = GetComponent<Rigidbody>();

      

        Bollbody.velocity = new Vector3(0, -50, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;

        Bollbody.velocity = Bollbody.velocity.normalized * speed;

        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(0, 4, 0);

            Bollbody.velocity = new Vector3(0, -50, 0);
        }

        if (transform.position.y < -2)
        {
            transform.position = new Vector3(0, 4, 0);
            Bollbody.velocity = new Vector3(0, -50, 0);
        }
    } 
 


        

    private void OnCollisionEnter(Collision collision)
    {
        
        
        if(collision.gameObject && collision.gameObject.name.Contains("Cube"))
        {
            Destroy(collision.gameObject);
        }

    }
}
