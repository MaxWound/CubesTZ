using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Vector3 StartPoint;
    float distanceFromStart;
    float lifeDistance;
    float speed;
    CubeSpawnerScript spawnerScript;
  
    private void Start()
    {
        spawnerScript = GameObject.Find("Spawner").GetComponent<CubeSpawnerScript>();
        lifeDistance = spawnerScript.distance;
        speed = spawnerScript.speed;
        StartPoint = transform.position;
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Vector3.Distance(StartPoint, transform.position) >= lifeDistance)
        {
            Destroy(gameObject);
        }
    }
}
