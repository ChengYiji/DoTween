using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutBack : IEase
{
    const float param1 = 1.70158f;
    const float param2 = param1 * 1.525f;
    public float calcEase(float a)
    {
        float res;
        if (a < 0.5)
        {
            res = (Mathf.Pow(2 * a, 2) * ((param1 + 1) * 2 * a - param2)) / 2;
        }
        else
        {
            res = (Mathf.Pow(2 * a - 2, 2) * ((param2 + 1) * (a * 2 - 2) + param2) + 2) / 2;
        }
        return res;
    }
}
