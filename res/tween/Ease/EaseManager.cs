using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EASE_TYPE
{
    Liner = 1,
    EaseInSine = 2,
    EaseOutSine = 3,
    EaseInOutSine = 4,
    EaseInBack = 5,
    EaseOutBack = 6,
    EaseInOutBack = 7
}

public class EaseManager
{
    public static IEase CreateEase(EASE_TYPE easeType)
    {
        switch (easeType)
        {
            case EASE_TYPE.Liner:
                return new Liner();
            case EASE_TYPE.EaseInSine:
                return new InSine();
            case EASE_TYPE.EaseOutSine:
                return new OutSine();
            case EASE_TYPE.EaseInOutSine:
                return new InOutSine();
            case EASE_TYPE.EaseInBack:
                return new InBack();
            case EASE_TYPE.EaseOutBack:
                return new OutBack();
            case EASE_TYPE.EaseInOutBack:
                return new InOutBack();
            default:
                throw new ArgumentException("Invalid ease type");
        }
    }
}
