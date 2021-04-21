using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Halaman : MonoBehaviour
{
    public string EnterScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SceneGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void SceneKeluar()
    {
        Application.Quit();
    }
}
