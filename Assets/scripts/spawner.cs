using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        Spawm();
    }

    // Update is called once per frame
    void Update()
    {
        if (bullet == null)
        {
            Spawn();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject spawnedBullet = Instantiate(prefab);
        Bullet = spawnedBullet.GetComponent<Bullet>();
    }

    void Fire()
    {
        Bullet.hasBeenFired =
        Bullet = null;
    }
}