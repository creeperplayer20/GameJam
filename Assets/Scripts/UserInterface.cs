using System.Collections;
﻿using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

class UserInterface : Player
{
    [SerializeField] 
    TMP_Text textAmmo;

    [SerializeField]
    Image weaponDisplay;

    private void Start()
    {
        UpdateHp();
    }

    public void UpdateHp()
    {
        textHP.text = HP.ToString();
        textHP.GetComponentInParent<Slider>().value = HP;
    }

    static public void UpdateHp(TMP_Text textHp, int HP)
    {
        textHp.text = HP.ToString();
        textHp.GetComponentInParent<Slider>().value = HP;
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

    static public void StartDead()
    {
        MenuControl.LoadScene("DeadScreen", true);
    }

}