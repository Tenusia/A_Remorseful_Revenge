using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour, IWeapon
{
    [SerializeField] private WeaponInfo weaponInfo;
    
    public void Attack() {
        Debug.Log("BOW");
    }

    public WeaponInfo GetWeaponInfo() {
        return weaponInfo;
    }
}
