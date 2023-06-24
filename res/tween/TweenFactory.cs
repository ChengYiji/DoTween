using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TweenFactory
{
    public static TweenBase CreateTween(TweenParam tweenParam)
    {
        switch (tweenParam.tweenType)
        {
            case TWEEN_TYPE.TweenMove:
                return new TweenMove(tweenParam.tweenObj, tweenParam.time,
                    tweenParam.startPos, tweenParam.endPos, tweenParam.easeType);
            case TWEEN_TYPE.TweenScale:
                return new TweenScale(tweenParam.tweenObj, tweenParam.time,
                    tweenParam.startScale, tweenParam.endScale, tweenParam.easeType);
            default:
                throw new ArgumentException("Invalid ease type");

        }
    }
}
