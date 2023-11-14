using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public GameObject bulletPrefab;
    public UnityEvent EvenOnDestroyed;


    void Start()
    {
        Invoke("Shoot", Random.Range(1, 10));
    }

    void Shoot()
    {
        var bullet = GameObject.Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Vector3 dir = GameObject.FindWithTag("Player").transform.position - transform.position;
        bullet.GetComponent<Rigidbody>().AddForce(dir.normalized * 750);

        Invoke("Shoot", Random.Range(1, 10));
    }

    private void OnDestroy()
    {
        EvenOnDestroyed?.Invoke();
    }
}
