using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MainCube
{
    private int cubeSize;
    public Face top;
    public Face bottom;
    public Face front;
    public Face back;
    public Face left;
    public Face right;

    public MainCube(int cubeSize, int top, int bottom, int front, int back, int left, int right)
    {
        this.cubeSize = cubeSize;
        this.top = new Face(cubeSize, top);
        this.bottom = new Face(cubeSize, bottom);
        this.front = new Face(cubeSize, front);
        this.back = new Face(cubeSize, back);
        this.left = new Face(cubeSize, left);
        this.right = new Face(cubeSize, right);
    }

    public void RotateRow(int index){}
    public void RotateColumn(int index){}


}
