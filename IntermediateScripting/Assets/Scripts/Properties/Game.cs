using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public PlayerFunny player;
    public int x;
    void Start()
    {

        player.Experience = 5;
        x = player.Experience;
    }

    
}
