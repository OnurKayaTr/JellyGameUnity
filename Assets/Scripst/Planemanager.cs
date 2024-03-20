using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planemanager : MonoBehaviour
{
    public GameObject planePrefab;

    public void SpawnNextPlane(Vector3 planeSpawnPos)
    {
        Instantiate(planePrefab, planeSpawnPos, Quaternion.identity);
    }
}