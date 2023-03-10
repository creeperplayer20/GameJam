<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
=======
﻿using System;
using Unity.VisualScripting;
>>>>>>> c367ad4ac5e2b1b76575fa44b2b76be8ca184c5e
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

