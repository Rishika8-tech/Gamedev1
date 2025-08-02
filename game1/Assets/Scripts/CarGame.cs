using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGame : MonoBehaviour
{
    // Start is called before the first frame update
    //left/right or a/d should rotate the car
    // up/down or w/s should move the car forward/backward
    public float rotationSpeed, moveSpeed, boostMultiplier; 
    public BoostTimer boostTimer;
    public Transform carTransform;


    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        //Debug.Log("Horizontal: " + horizontalMovement + "Vertical: " + verticalMovement);
        if (Mathf.Abs(horizontalMovement) > 0.01f)
        {
            carTransform.Rotate(0f, 0f, -1 * rotationSpeed * horizontalMovement * Time.deltaTime);
        }
        if(Mathf.Abs(verticalMovement) > 0.01f)
        {
            carTransform.Translate(0f, moveSpeed * verticalMovement * Time.deltaTime , 0f);
        }   
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BlueHouse")
        {
            Debug.Log("I've hit a blue house!");
        }
        else if(collision.gameObject.tag == "RedHouse")
        {
            Debug.Log("I've hit a red house!");
        }
        
        else
        {
            Debug.Log("I've hit something else!");
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (boostTimer != null)
        {
            boostTimer.TriggerBoost(boostMultiplier); 
        }
        Destroy(other.gameObject);
    }


}
