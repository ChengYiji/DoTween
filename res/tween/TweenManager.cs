using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TWEEN_TYPE
{
    TweenMove = 1,
    TweenScale = 2
}

public class TweenParam
{
    public TWEEN_TYPE tweenType;
    public Vector3 startPos;
    public Vector3 endPos;
    public Vector3 startScale;
    public Vector3 endScale;
    public float time;
    public Transform tweenObj;
    public EASE_TYPE easeType = EASE_TYPE.Liner;
}

public class TweenManager
{
    private static TweenManager _instance = new TweenManager();
    public static TweenManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private TweenManager() { }

    public List<TweenBase> tweens = new List<TweenBase>();

    public void AddTween(TweenParam tweenParam)
    {
        TweenBase tween = TweenFactory.CreateTween(tweenParam);
        tweens.Add(tween);
    }

    public void UpdateAllTween()
    {
        float deltaTime = Time.deltaTime;
        for (int i = tweens.Count - 1; i >= 0; i--)
        {
            if (tweens[i].disposeTag)
            {
                tweens[i].Dispose();
                tweens.RemoveAt(i);
                continue;
            }
            tweens[i].Run(deltaTime);
        }
    }
}
