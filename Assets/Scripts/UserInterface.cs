using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class UserInterface : Player
{
    [SerializeField]
    TMP_Text textHp;

    [SerializeField]
    Image weaponDisplay;

    public UserInterface() : base() {
        this.HP = base.HP;
    }

    private void Update()
    {
        UpdateHp();
    }

    private void UpdateHp()
    {
        textHp.text = "♥ " + HP;
    }
<<<<<<< Updated upstream
=======

    static public void UpdateAmmo(TMP_Text textAmmo, int currentAmmo ,int maxAmmo)
    {
        textAmmo.text = currentAmmo + "/" + maxAmmo;
        //Debug.Log(textAmmo.text);
    }

    public void UpdateAmmo(int currentAmmo, int maxAmmo)
    {
        this.textAmmo.text = currentAmmo + "/" + maxAmmo;
        //Debug.Log(this.textAmmo.text);
    }
>>>>>>> Stashed changes
}