using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaControles()
    {
        SceneManager.LoadScene("Controls");
    }

    public void EscenaInfo()
    {
        SceneManager.LoadScene("Info");
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
