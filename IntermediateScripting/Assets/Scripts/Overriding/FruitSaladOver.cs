using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppleOver myApple = new AppleOver();

        myApple.SayHello();
        myApple.Chop();

        FruitOver myFruit = new AppleOver();
        myFruit.SayHello();
        myFruit.Chop();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
