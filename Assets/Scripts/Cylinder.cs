using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public string Name { get; private set; } = "Cylinder";
    public override void ShowShapeText()
    {
        PrintText($"I'm a purple {Name}");
    }
}
