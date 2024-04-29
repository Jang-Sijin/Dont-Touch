using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    // 현재 씬에서 다른 씬으로 이동하기 위해 사용 - SceneType을 받아서 변경
    public void ChangeScene(Define.SceneType type)
    {
        _currentSceneType = type;

        SceneManager.LoadSceneAsync(GetSceneName(type));
    }
    
    private string GetSceneName(Define.SceneType type)
    {
        string name = System.Enum.GetName(typeof(Define.SceneType), type);

        return name;
    }
}
