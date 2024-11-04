using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Animations;
using UnityEngine;

public class CubicalGrid : MonoBehaviour
{
    float x;
    float y;
    float z;
    float generalMagnitude;

    Vector3 start;

    int baseRects;
    int rectExtension;

    int downLines;
    int rightLines;
    int max;

    float space;

    Rect[] grid;
    //Rect e;

    private void Awake()
    {
        baseRects = 25;
        rectExtension = baseRects / 2;

        downLines = baseRects * rectExtension;
        rightLines = baseRects * rectExtension;

        max = downLines + rightLines;

        grid = new Rect[max];

        start = new Vector3(0, 0, 0);

        generalMagnitude = 50.0f;

        space = 0.5f;

        start.x += space;
        for (int j = 0; j < downLines; j++)
        {
            if (j % rectExtension == 0)
            {
                start.y += space;
                start.z = 0;
            }

            start.z += space;

            Rect aux = new(start, Vector3.down, generalMagnitude);


            grid[j] = aux;

        }


        start = Vector3.zero;

        for (int j = downLines; j < max; j++)
        {
            if (j % rectExtension == 0)
            {
                start.z += space;
                start.x = 0;
            }

            start.x += space * 4;

            Rect aux = new(start, Vector3.right, generalMagnitude);


            grid[j] = aux;
        }


        //e = new Rect(start, rotation, 100.0f);


    }

    //public Grid()
    //{

    //}

    public void BuildCube()
    {

    }

    public void DrawGrid()
    {
        Gizmos.color = Color.gray;

        for (int i = 0; i < max; i++)
        {
            Gizmos.DrawLine(grid[i].startPos, grid[i].finishPos);
        }
    }

    private void OnDrawGizmos()
    {
        DrawGrid();

    }

}
