using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEvent : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        EventManager.Click += Teleport;
    }

    private void OnDisable()
    {
        EventManager.Click -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
