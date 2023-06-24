using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBack : IEase
{
    const float param1 = 1.70158f;
    const float param2 = param1 + 1;
    public float calcEase(float a)
    {
        float res = param2 * Mathf.Pow(a, 3) - param1 * Mathf.Pow(a, 2);
        return res;
    }
}
