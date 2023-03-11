using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public class WeaponSwap : MonoBehaviour
{
    public event Action<Weapon> weaponChanged;

    [SerializeField]
    public List<Weapon> Weapon;

    // Start is called before the first frame update
    void Start()
    {
        Weapon = GetComponentsInChildren<Weapon>().ToList();
        ActivateWeapon(0);
        //weapons.Average(weapon => weapon.pocetNaboju);
        //weapons.Count(weapon => weapon.pocetNaboju > 5);
    }

    private void ActivateWeapon(int index)
    {
        // deaktivace a pak aktivace s indexem z parametru.
        // weapons.ForEach(weapon => { weapon.gameObject.SetActive(false); });

        foreach (Weapon weapon in Weapon)
        {
            weapon.gameObject.SetActive(false);
        }

        Weapon[index].gameObject.SetActive(true);

        weaponChanged?.Invoke(Weapon[index]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ActivateWeapon(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ActivateWeapon(1);
    }
}
