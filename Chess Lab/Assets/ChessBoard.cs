using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    public Color activeColor;
    public Color black;
    public Color white;


    private void Awake()
    {
        activeColor = black;
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        int layer = 0;

        for(int i=0; i<8; i++)
        {
            for(int j=0; j<8; j++)
            {
                // Change gizmo color.
                if(layer % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        Gizmos.color = white;
                    }
                    else
                    {
                        Gizmos.color = black;
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        Gizmos.color = black;
                    }
                    else
                    {
                        Gizmos.color = white;
                    }
                }
                
                //ToggleColor();
                //Gizmos.color = activeColor;

                Gizmos.DrawCube(new Vector3(j, i, 0), Vector3.one);
            }

            layer++;
        }
    }

#endif

    private void ToggleColor()
    {
        if (activeColor == black)
            activeColor = white;
        else
            activeColor = black;
    }
}
