using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            //Actually shoots the bullet and plays sound effect
            Shoot();
            SoundManagerScript.PlaySound("shootSound");
        }
	}
    void Shoot ()
    {
        //Shooting logic (makes the bullet spawn)
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
