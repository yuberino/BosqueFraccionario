using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboRespuesta2 : MonoBehaviour
{
    public GameObject _prefabArbolCaido;
    public GameObject _posicionArbolCaidoSpawn;

    public GameObject _prefabBanderaBlancaCheckpoint;
    public GameObject _posicionBanderaBlancaSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Si el jugador colisiona amb el cub 1
        if (col.gameObject.CompareTag("Leñador"))
        {
            
            int respuestaCorrecta = GameObject.Find("ArbolMatematico").GetComponent<Operaciones>().respuestaCorrecta;

            if (respuestaCorrecta == 2)
            {
                GameObject ArbolCaido = Instantiate(_prefabArbolCaido);
                ArbolCaido.transform.position = _posicionArbolCaidoSpawn.transform.position;

                GameObject BanderaBlanca = Instantiate(_prefabBanderaBlancaCheckpoint);
                BanderaBlanca.transform.position = _posicionBanderaBlancaSpawn.transform.position;

                GameObject Arbre  = GameObject.Find("ArbolMatematico");
                Destroy(Arbre);
                respuestaCorrecta = 0;
                
            } else {
                
                GameObject.Find("ArbolMatematico").GetComponent<Operaciones>().Inicialitzar();
                respuestaCorrecta = 0;
                Destroy(GameObject.FindWithTag("Operacion"));
                GameObject.Find("Leñador").transform.position = new Vector3(-7.5f, 0.3f, 0);
                GameObject.Find("Leñador").GetComponent<MovimentoLeñador>().vida--;
            }
           
        }

    }
}