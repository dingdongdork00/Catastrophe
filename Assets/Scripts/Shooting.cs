using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletForce;
    private float fireRate = 2f;
    private float nextFire = 0.5f;

    public bool firing;

    public AudioClip fireSound;
    private AudioSource fireSource;


    private void Start()
    {
        firing = false;
        fireSound = GetComponent<AudioClip>();
        fireSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && CanShoot())
        {
            Shoot();

        }
    }

    void Shoot()
    {
        //spawn bullet
        GameObject bullet  = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        firing = true;
       
       
    }

    public bool CanShoot()
    {
        bool canShoot = false;
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            canShoot = true;
        }

        return canShoot;
    }

}
