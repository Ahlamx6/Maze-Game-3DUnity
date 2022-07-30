using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiccontrol : MonoBehaviour
{
    public static musiccontrol instance;

    private void awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
