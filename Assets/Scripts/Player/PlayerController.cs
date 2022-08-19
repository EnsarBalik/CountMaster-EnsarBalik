using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameManager gm;

    Vector3 firstPos, endPos;
    public float HorSpeed = 0.05f;
    public float speed = 10f;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float DeltaX = endPos.x - firstPos.x;
            transform.Translate(DeltaX * Time.deltaTime * HorSpeed, 0, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        if (gm.gameStart)
        {
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        }
    }
}
