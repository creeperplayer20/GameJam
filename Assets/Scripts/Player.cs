using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField]
    private int hp;
=======
    private int hp => HP;

   public int HP
    {
        protected get => HP;
>>>>>>> c367ad4ac5e2b1b76575fa44b2b76be8ca184c5e
        
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

    private int level => Level;

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
