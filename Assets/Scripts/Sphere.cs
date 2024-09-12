using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public string Name { get; private set; } = "Shpere";
    public override void ShowShapeText()
    {
        PrintText($"I'm a pink {Name}");
    }
}
