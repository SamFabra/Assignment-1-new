using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenTest : MonoBehaviour
{
    public GameObject cube;

    public Animator animator;

    public Transform originPoint;
    public Transform endPoint; 
    private float desiredTime = 10f;

    [Range(0.0f, 10.0f)]
    public float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        LeanTween.moveX(gameObject, endPoint.position.x, 3).setEaseLinear().setLoopPingPong();
        LeanTween.moveY(gameObject, 4, 0.5f).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("ending squash and stretch");
        Debug.Log("enter");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("default");
        Debug.Log("exit");
    }




}
