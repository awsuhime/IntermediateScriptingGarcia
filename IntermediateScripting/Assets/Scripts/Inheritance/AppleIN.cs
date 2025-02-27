using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleIN : FruitIn
{
    public AppleIN()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public AppleIN(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");

    }
}
