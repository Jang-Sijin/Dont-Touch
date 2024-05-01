using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utils;

public class Managers : MonoBehaviour
{
    public static Managers s_instance = null;
    public static Managers Instance { get { return s_instance; } }

    private SceneManagerEx _scene = new SceneManagerEx();
    //private UIManager _ui = new UIManager();
    private SoundManager _sound = new SoundManager();

    public static SceneManagerEx Scene { get { return Instance?._scene; } }
    //public static UIManager UI { get { return Instance?._ui;} }
    public static SoundManager Sound { get { return Instance?._sound; } }


    private void Awake()
    {
        Init();
    }

    public static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("Managers");

            if (go == null)
            {
                go = new GameObject { name = "Managers" };
            }

            s_instance = GetOrAddComponent<Managers>(go);
            DontDestroyOnLoad(go);

            // 각각의 매니저 인스턴트 초기화
            // s_instance._scene.Init();
            // s_instance._ui.Init();
            // s_instance._sound.Init();
        }
    }

    public static void Clear()
    {
        // s_instance._ui.Clear();
        // s_instance._sound.Clear();
    }
}
