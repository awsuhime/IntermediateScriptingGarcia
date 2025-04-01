using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate mDelegate;
    private Renderer renderguy;
    void Start()
    {
        renderguy = GetComponent<Renderer>();

        mDelegate += PowerUp;
        mDelegate += turnRed;

        if (mDelegate != null)
        {
            mDelegate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PowerUp()
    {
        print("Powering Up!");
    }

    void turnRed()
    {
        renderguy.material.color = Color.red;
    }
}
