using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenScale:TweenBase
{
    public Transform scaleObj;
    public Vector3 endScale;
    public Vector3 startScale;
    public Vector3 deltaScale;
    public TweenScale(Transform transform, float time, Vector3 startScale, Vector3 endScale, EASE_TYPE easeType) : base(time, easeType)
    {
        scaleObj = transform;
        this.startScale = startScale;
        this.endScale = endScale;
        deltaScale = endScale - startScale;
        scaleObj.localScale = startScale;
    }

    protected override void MyRun(float deltaMul)
    {
        Vector3 tempScale = startScale + deltaMul * deltaScale;
        scaleObj.localScale = tempScale;
    }

    public override void Dispose()
    {
        scaleObj = null;
    }
}
