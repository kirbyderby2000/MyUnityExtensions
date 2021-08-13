using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 8.0f;
    [SerializeField] LayerMask floorLayerMask;
    Camera mainCamera;
    Vector3 destinationPosition;


    // Start is called before the first frame update
    void Start()
    {
        destinationPosition = transform.position;
        mainCamera = Camera.main;
    }

    private void Update()
    {
        MonitorInput();
        Move();        
    }

    

    private void MonitorInput()
    {
        if (PlayerClickedMouse())
        {
            Ray mouseCursorRay = MousePositionRay();
            if (Physics.Raycast(mouseCursorRay, out RaycastHit hitInfo, 1000.0f, floorLayerMask))
            {
                destinationPosition = hitInfo.point;
            }
        }
    }



    private bool PlayerClickedMouse()
    {
        return Input.GetMouseButtonDown(0);
    }

    private Ray MousePositionRay()
    {
        return mainCamera.ScreenPointToRay(Input.mousePosition);
    }

    private void Move()
    {
        if (Vector3.Distance(transform.position, destinationPosition) > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, destinationPosition, Time.deltaTime * movementSpeed);
        }
    }
}
