using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InSine : IEase
{
    public float calcEase(float a)
    {
        float res = 1 - Mathf.Cos((a * Mathf.PI) / 2);
        return res;
    }
}
