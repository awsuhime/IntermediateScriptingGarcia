using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityQuat : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePosyy = target.position + new Vector3(0, 1.5f, 0) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePosyy);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}
