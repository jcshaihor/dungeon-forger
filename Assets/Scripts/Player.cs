using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerHealth = 100;
    private float playerDmg = 10;
    private float playerAtkSpd =  100;


    // Start is called before the first frame update
    void Start()
    {
        Attack.AutoAttack(playerDmg, playerAtkSpd);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
