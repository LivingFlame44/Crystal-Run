using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneNavigator : MonoBehaviour
{
    public static int storyChecker = 0;
    public GameManager gameManager;
    public GameObject bibou;
    public GameObject spawner;
    public GameObject gameoverPanel;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject story;
    public GameObject mainMenu;
    public GameObject gamePanel;
   
    // Start is called before the first frame update
    void Start()
    {
        if (storyChecker == 0)
        {
            story.SetActive(true);
            mainMenu.SetActive(false);
            bibou.SetActive(false);
            spawner.SetActive(false);
        }
        else
        {
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonNext1()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }
    public void ButtonNext2()
    {
        page2.SetActive(false);
        page3.SetActive(true);
    }
    public void ButtonNext3()
    {
        page3.SetActive(false);
        mainMenu.SetActive(true);
        storyChecker += 1;
    }
    public void Play()
    {
        Time.timeScale = 1f;
        bibou.SetActive(true);
        spawner.SetActive(true);
        gamePanel.SetActive(true);
        gameoverPanel.SetActive(false);
        mainMenu.SetActive(false);
        GameManager.score = 0;
        bibou.transform.position = new Vector3(-1.35f, 0.46f, 0f);
    }

    public void Main()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
        
    public void Retry()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obj in allObjects)
        {
            Destroy(obj);
        }
        bibou.SetActive(true);
        spawner.SetActive(true);
        gamePanel.SetActive(true);
        gameoverPanel.SetActive(false);
        mainMenu.SetActive(false);
        GameManager.score = 0;
        bibou.transform.position = new Vector3(-1.35f, 0.46f, 0f);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
