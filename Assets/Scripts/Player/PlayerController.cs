using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameManager gm;
    public float speed = 15f;
    
    private void Update()
    {
        if (gm.gameStart)
        {
            if (Input.GetMouseButton(0))
            {
                Move();
            }
        }
    }

    private void FixedUpdate()
    {
        if (gm.gameStart)
        {
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        }        
    }

    public void Move()
    {
        float swipeSpeed = 5;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.localPosition.z;

        Ray ray = Camera.main.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray,out RaycastHit hit, 80))
        {
            Vector3 hitPoint = hit.point;
            hitPoint.y = transform.position.y;
            hitPoint.z = transform.position.z;

            transform.position = Vector3.MoveTowards(transform.position, hitPoint, Time.deltaTime * swipeSpeed);
        }
    }
}
