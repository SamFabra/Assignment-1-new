using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenTest : MonoBehaviour
{
    public GameObject cube;

    public Animator animator;

    public Transform originPoint;
    public Transform endPoint; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Lerp and Easing
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
        StartCoroutine(StopAnim());
    }

    IEnumerator StopAnim()
    {
        yield return new WaitForSeconds(1);
        animator.Play("default");
        Debug.Log("exit");
    }



}
