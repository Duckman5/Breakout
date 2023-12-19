using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platformmovement : MonoBehaviour
{

    [SerializeField]
    GameObject Boll;

    Rigidbody Myrigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Myrigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(12, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-12, 0, 0) * Time.deltaTime;
        }
        
        
        if(Boll.transform.position.y < -1)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        

        
        

    }
}
