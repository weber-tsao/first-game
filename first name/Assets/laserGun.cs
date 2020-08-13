using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class laserGun : MonoBehaviour
{
    [SerializeField] private float drfDistanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer m_lineRenderer;
    Transform m_transform;

    public void update()
    {
        shootLaser();
    }

    private void awake()
    {
        m_transform = GetComponent<Transform>();
    }

    void shootLaser()
    {
        if (Physics2D.Raycast(m_transform.position, transform.right))
        {
            RaycastHit2D _hit = Physics2D.Raycast(laserFirePoint.position, transform.right);
            draw2DRay(laserFirePoint.position, _hit.point);
        }
        else
        {
            draw2DRay(laserFirePoint.position, laserFirePoint.transform.right * drfDistanceRay);
        }
    }

    void draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);
    }


}
