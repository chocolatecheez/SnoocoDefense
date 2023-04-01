using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Tower tower_todamage;
    private STATathon turd;
    private float time_pass;
    private void Start()
    {
        turd = GetComponent<STATathon>();

    }
    private void Update()
    {
        
        if (tower_todamage != null)
        {
            time_pass += Time.deltaTime;

            if (time_pass >= turd.slap)
            {
                time_pass = 0;
                tower_todamage.health.TakeDamage(turd.attack);
            }
        }
    }
}
