using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public float force = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * force;
            GameObject gm = Instantiate(SoundManager.instance.PlayerFly);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
           
            GameManager.instance.isGameOver = true;
            GameManager.instance.gameOverPanel.SetActive(true);
            Time.timeScale = 0f;

            GameObject gm = Instantiate(SoundManager.instance.gameoversound);
            Destroy(gm, 1f);
        }
    }
}
