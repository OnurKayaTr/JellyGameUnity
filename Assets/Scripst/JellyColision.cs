using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Obstacle")
        {
            GhostJelly.instance.ChanePosOftheGhost();
        }
    }



}
