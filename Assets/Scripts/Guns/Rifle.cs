using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    protected override void ProcessShootingInput()
    {
        if (Input.GetButton("Fire1"))
            if (currentAmmoCount > 0 && currentShootCooldown <= 0 && !IsReloading)
                Shoot();
    }

    
}
