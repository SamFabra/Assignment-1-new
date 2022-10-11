using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenTest : MonoBehaviour
{
    public Transform originPoint;
    public Transform endPoint; 
    private float desiredTime = 10f;

    [Range(0.0f, 10.0f)]
    public float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {

        //LeanTween.moveX(gameObject, endPoint.position.x, 3).setEaseInOutQuad().setLoopPingPong();
        LeanTween.moveY(gameObject, 4, 0.5f).setEaseLinear().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.smoothDeltaTime;
        float t = elapsedTime / desiredTime;

        transform.position = Vector3.Lerp(originPoint.position, endPoint.position, t);
        //transform.localScale = Vector3.Lerp(transform.localScale.z, transform.localScale.z / 2, t);
    }
}
