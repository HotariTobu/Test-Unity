using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RayRenderer : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;

    private LineRenderer _lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _lineRenderer.SetPositions(new Vector3[] { startPoint.position, endPoint.position });
    }
}
