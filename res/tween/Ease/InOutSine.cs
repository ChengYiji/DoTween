using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutSine : IEase
{
    public float calcEase(float a)
    {
        float res = -(Mathf.Cos(Mathf.PI * a) - 1) / 2;
        return res;
    }
}
