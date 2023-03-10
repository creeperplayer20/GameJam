using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int HP
    {
        get
        {
            return HP;
        }
        set
        {
            if (value < 0)
                HP = 0;
            if (value > 0)
                HP = 100;

            HP = value;
        }
    }

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
            if (value >= 20)
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
