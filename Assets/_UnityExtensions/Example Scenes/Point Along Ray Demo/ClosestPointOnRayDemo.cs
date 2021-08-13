using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;

public class ClosestPointOnRayDemo : MonoBehaviour
{
    [SerializeField] Transform rayOrigin;
    [SerializeField] Transform rayEnd;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Transform closestPointToCalculate;
    [SerializeField] Transform closestPointTransform;

    private void Awake()
    {
        lineRenderer.positionCount = 2;
        
    }

    private void Update()
    {
        Ray ray = CreateRay();

        closestPointTransform.transform.position = ray.ClosestPointAlongRay(closestPointToCalculate.position);

        UpdateLineRenderer();
    }

    private Ray CreateRay()
    {
        return new Ray(rayOrigin.position, rayEnd.position - rayOrigin.position);
    }
    private void UpdateLineRenderer()
    {
        lineRenderer.SetPosition(0, rayOrigin.position);
        lineRenderer.SetPosition(1, rayEnd.position);
    }
}
