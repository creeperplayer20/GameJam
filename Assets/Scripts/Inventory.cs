using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Weapons> weapons = new List<Weapons>();
    List<Potions> potions = new List<Potions>();

    void AddToInventory(Weapons weapon)
    {
        weapons.Add(weapon);
    }

    void AddToInventory(Potions potion)
    {
        potions.Add(potion);
    }
}
    