using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponDisplay : MonoBehaviour
{
    [SerializeField]
    Transform weaponInfo;

    [SerializeField]
    TMP_Text ammoCount;

    [SerializeField]
    WeaponSwap weaponSwap;

    // zavolá se chvilièku pøed Start()
    void Awake()
    {
        weaponSwap.weaponChanged += OnWeaponChanged;
        weaponSwap.Weapon.ForEach(w => w.AmmoCountChanged += OnAmmoCountChanged);
    }

    private void OnAmmoCountChanged(Weapon weapon)
    {
        ChangeAmmo(weapon.CurrentAmmoCount, weapon.AmmoCount);
    }

    private void OnWeaponChanged(Weapon weapon)
    {
        ChangeAmmo(weapon.CurrentAmmoCount, weapon.AmmoCount);
    }

    private void ChangeAmmo(int current, int max)
    {
        ammoCount.text = $"{current}/{max}";
    }
}
