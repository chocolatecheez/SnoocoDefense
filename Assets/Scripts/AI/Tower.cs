using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    public Health health;

    private void Start(){
        health = GetComponent<Health>();

    }

}