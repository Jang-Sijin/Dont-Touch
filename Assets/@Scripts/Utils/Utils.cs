using UnityEngine;

public class Utils
{
    // [컴포넌트 반환]
    // 하위 오브젝트를 검색하여 name과 동일한 오브젝트에 제네릭 T 타입의 컴포넌트를 가져온다.
    // 1세대 자식 오브젝트에 존재할 경우 recursive 값은 false로, N세대 자식 오브젝트에 존재할 경우 true로 설정한다.
    public static T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if(go == null)
            return null;

        if(recursive == false)
        {
            Transform transform = go.transform.Find(name);
            
            if(transform != null) 
                return transform.GetComponent<T>();
        }
        else
        {
            foreach(T component in go.GetComponentsInChildren<T>())
            {
                if(string.IsNullOrEmpty(name) || component.name == name)
                    return component;
            }
        }

        return null;
    }

    // [게임 오브젝트 반환]
    public static GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        Transform transform = FindChild<Transform>(go, name, recursive);
        if (transform != null)
            return transform.gameObject;
        
        return null;
    }
}