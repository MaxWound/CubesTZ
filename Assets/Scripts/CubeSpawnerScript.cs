using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerScript : MonoBehaviour
{
    [SerializeField]
    GameObject Cube;
    [SerializeField]
    GameObject SpawnerObj;


    public float speed;
    public float spawnDelay;
    public float distance;

    private float timerTime;
    private void Update()
    {
        if (spawnDelay != 0 && distance != 0 && speed != 0)
            if (timerTime >= spawnDelay)
            {
                Instantiate(Cube, SpawnerObj.transform.position, Quaternion.identity);
                timerTime = 0;
            }
            else
            {
                timerTime += Time.deltaTime;
            }
    }

}
