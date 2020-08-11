using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float _laserLength;
    private LineRenderer _lineRenderer;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        Vector3 endPosition = (transform.right * _laserLength) + transform.position;
        _lineRenderer.SetPositions(new Vector3[] { transform.position, endPosition });


    }
}
