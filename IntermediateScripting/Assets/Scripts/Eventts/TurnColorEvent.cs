using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorEvent : MonoBehaviour
{
    private Renderer renderGuy;
    private void Start()
    {
        renderGuy = GetComponent<Renderer>();
    }
    private void OnEnable()
    {
        EventManager.Click += TurnColor;
    }
    private void OnDisable()
    {
       EventManager.Click -= TurnColor;
    }
    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        renderGuy.material.color = col;
    }
}
