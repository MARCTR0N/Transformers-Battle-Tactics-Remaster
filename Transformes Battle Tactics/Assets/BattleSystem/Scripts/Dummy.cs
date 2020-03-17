using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Battle;

namespace Battle
{
    public class Dummy : MonoBehaviour
    {
        private Animator anim;
        private Rigidbody2D rb;
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
            
           
        }
       

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                anim.SetBool("isAttacking", true);
            }
            else
            {
                anim.SetBool("isAttacking", false);
            }

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                anim.SetBool("isDead", true);
            }

        }


    }
}