using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    public Button buttonMenu;
    public Button buttonNextLevel;
    public Text text;
    private void Start()
    {
        buttonMenu.gameObject.SetActive(false);
        buttonNextLevel.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.color = new Color(0.05f, 0.16f, 0.79f);
            text.text = "������";
            buttonMenu.gameObject.SetActive(true);
            buttonNextLevel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void NextLevel(int level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
    }
}
