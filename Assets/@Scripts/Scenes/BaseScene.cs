using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class BaseScene : MonoBehaviour
{
    public SceneType SceneType = SceneType.Unknown;
    protected bool _init = false;

    public void Start()
    {
        Init();
    }

    protected virtual bool Init()
    {
        if (_init)
            return false;

        _init = true;

        GameObject go = GameObject.Find("EventSystem");
        if(go == null)
        {

        }

        return true;
    }
}
