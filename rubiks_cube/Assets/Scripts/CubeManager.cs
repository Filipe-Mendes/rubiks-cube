using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private CubeView cubeView;
    private MainCube cube;

    [SerializeField] public int CUBE_SIZE = 3;
    [SerializeField] public int MAX_CUBE_SIZE = 6;
    [SerializeField] public int MIN_CUBE_SIZE = 2;
    [SerializeField] public float SUB_CUBE_INTERVAL = 0.2f;

    [SerializeField] public Material cubeMaterial;
    [SerializeField] public Shader cubeShader;
    [SerializeField] public bool colorblind = false;
    private Color[] colors;

    void Start()
    {
        cubeView = GetComponent<CubeView>();
        cubeView.CreateCube(CUBE_SIZE);
        cube = new MainCube(CUBE_SIZE, 0, 1, 2, 3, 4, 5);
    }

    public void RotateRow(int index)
    {
        cube.RotateRow(index);
        cubeView.RotateRow(index);
    }
    public void RotateColumn(int index)
    {
        cube.RotateColumn(index);
        cubeView.RotateColumn(index);
    }


    private void PrintCube()
    {
        Debug.Log("FRONT FACE");
        cube.top.PrintFace();
        Debug.Log("BOTTOM FACE");
        cube.bottom.PrintFace();
        Debug.Log("FRONT FACE");
        cube.front.PrintFace();
        Debug.Log("BACK FACE");
        cube.back.PrintFace();
        Debug.Log("LEFT FACE");
        cube.left.PrintFace();
        Debug.Log("RIGHT FACE");
        cube.right.PrintFace();

    }
}
