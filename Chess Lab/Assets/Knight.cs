using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece
{
#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        CheckMoves();
    }
#endif

    public override void CheckMoves()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawCube(transform.position + new Vector3(1, 2), new Vector3(.5f, .5f, .5f));
        Gizmos.DrawCube(transform.position + new Vector3(-1, 2), new Vector3(.5f, .5f, .5f));

        Gizmos.DrawCube(transform.position + new Vector3(1, -2), new Vector3(.5f, .5f, .5f));
        Gizmos.DrawCube(transform.position + new Vector3(-1, -2), new Vector3(.5f, .5f, .5f));

        Gizmos.DrawCube(transform.position + new Vector3(2, 1), new Vector3(.5f, .5f, .5f));
        Gizmos.DrawCube(transform.position + new Vector3(-2, 1), new Vector3(.5f, .5f, .5f));

        Gizmos.DrawCube(transform.position + new Vector3(2, -1), new Vector3(.5f, .5f, .5f));
        Gizmos.DrawCube(transform.position + new Vector3(-2, -1), new Vector3(.5f, .5f, .5f));
    }
}
