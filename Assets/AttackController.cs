using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource attackSound;

    private bool _isAttack;

    public bool IsAttack { get => _isAttack; }


    public void FinishAttack()
    {
        _isAttack = false;
    }

    // private void Update() {
    //     if (Input.GetMouseButtonDown(0)) {
    //         Attack();
    //     }
    // }

    public void Attack()
    {
        _isAttack = true;
        animator.SetTrigger("attack");
        attackSound.Play();
    }

}
