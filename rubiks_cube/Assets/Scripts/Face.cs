using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Face
{
    private int[][] face;
    private int cubeSize;


    public Face(int cubeSize, int initialValue)
    {
        this.cubeSize = cubeSize;
        this.face = new int[cubeSize][];
        for (int i = 0; i < cubeSize; i++)
        {
            face[i] = Enumerable.Repeat(initialValue, cubeSize).ToArray();
        }
    }

    public int[] GetColumn(int index)
    {
        int[] values = new int[cubeSize];
        for (int i = 0; i < cubeSize; i++)
        {
            values[i] = face[i][index];
        }
        return values;
    }

    public void SetColumn(int index, int[] values)
    {
        for (int i = 0; i < cubeSize; i++)
        {
            face[i][index] = values[i];
        }
    }

    public int[] GetRow(int index)
    {
        return face[index];
    }

    public void SetRow(int index, int[] values)
    {
        this.face[index] = (int[])values.Clone();
    }

    public void PrintFace()
    {
        string str = "";
        for (int row = 0; row < cubeSize; row++)
        {
            for (int column = 0; column < cubeSize; column++)
            {
                str += face[row][column];
            }
            str += "\n";
        }
        Debug.Log(str);
    }
}
