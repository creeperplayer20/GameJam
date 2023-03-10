using System.Collections;
using System.Collections.Generic;
﻿using System;
using UnityEngine;
using TMPro;

class UserInterface : Player
{
    [SerializeField]
    TMP_Text textHp;

    public UserInterface() : base() {
        this.HP = base.HP;
    }

    private void Update()
    {
        UpdateHp();
    }

    void UpdateHp()
    {
        textHp.text = "♥ " + HP;
    }
}