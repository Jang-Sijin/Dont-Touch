using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    // Scene�� Root UI�� �����Ѵ�.

    protected override bool Init()
    {
        if(base.Init() == false)
        {
            return false;
        }

        SceneType = Define.SceneType.TitleScene;

        return true;
    }
}
