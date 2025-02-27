using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating the fruit");
        FruitIn myFruit = new FruitIn();
        Debug.Log("Creating the apple");
        AppleIN myApple = new AppleIN();

        myFruit.SayHello();
        myFruit.Chop();

        
        myApple.SayHello();
        myApple.Chop();

        
        Debug.Log("Creating the fruit");
        myFruit = new FruitIn("yellow");
        Debug.Log("Creating the apple");
        myApple = new AppleIN("green");

       
        myFruit.SayHello();
        myFruit.Chop();

        
        myApple.SayHello();
        myApple.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
