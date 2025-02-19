using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExG : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GenericClassG<int> myClass = new GenericClassG<int>();

        myClass.UpdateItem(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
