using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoostTimer : MonoBehaviour
{
    public float boostDuration = 5f;
    private float timer = 0f;
    private bool isBoosting = false;

    public CarGame carGame; 
    private float originalSpeed;//private

    void Start()
    {
        originalSpeed = carGame.moveSpeed;
    }

    void Update()
    {
        if (isBoosting)
        {
            timer -= Time.deltaTime;
            Debug.Log("Boost Time Left: " + timer);

            if (timer <= 0f)
            {
                carGame.moveSpeed = originalSpeed;
                isBoosting = false;
            }
        }
    }

    public void TriggerBoost(float multiplier)
    {
        if (!isBoosting)
        {
            originalSpeed = carGame.moveSpeed;
            carGame.moveSpeed = originalSpeed * multiplier;
            timer = boostDuration;
            isBoosting = true;
        }
    }
}
