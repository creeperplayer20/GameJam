using System.Collections;
﻿using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class UserInterface : Player
{
    [SerializeField]
    TMP_Text textHp;

    [SerializeField]
    Image weaponDisplay;

    public UserInterface() : base() {
        this.HP = base.HP;
    }

    private void Update()
    {
    }

    void UpdateHp()
    {
        textHp.text = "♥ " + HP;
    }
}