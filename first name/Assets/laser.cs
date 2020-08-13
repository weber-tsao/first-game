using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float _laserLength;
    private LineRenderer _lineRenderer;
    //bool shootLaser = true;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        InvokeRepeating("shootLaser", 2f, 2f);
        //if (shootLaser == true) {
        //Vector3 endPosition = (transform.right * _laserLength) + (transform.position);
        //_lineRenderer.SetPositions(new Vector3[] { transform.position, endPosition });
        //print(Time.time);

        //}
        //print((transform.right * _laserLength) + (transform.position));
        //print(transform.position);
    }

    void shootLaser()
    {
        Vector3 endPosition = (transform.right * _laserLength) + (transform.position);
        _lineRenderer.SetPositions(new Vector3[] { transform.position, endPosition });
    }
    
}
