using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPiece
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

        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 2));
    }
}
