using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public float BulletForce = 35f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePoint.up * BulletForce, ForceMode.Impulse);
    }


}
