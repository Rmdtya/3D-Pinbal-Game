using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIContoller : MonoBehaviour
{
    public Button backMenu;
    // Start is called before the first frame update
    void Start()
    {
        backMenu.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    public void MainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }
}
