using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    private Animator animator;

    public AudioManager audioManager;
    public VFXManager vFXManager;
    public ScoreManager scoreManager;

    private void Start()
    {
        //GetComponent<Renderer>().material.color = color;
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity  *= multiplier;

            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position);
            vFXManager.PlayVFX(collision.transform.position);

            scoreManager.AddScore(score);
        }
    }
}
