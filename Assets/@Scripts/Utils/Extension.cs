using System;
using UnityEngine;

public static class Extension
{
    public static void BindEvent(this GameObject go, Action action, Define.UIEvent type = Define.UIEvent.OnClick)
    {
        UI_Base.BindEvent(go, action, type);
    }
}