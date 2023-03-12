using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp = 100;

    [SerializeField]
    private int time = 180000; // in sec
    
    [SerializeField]
    private float currtime; // in sec


    [SerializeField]
    protected TMP_Text textHP;        
    public int HP
    {
        get
        {
            return hp;
        }

        set
        {
            if (value < 0)
                hp = 0;
            if (value > 0)
                hp = 100;


            hp = value;
        }
    }

    private void Awake()
    {
        currtime = time;
        HitTimer();
    }

    private void Update()
    {
        HitTimer();
    }

    void HitTimer()
    {
        currtime -= 1 * Time.deltaTime;
        HP = (int)((currtime / time) * 100);
        UpdateHp();


        

         if (currtime <= 0 && HP <= 0)
            UserInterface.StartDead();
    }



    private void UpdateHp()
    {
        UserInterface.UpdateHp(textHP, HP);
    }

}