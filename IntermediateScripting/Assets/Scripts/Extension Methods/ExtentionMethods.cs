using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtentionMethods 
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = Vector3.one;
    }
}
