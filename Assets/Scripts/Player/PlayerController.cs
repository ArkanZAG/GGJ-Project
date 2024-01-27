using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidBody;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private Collectible collectible;
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip walkAudioClip;
    [SerializeField] private AudioClip jumpAudioClip;
    
    
    private string gameOverScene = "GameOver";
    private bool isGrounded;
    
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRigidBody.velocity = new Vector2(horizontalInput * movementSpeed, playerRigidBody.velocity.y);

        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
            audioSource.PlayOneShot(walkAudioClip);
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            audioSource.PlayOneShot(walkAudioClip);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            this.transform.DOScaleY(0.5f, 0.1f);
        }
        else if (Input.GetKeyUp(KeyCode.Space) && isGrounded)
        {
            Jump();
            audioSource.clip = jumpAudioClip;
            audioSource.Play();
            this.transform.DOScaleY(1f, 0.1f);
        }
        
        playerAnimator.SetBool("isRunning", horizontalInput != 0);
        playerAnimator.SetBool("isGrounded", isGrounded);
    }

    public void TakeDamage(int damage)
    {
        healthBar.TakingDamage(damage);
        this.transform.DOShakeScale(0.5f, new Vector3(2, 2, 2), 10, 45f, false, ShakeRandomnessMode.Full);

        if (healthBar.GetCurrentValue() <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }

    private void Jump()
    {
        playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, jumpHeight);
        playerAnimator.SetTrigger("Jump");
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
