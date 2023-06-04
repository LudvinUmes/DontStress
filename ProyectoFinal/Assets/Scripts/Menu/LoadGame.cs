using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public GameObject PantallaDeCarga;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGames(int NumeroDeEscena)
    {
        StartCoroutine(CargarAsync(NumeroDeEscena));

    }

    IEnumerator CargarAsync(int NumeroDeEscena)
    {
        AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);
        PantallaDeCarga.SetActive(true);
        while (!Operacion.isDone)
        {
            float Progreso = Mathf.Clamp01(Operacion.progress/ .9f);
            slider.value = Progreso;
            yield return null;
        }
    }
}
