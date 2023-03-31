using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    private Health health;

    private void Start(){
        health = GetComponent<Health>();
        Debug.Log(health.currentHP);

        health.TakeDamage(5);
    }

}