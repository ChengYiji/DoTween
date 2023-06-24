using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBack : IEase
{
    const float param1 = 1.70158f;
    const float param2 = param1 + 1;
    public float calcEase(float a)
    {
        float res = 1 + param2 * Mathf.Pow(a - 1, 3) + param1 * Mathf.Pow(a - 1, 2);
        return res;
    }
}
