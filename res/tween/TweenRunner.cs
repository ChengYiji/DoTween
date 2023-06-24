using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenRunner : MonoBehaviour
{
    void Update()
    {
        TweenManager.Instance.UpdateAllTween();
    }
}
