using UnityEngine;

public class Utils
{
    // [������Ʈ ��ȯ]
    // ���� ������Ʈ�� �˻��Ͽ� name�� ������ ������Ʈ�� ���׸� T Ÿ���� ������Ʈ�� �����´�.
    // 1���� �ڽ� ������Ʈ�� ������ ��� recursive ���� false��, N���� �ڽ� ������Ʈ�� ������ ��� true�� �����Ѵ�.
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

    // [���� ������Ʈ ��ȯ]
    public static GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        Transform transform = FindChild<Transform>(go, name, recursive);
        if (transform != null)
            return transform.gameObject;
        
        return null;
    }
}