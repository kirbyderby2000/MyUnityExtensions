using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;

public class LayerMaskDemo : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;

    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the mouse clicked the mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast the mouse cursor on the screen
            if (Physics.Raycast(CenterOfScreenRay(), out RaycastHit hitInfo))
            {
                // If the layer mask contains the layer of the ray cast hit object,
                // debug log a positive hit message
                if (layerMask.ContainsLayer(hitInfo.collider.gameObject.layer))
                {
                    Debug.Log("Layer Mask Contains: " + UnityEngine.LayerMask.LayerToName(hitInfo.collider.gameObject.layer));
                }
                // otherwise debug log a negative hit message
                else
                {
                    Debug.Log("Layer Mask Does NOT Contain: " + UnityEngine.LayerMask.LayerToName(hitInfo.collider.gameObject.layer));
                }
            }
        }
    }

    private Ray CenterOfScreenRay()
    {
        return mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
    }
}
