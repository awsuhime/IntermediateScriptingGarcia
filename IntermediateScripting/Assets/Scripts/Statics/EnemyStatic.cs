using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatic : MonoBehaviour
{
    public static int enemyCount = 0;
    public EnemyStatic()
    {
        enemyCount++;
    }
}
