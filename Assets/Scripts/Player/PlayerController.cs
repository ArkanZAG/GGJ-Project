using System.Collections;
using System.Collections.Generic;
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

    private string gameOverScene = "GameOverScene";
    
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRigidBody.velocity = new Vector2(horizontalInput * movementSpeed, playerRigidBody.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);
        }
    }

    public void TakeDamage(int damage)
    {
        healthBar.TakingDamage(damage);

        if (healthBar.GetCurrentValue() <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }

    private void CollectingCoins()
    {
        
    }
}
