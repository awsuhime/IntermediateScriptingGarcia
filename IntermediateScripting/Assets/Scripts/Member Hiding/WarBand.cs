using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    private void Start()
    {
        Human human = new Human();
        Human enemy = new Enemy();
        Human orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
    


}
