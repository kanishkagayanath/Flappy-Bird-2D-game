using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float timer = 0;
    public bool isGameOver = false;
    public static GameManager instance;
    public GameObject gameOverPanel;


    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        isGameOver = false;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }


    private void Update()
    {


        if (timer <= 0f)
        {
            if (isGameOver == false)
            {


                GameObject gm = Instantiate(obstaclePrefab, new Vector3(5f, Random.Range(-3f, 0), 0f), Quaternion.identity);
                Destroy(gm, 5f);
                timer = 2f;
            }
        }
        else
        {
            timer -= Time.deltaTime;

        }
    }
    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

   
