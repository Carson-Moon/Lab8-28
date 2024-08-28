using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    private Color gizmoColor = Color.yellow;

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        //Vector3 forwardDirection = transform.TransformDirection(Vector3.forward) * gizmoSize;

        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 1));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, -1));
    }
#endif
}
