using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    public void loadFirstLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }
}
