﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrestler : MonoBehaviour
{
    public string wrestlerName;
    int health;
    public List<Attack> learnedAttacks = new List<Attack>();

    public int Health
    {
        get { return health; }
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        //Deducts health based on damage
        health -= damage;

        //Keeps health at 0
        if (health < 0)
            health = 0;
    }

    public void LearnAttack(Attack learnedAttack)
    {
        //Adds learnedAttack to list of learned attacks
        learnedAttacks.Add(learnedAttack);
    }
}