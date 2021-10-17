using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testpath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.dataPath);
        var st = Application.dataPath;
        var newst = st.Remove(st.Length - 6);
        
        Debug.Log(newst);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
