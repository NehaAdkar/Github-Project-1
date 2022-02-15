using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MainManager Instance;
    public Color TeamColor;

    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(gameObject);
            return;
        }

        Instance=this;
        DontDestroyOnLoad(gameObject);
    }

}