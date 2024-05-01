using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum SceneType
    {
        Unknown,    // 없음
        TitleScene, // 타이틀 씬
        InGameScene // 인게임 씬
    }

    public enum UIEvent
    {
        OnClick,    // 클릭 시, 즉시 발동
        OnPress     // 클릭 후, 발동
    }

    public enum Sound
    {
        Bgm,
        Effect,
        Max
    }
}
