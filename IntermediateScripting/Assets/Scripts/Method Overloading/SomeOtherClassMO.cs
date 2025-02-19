using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassMO : MonoBehaviour
{
    void Start()
    {
        SomeClassMO myClass = new SomeClassMO();

        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }

   
}
