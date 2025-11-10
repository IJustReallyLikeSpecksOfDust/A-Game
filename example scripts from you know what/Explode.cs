using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Important, if working with scenes you MUST include this.
using UnityEngine.UI;

public class Explode : MonoBehaviour
{
    private CapsuleCollider2D playerCollider;

    void Start()
    {
        // Get the CapsuleCollider2D component attached to the Player GameObject
        playerCollider = GetComponent<CapsuleCollider2D>(); //this might be redundant with my modifications but I got this working and I'm scared to change it more.
    }

    // This method is called when another Collider2D enters the trigger zone of this GameObject.
    void OnTriggerEnter2D(Collider2D target)
    {
        // Check if the entering GameObject has the "Deadly" tag

        if (target.gameObject.CompareTag("Deadly")){ //checks if the player is touching something deadly
            
            Destroy(gameObject); //Remove player from screen
            SceneManager.LoadScene("SplashScreen"); //sets the scene to the splash screen
        }
    }

    // This method is called when a collision with another Collider2D occurs.
    void OnCollisionEnter2D(Collision2D target)
    {
        // Check if the colliding GameObject has the "Deadly" tag
        if (target.gameObject.CompareTag("Deadly")){ //checks if the player is touching something deadly
            

            Destroy(gameObject); //Remove player from screen
            SceneManager.LoadScene("SplashScreen"); //sets the scene to the splash screen
        }
    }
}