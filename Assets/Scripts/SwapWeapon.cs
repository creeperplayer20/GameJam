using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SwapWeapon : MonoBehaviour
{
    public event Action<Weapons> WeaponChanged;

    List<Weapons> weapons;

    public List<Weapons> Weapons
    {
        get
        {
            if (weapons == null)
            {
                weapons = GetComponentsInChildren<Weapons>(true).ToList();
            }
            return weapons;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        ActivateWeapon(0);
    }

    private void ActivateWeapon(int index)
    {
        weapons.ForEach(weapon => { weapon.gameObject.SetActive(false); });

        weapons[index].gameObject.SetActive(true);

        WeaponChanged?.Invoke(weapons[index]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { ActivateWeapon(0); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { ActivateWeapon(1); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { ActivateWeapon(2); }
    }
}
