using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInvis : MonoBehaviour
{

    public Renderer rend;
    public MeshCollider rend2;
    public void ToggleInvisibility()
    {
        rend = GetComponent<Renderer>();
        if (rend.enabled) 
        { 
        rend.enabled = false;
        rend2.enabled = false;
        }
        else
        {
            rend.enabled = true;
            rend2.enabled = true;
        }
    }

}
