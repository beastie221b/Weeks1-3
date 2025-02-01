using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risingBubble : MonoBehaviour
{
    // Initialization
    public AnimationCurve curve;
    public float speed = 0.01f;
    [Range(0, 10)]
    public float t;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the bubble's size and position based on time
        t += Time.deltaTime;
        transform.localScale = Vector2.one * curve.Evaluate(t);
        Vector3 bubblePosition = transform.position;
        bubblePosition.y += speed;
        transform.position = bubblePosition;
    }
}
