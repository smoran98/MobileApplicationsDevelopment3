using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Animations - couple of parts
 * GameObject that is going to be animated
 *      attach an Animator component
 *          that is going to control the animations 
 *          throught the Animator Controller
 *  Create an Animator Controller - which is attached to the 
 *          Animator Component
 *  Create the animation - Walk, Jump, Run, Shoot
 *      Attach these to the Animator Controlle
 */

public class Enemy : MonoBehaviour
{
    // == fields ==
    private float speed = 1.0f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void SetMoveSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

}
