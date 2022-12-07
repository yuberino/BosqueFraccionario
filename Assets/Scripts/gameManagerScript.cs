using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject MenuPausa;

    public void BotonPausa()
    {
        MenuPausa.SetActive(true);
        Time.timeScale = 0;
    }

    public void BotonJugar()
    {
        MenuPausa.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            BotonPausa();
        }
    }
}
