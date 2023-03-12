using System.Collections;
﻿using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;

class UserInterface : Player
{
    [SerializeField]
    TMP_Text textHp;

    [SerializeField] 
    TMP_Text textAmmo;

    [SerializeField]
    Image weaponDisplay;

    public void UpdateHp()
    {
        textHp.text = "♥ " + HP;
    }

    static public void UpdateAmmo(TMP_Text textAmmo, int currentAmmo ,int maxAmmo)
    {
        textAmmo.text = currentAmmo + "/" + maxAmmo;
        Debug.Log(textAmmo.text);
    }

    public void UpdateAmmo(int currentAmmo, int maxAmmo)
    {
        this.textAmmo.text = currentAmmo + "/" + maxAmmo;
        Debug.Log(this.textAmmo.text);
    }
}