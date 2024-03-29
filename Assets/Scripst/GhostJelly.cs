using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostJelly : MonoBehaviour
{
    public static GhostJelly instance;

    public Transform[] ghostPoses;
    private int index = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScaleOftheGhost(Vector3 scale) {
        scale.y *= 1.65f;
    transform.localScale = scale;   
    }




    public void ChanePosOftheGhost()
    {
        index++;
        if (ghostPoses.Length > index)
        {
            transform.position = ghostPoses[index].transform.position;
        }

    }



}
