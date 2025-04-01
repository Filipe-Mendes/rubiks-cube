using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour
{
    /* 
    private MainCube cube;
    [SerializeField] public int MAX_CUBE_SIZE = 6;
    [SerializeField] public int MIN_CUBE_SIZE = 2;
    [SerializeField] public float SUB_CUBE_INTERVAL = 0.2f;
 */

    private int CUBE_SIZE;

    private int[][][] cubes;

    [SerializeField] public Material cubeMaterial;
    [SerializeField] public Shader cubeShader;
    [SerializeField] public bool colorblind = false;
    private Color[] colors;

    public void CreateCube(int cubeSize)
    {
        CUBE_SIZE = cubeSize;
        SetColors();
        CreateCubes();
    }

    private void CreateCubes()
    {
        // cubes = new int[CUBE_SIZE][][];
        // TODO: INITIALIZE EACH ONE OF THE ARRAYS IN THE CORRESPONDING FOR LOOPS 
        // height represents the cube's height - Y
        // column represents the cube's columns (left to right) - Z
        // row represents the cube's rows (back to front) - X
        for (int height = CUBE_SIZE; height > 0; height--)
        {
            for (int column = CUBE_SIZE; column > 0; column--)
            {
                for (int row = CUBE_SIZE; row > 0; row--)
                {
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(row, height, column);
                    cube.name = "cube_" + height + "_" + column + "_" + row;
                    cube.GetComponent<Renderer>().material = cubeMaterial;

                }
            }
        }
    }

    private void SetColors()
    {
        if (colorblind)
        {
            //TODO: TO BE CHANGED
            colors = new[] { Color.red, Color.cyan, Color.green, Color.blue, Color.white, Color.black };
        }
        else
        {
            colors = new[] { Color.red, Color.yellow, Color.green, Color.blue, Color.white, Color.black };
        }

        cubeMaterial.shader = cubeShader;
        cubeMaterial.SetColor("_Top", colors[0]);
        cubeMaterial.SetColor("_Bottom", colors[1]);
        cubeMaterial.SetColor("_Front", colors[2]);
        cubeMaterial.SetColor("_Back", colors[3]);
        cubeMaterial.SetColor("_Left", colors[4]);
        cubeMaterial.SetColor("_Right", colors[5]);
    }

    public void RotateRow(int index){}
    public void RotateColumn(int index){}


}
