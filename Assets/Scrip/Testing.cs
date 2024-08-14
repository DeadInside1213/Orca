using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private Grid grid;
    void Start()
    {
        grid = new Grid(4,2, 10, new Vector3(20, 0));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue( UtilsClass.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition())); 
        }
    }
}
