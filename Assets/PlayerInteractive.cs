using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractive : MonoBehaviour
{
    public PlayerMovement pm;
    public float slowerSpeedValue;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlowArea"))
        {
            pm.speed = slowerSpeedValue;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("SlowArea"))
        {
            pm.speed = 8;
        }
    }
}
