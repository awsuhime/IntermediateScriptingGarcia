using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Human
{
    new public void Yell()
    {
        Debug.Log("I am an enemy.");
    }
}
