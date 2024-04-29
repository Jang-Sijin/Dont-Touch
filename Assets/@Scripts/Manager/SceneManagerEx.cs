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

    // ���� ������ �ٸ� ������ �̵��ϱ� ���� ��� - SceneType�� �޾Ƽ� ����
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
