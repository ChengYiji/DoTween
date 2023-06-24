using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TWEEN_STATES
{
    NORMAL = 1,
    PAUSE = 2,
}

public abstract class TweenBase
{
    public bool disposeTag;

    protected TWEEN_STATES curState;

    protected float elpasedTime;

    protected EASE_TYPE myEase;

    protected IEase easeObj;

    protected float tweenTime;


    public TweenBase(float time, EASE_TYPE easyType)
    {
        curState = TWEEN_STATES.NORMAL;
        tweenTime = time;
        elpasedTime = 0;
        myEase = easyType;
        easeObj = EaseManager.CreateEase(easyType);
        disposeTag = false;
    }
    public void Run(float deltaTime)
    {
        // 处理暂停和tween完成
        if (disposeTag)
        {
            return;
        }
        if (curState == TWEEN_STATES.PAUSE)
        {
            return;
        }
        // 计算时间
        elpasedTime += deltaTime;
        // 计算ease结果
        float mul = easeObj.calcEase(Mathf.Min(elpasedTime / tweenTime, 1));
        MyRun(mul);
        // 判断完成
        if (elpasedTime >= tweenTime)
        {
            disposeTag = true;
        }
    }
    protected abstract void MyRun(float deltaMul);

    public abstract void Dispose();

    public void Pause()
    {
        curState = TWEEN_STATES.PAUSE;
    }

    public void Resume()
    {
        curState = TWEEN_STATES.NORMAL;
    }
}
