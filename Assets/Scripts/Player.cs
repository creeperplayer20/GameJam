using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp;
        
    public int HP
    {
        get => hp;

        set
        {
            if (value < 0)
                hp = 0;
            if (value > 0)
                hp = 100;

            hp = value;
        }
    }

    private int level;

    int Level
    {
        get
        {
            return Level;
        }

        set
        {
            if (value < 0)
                Level = 0;
            if (value > 20)
                Level = 20;
        }
    }

    void Start()
    {
        UserInterface ui = new UserInterface();
    }

    void LevelUp(int levels)
    {
        Level = Level + levels;
    }
}