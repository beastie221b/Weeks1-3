using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAFish : MonoBehaviour
{
    // initiallize the speed of the fish object
    public float speed = 10;
    public float rotationSpeed = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        // flip the fish when press the opposite direction
        if (Input.GetAxisRaw("Vertical") > 0) 
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        transform.Rotate(0, 0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
        transform.Translate(Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0, 0);

        // Keep the fish inside of the screen
        Vector3 fishPosition = transform.position;
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(fishPosition);

        if (screenPosition.x < 0 || screenPosition.x > Screen.width || screenPosition.y < 0 || screenPosition.y > Screen.height)
        {
            transform.Rotate(0, 0, -Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
            transform.Translate(-Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0, 0);
        }
    }
}
