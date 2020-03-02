using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private static ContinueAudio instance = null;
    public static ContinueAudio Instance
    {
        get { return Instance; }
    }

    void Awake()
    {
        if (instance!= null && instance!= this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
