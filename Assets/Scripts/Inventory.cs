using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Weapon> weapons = new List<Weapon>();
    List<Potions> potions = new List<Potions>();

    void AddToInventory(Weapon weapon)
    {
        weapons.Add(weapon);
    }

    void AddToInventory(Potions potion)
    {
        potions.Add(potion);
    }
}
    