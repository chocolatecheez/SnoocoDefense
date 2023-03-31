using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Tower tower_todamage;

    private void Update()
    {
        
        if (tower_todamage != null)
        {
            tower_todamage.health.TakeDamage(1);
        }
    }
}
