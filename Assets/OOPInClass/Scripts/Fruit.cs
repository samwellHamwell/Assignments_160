/*****************************************************************************
// File Name : Fruit.cs
// Author : Sam D. Hooker
// Creation Date : January 24, 2024
//
// Brief Description : This is a sample document that teaches students how to
comment. Students have to follow this commenting style
exactly so that they don't get points deducted.
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string name;
    public string color;
    public float weight;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="c"></param>
    /// <param name="w"></param>
    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "Orange";
        color = "Yellow";
        weight = 1.4f;
    }
    public Fruit(string name)
    {
        this.name = name;
        color = "blue";
        weight = 2f;
    }
    public Fruit(float w)
    {
        name = "Watermelon";
        color = "green";
        weight = 324567f;
    }
}
