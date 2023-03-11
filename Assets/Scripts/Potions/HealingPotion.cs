using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealingPotion : Potions
{
    float timeout;
    int efficiency;
    float localTimeout;
    Image image;
    
    public HealingPotion(float timeout, int efficiency)
    { 
        this.timeout = timeout;
        this.efficiency = efficiency;  
    }

    void Use(Player player)
    {
        player.HP =+ efficiency;
        localTimeout = timeout;
    }

    void Update()
    {
        if (localTimeout > 0)
        localTimeout = localTimeout - Time.deltaTime;
    }
}
