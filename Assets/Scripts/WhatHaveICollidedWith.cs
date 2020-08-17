using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatHaveICollidedWith : MonoBehaviour
{
    Renderer theRend;
    public bool isHot = false;
    Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        theRend = GetComponent<Renderer>();
        originalPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I have collided with " + collision.gameObject.name);


        if(collision.gameObject.name == "Lava")
        {
            //it is the lava, make red
            //Debug.Log("the evaluation of lava and is not hot is true");
            //theRend.material.color = Color.red;
            //isHot = true;


        }

    }

    public void ResetTheBottle()
    {
        transform.position = originalPosition;


    }
}
