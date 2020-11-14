﻿using System.Collections;
using System.Collections.Generic;
using GameFramework.Event;
using UnityEngine;

public class ReturnMenuEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(ReturnMenuEventArgs).GetHashCode();

    public override int Id
    {
        get { return EventId; }
    }

    public override void Clear()
    {
        
    }
}
