using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutSine : IEase
{
    public float calcEase(float a)
    {
        float res = Mathf.Sin((a * Mathf.PI) / 2);
        return res;
    }
}
