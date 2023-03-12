using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public event Action<Weapon> AmmoCountChanged;

   

    [SerializeField]
    protected int ammoCount;
    public int AmmoCount => ammoCount;

    protected int currentAmmoCount;
    public int CurrentAmmoCount
    {
        get { return currentAmmoCount; }
        protected set
        {
            currentAmmoCount = value;
            AmmoCountChanged?.Invoke(this);
        }
    }

    [SerializeField]
    protected float shootDelay;
    protected float currentShootCooldown;

    [SerializeField]
    protected float reloadTime;
    protected float currentReloadTime;

    protected bool IsReloading => currentReloadTime > 0;

    [SerializeField]
    protected GameObject bulletPrefab;
    [SerializeField]
    protected float bulletSpeed;
    [SerializeField]
    protected Transform bulletSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
        CurrentAmmoCount = ammoCount;
        UpdateAmmo();   
    }

    protected void Update()
    {
        UpdateTimers();
        ProcessShootingInput();
        ProcessReloadInput();
    }

    private void OnDisable()
    {
        if (IsReloading)
            currentReloadTime = reloadTime;
    }

    private void UpdateTimers()
    {
        currentShootCooldown -= Time.deltaTime;

        if (IsReloading)
        {
            currentReloadTime -= Time.deltaTime;
            if (currentReloadTime < 0)
                Reload();
        }
    }
    protected virtual void ProcessShootingInput()
    {
        if (Input.GetButtonDown("Fire1"))
            if (CurrentAmmoCount > 0 && currentShootCooldown <= 0 && !IsReloading)
                Shoot();
    }

    private void ProcessReloadInput()
    {
        if (Input.GetKeyDown(KeyCode.R) && CurrentAmmoCount != ammoCount && !IsReloading)
        {
            currentReloadTime = reloadTime;
            Reload();
        }
    }

    protected virtual void Shoot()
    {
        CurrentAmmoCount--;

        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Destroy(bullet, 5f);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        UpdateAmmo();

        currentShootCooldown = shootDelay;
    }

    private void UpdateAmmo()
    {
        UserInterface.UpdateAmmo(GetComponentInParent<WeaponSwap>().ammoText, CurrentAmmoCount, AmmoCount);
    }

    protected void Reload()
    {
        CurrentAmmoCount = ammoCount;
        UpdateAmmo();
    }
}
