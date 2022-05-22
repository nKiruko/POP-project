using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInvisButton : MonoBehaviour
{
    public Renderer rend;

    public void ToggleInvisibility()
    {
        rend = GetComponent<Renderer>();
        if (rend.enabled)
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }
    }

}
