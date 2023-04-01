using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int currentHP;

    private void Update(){

    }

    public void TakeDamage(int damageToTake){
        currentHP -= damageToTake;

        if(currentHP <= 0){
            Destroy(gameObject);
        }

        Debug.Log(currentHP);
    }
}