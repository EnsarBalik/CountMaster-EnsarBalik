using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWall : MonoBehaviour
{
    public Transform RightVector;
    public Transform LeftVector;

    public void LateUpdate()
    {
        Vector3 viewpos = transform.position;
        viewpos.x = Mathf.Clamp(viewpos.x,LeftVector.transform.position.x,RightVector.transform.position.x);
        transform.position = viewpos;
    }
}
