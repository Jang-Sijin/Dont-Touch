using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerEx : MonoBehaviour
{
    public enum SceneType
    {
        Unknown,
        TitleScene,
        GamePlayScene
    }

    private SceneType _currentSceneType = SceneType.Unknown;
    public SceneType CurrentSceneType 
    {
        get 
        {
            if(_currentSceneType != SceneType.Unknown) 
                return _currentSceneType;

            return CurrentSceneType;
        }
        set { _currentSceneType = value; } 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
