using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI shapeText;
    public virtual void ShowShapeText()
    {
        PrintText($"I'm a simple shape");
    }
    public void PrintText(string text)
    {
        shapeText.SetText(text);
    }
}
