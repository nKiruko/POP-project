using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class btuton : MonoBehaviour
{
    [System.Serializable]
    public class ButtonEvent : UnityEvent { }

    public float pressLength;
    public bool pressed;
    public ButtonEvent downEvent;

    Vector3 startPos;
    Rigidbody rb;

    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // If our distance is greater than what we specified as a press
        // set it to our max distance and register a press if we haven't already
        float distance = Mathf.Abs(transform.position.y - startPos.y);
        if (distance >= pressLength)
        {
            transform.position = new Vector3(transform.position.x, startPos.y - pressLength, transform.position.z);
            if (!pressed)
            {
                pressed = true;
                downEvent?.Invoke();
            }
        }
        else
        {
            pressed = false;
   
        }
        if (transform.position.y > startPos.y)
        {
            transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
        }
    }
}
