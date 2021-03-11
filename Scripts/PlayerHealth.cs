using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] int health = 10;
    [SerializeField] int healthDecrease = 1;
    [SerializeField] Text healthText;
    [SerializeField] AudioClip playerDamageSFX;
    [SerializeField] Canvas gameOverCanvas;

    public bool IsGameOver;

    void Start()
    {
        healthText.text = health.ToString();
        gameOverCanvas.enabled = false;
        IsGameOver = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(playerDamageSFX);
        HandleLose();
    }

    private void HandleLose()
    {
        if (health > 0)
        {
            health -= healthDecrease;
            healthText.text = health.ToString();
        }
        else if (health <= 0)
        {
            IsGameOver = true;
            FindObjectOfType<Waypoint>().enabled = false;
            gameOverCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }

}
