using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverArm : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    private Finish _finish;

    void Start() {
        _finish = GameObject.FindGameObjectWithTag("Finish").GetComponent<Finish>();
    }

    public void ActivateLeverArm() {
        animator.SetTrigger("activate");
        _finish.Activate();
    }
}
