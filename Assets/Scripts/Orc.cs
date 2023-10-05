using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        enemyPower = 20;
        enemyHealth = 100;
        LookAtPlayer();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    protected override void LookAtPlayer()
    {
        print("Orc is looking at player now");
        print(enemyPower);
        print(enemyHealth);
    }
}
