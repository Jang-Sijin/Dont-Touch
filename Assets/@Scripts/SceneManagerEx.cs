using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerEx : MonoBehaviour
{
    private Define.SceneType _currentSceneType = Define.SceneType.Unknown;
    public Define.SceneType CurrentSceneType 
    {
        get 
        {
            if(_currentSceneType != Define.SceneType.Unknown) 
                return _currentSceneType;

            return CurrentSceneType;
        }
        set { _currentSceneType = value; } 
    }
}
