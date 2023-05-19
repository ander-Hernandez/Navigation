using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    private Animator animator;
    private bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        checkIfAttackHappening();
        Attack();
    }






    void Attack() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack 01");

        }
    
    }

    void checkIfAttackHappening() 
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack 01"))
        {
            Debug.Log("Attacking");
            attacking = true;
        } else
        {
            attacking = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject o = other.gameObject;
        if (o.GetComponent<Chase>() )
        {
            Debug.Log("true");
            Destroy(o);
        }


    }




}
