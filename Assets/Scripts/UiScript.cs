using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScript : MonoBehaviour
{
    [SerializeField]
    TMP_InputField SpeedInput;
    [SerializeField]
    TMP_InputField TimeInput;
    [SerializeField]
    TMP_InputField DistanceInput;
    CubeSpawnerScript cubeSpawnerScript;
    private void Start()
    {
        cubeSpawnerScript = GameObject.Find("Spawner").GetComponent<CubeSpawnerScript>();
    }

    public void AssignSpeed()
    {
        cubeSpawnerScript.speed = float.Parse(SpeedInput.text);
        SpeedInput.text = null;
    }
    public void AssignTime()
    {
        cubeSpawnerScript.spawnDelay = float.Parse(TimeInput.text);
        TimeInput.text = null;
    }
    public void AssignDistance()
    {
        cubeSpawnerScript.distance = float.Parse(DistanceInput.text);
        DistanceInput.text = null;
    }
}
