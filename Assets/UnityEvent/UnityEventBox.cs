using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventBox : MonoBehaviour
{
    Vector3 pos1 = new Vector3(5, 5, 0);
    Vector3 pos2 = new Vector3(-5, 5, 0);
    public void OnCilck()
    {
        if (transform.position == pos1)
        {
            transform.position = pos2;
        }
        else
        {
            transform.position = pos1;
        }
    }
}
