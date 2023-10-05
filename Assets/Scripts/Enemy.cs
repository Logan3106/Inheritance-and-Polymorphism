using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int enemyPower;
    public int enemyHealth;


    public void Start()
    {
        enemyHealth = 10;
        enemyPower = 20;
        LookAtPlayer();
    }


    protected virtual void LookAtPlayer()
    {

        print("Enemy is looking at player at the moment");
        print(enemyPower);
        print(enemyHealth);
    }

}
