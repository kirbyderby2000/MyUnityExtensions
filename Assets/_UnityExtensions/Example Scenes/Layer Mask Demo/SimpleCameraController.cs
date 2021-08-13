using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    
    [SerializeField] float mouseSensitivity;
    Transform playerCamera;
    Vector3 eulerAngle;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
        eulerAngle = playerCamera.eulerAngles;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        eulerAngle.y += mouseX;
        eulerAngle.x -= mouseY;
        eulerAngle.x = Mathf.Clamp(eulerAngle.x, -90.0f, 90.0f);

        playerCamera.eulerAngles = eulerAngle;

    }


    
}
