using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Planemanager planemanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Jelly")){
            planemanager.SpawnNextPlane(transform.position + Vector3.forward * 200);
        }
    }
}
