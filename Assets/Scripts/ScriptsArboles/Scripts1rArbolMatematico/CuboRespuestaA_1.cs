using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboRespuestaA_1 : MonoBehaviour
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
            
            int respuestaCorrecta = GameObject.Find("ArbolMatematico1").GetComponent<ArbolMatematico1>().respuestaCorrecta;

            if (respuestaCorrecta == 1)
            {
                GameObject ArbolCaido = Instantiate(_prefabArbolCaido);
                ArbolCaido.transform.position = _posicionArbolCaidoSpawn.transform.position;

                GameObject BanderaBlanca = Instantiate(_prefabBanderaBlancaCheckpoint);
                BanderaBlanca.transform.position = _posicionBanderaBlancaSpawn.transform.position;

                GameObject Arbre = GameObject.Find("ArbolMatematico1");
                Destroy(Arbre);
                respuestaCorrecta = 0;
                
            } else {
                
                GameObject.Find("ArbolMatematico1").GetComponent<ArbolMatematico1>().Inicialitzar();
                respuestaCorrecta = 0;
                Destroy(GameObject.FindWithTag("Operacion1"));
                GameObject.Find("Leñador").transform.position = new Vector3(-7.5f, 0.3f, 0);
                GameObject.Find("Leñador").GetComponent<MovimentoLeñador>().vida--;
            }
           
        }

    }
}
