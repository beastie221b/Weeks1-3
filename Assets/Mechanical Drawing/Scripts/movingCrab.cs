using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCrab : MonoBehaviour
{
    // initialization.
    public float speed = 0.05f;
    public int reverseDirection = -1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // change the world position to screen position
        Vector3 crabPosition = transform.position;
        crabPosition.x += speed;
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(crabPosition);

        if(screenPosition.x < 0 || screenPosition.x > Screen.width)
        {
            speed = speed * reverseDirection;
        }

        transform.position = crabPosition;
    }
}
