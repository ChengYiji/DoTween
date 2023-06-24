using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMove : TweenBase
{
    public Transform moveObj;
    public Vector3 endPos;
    public Vector3 startPos;
    public Vector3 deltaPos;
    public TweenMove(Transform transform,float time, Vector3 startPos, Vector3 endPos,EASE_TYPE easeType) : base(time, easeType)
    {
        moveObj = transform;
        this.startPos = startPos;
        this.endPos = endPos;
        deltaPos = endPos - startPos;
        moveObj.position = startPos;
    }

    protected override void MyRun(float deltaMul)
    {
        Vector3 tempPos = startPos + deltaMul * deltaPos;
        moveObj.position = tempPos;
    }

    public override void Dispose()
    {
        moveObj = null;
    }
}
