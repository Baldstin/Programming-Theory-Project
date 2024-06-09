using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{

    private bool isGrounded = true;

    private Rigidbody animalRb;


    // Start is called before the first frame update
    void Awake()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animalRb.transform.position = new Vector3(3, transform.position.y, transform.position.z) * Time.deltaTime;
    }

   
    
}
