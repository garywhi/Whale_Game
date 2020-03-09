using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawns;
    public Transform spawnpoint;

    private int rand;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    private void Start()
    {
        if (timeBtwSpawns <= 0)
        {
            Instantiate(spawns[0], spawnpoint.transform.position, Quaternion.identity);
        }
    }
}
