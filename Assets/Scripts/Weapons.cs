using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    int damage;
    bool isActive;

    [SerializeField]
    GameObject weaponObject;
}
