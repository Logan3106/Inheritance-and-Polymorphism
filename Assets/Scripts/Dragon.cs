using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 150;
        enemyPower = 50;
        LookAtPlayer();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

    }

    protected override void LookAtPlayer()
    {
        print("Dragon is looking at player now");
        print("dragon power = " + enemyPower);
        print("dragon health = " + enemyHealth);
    }
}
