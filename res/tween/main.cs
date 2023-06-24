using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject gObject;
    // Start is called before the first frame update
    void Start()
    {
        TweenParam tp = new TweenParam();
        tp.tweenType = TWEEN_TYPE.TweenScale;
        tp.startScale = new Vector3(0, 0, 0);
        tp.endScale = new Vector3(5, 5, 0);
        tp.time = 5;
        tp.tweenObj = gObject.transform;
        tp.easeType = EASE_TYPE.EaseOutSine;
        TweenManager.Instance.AddTween(tp);
    }
}
