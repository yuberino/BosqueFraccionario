using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboVisualizarControles : MonoBehaviour
{

    public GameObject _posicionPizarraSpawn;
    public GameObject _prefabPizarra;

    public GameObject _BloqueAyuda;

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
        //Si el jugador colisiona con un objeto con la etiqueta ayuda
        if (col.gameObject.CompareTag("Leñador"))
        {

            GameObject pizarra = Instantiate(_prefabPizarra);
            pizarra.transform.position = _posicionPizarraSpawn.transform.position;

            Destroy(_BloqueAyuda);

        }



    }


}

