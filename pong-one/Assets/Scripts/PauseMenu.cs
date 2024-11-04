using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Button restartButton;
    public Button menuButton;
    public Button resumeButton;
    public GameObject PMenu;
    public AudioSource OddEO;
    public AudioClip SFClick;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(Restart);
        menuButton.onClick.AddListener(MainMenu);
        resumeButton.onClick.AddListener(Resume);
    }
  void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PMenu.activeInHierarchy)
            {
                OddEO.clip = SFClick;
                OddEO.Play();
                Pause();
            }
            else
            {
                OddEO.clip = SFClick;
                OddEO.Play();
                Resume();
            }
        }
    }
        public void Pause()
    {
        Time.timeScale = 0;
        PMenu.SetActive(true);
    }
    public void Resume()
    {
        OddEO.clip = SFClick;
        OddEO.Play();
        Time.timeScale = 1;
        PMenu.SetActive(false);
    }
        public void MainMenu()
    {
        OddEO.clip = SFClick;
        OddEO.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
        public void Restart()
    {
        OddEO.clip = SFClick;
        OddEO.Play();
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene);
    }
}
