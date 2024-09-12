using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public string Name { get; private set; } = "Cube";
    public override void ShowShapeText()
    {
        PrintText($"I'm a yellow {Name}");
    }

}
