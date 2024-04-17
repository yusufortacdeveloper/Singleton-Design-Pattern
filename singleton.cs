using UnityEngine;

public class MySingleton : MonoBehaviour
{
    private static MySingleton _instance;

    public static MySingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject singletonObject = new GameObject("MySingleton");
                _instance = singletonObject.AddComponent<MySingleton>();
                DontDestroyOnLoad(singletonObject);
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

   
}


// yusufortacdeveloper
