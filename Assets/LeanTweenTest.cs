using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveX(gameObject, 5, 3).setEaseInOutBack().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
