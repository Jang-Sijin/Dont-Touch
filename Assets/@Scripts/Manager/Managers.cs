using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance = null;
    public static Managers Instance
    {
        get { return s_instance; }
    }

    private SceneManagerEx _scene = new SceneManagerEx();

    public static SceneManagerEx Scene { get { return Instance?._scene; } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
