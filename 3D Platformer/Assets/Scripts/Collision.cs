using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject player;
    public GameObject hitEffect;
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider != player.GetComponent<Collider>())
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
    }

}
