using System.Collections;
﻿using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

class UserInterface : Player
{
    [SerializeField] 
    TMP_Text textAmmo;

    [SerializeField]
    Image weaponDisplay;

    [SerializeField]
    public static int EnemyCount;

    [SerializeField]
    public static int SecondEnemyCount;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        UpdateHp();
    }

    private void Update()
    {
        if (EnemyCount <= 0)
        {
            MenuControl.LoadScene("WinScreen", true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuControl.LoadScene("Menu", true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    static public void SetDifficulties(int difficulty)
    {
        switch (difficulty)
        {
            case 0:
                SecondEnemyCount = 10;
                break;

            case 1:
                SecondEnemyCount = 20;
                break;

            case 2:
                SecondEnemyCount = 30;
                break;
          


        }
    }
}