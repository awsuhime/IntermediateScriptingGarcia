using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClassG myclass = new SomeClassG();

        myclass.GenericMethod<int>(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
