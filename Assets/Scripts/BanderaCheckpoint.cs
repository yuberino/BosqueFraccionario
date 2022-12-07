using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanderaCheckpoint : MonoBehaviour
{

    public GameObject _prefabBanderaRojaCheckpoint;
    public GameObject _BanderaBlancaCheckpoint;

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
        if (col.gameObject.CompareTag("Leñador"))
    {
            GameObject BanderaRoja = Instantiate(_prefabBanderaRojaCheckpoint);
            BanderaRoja.transform.position = _BanderaBlancaCheckpoint.transform.position;

            GameObject.Find("Leñador").GetComponent<MovimentoLeñador>().PosicionXResucitarLeñador = BanderaRoja.transform.position.x;
            GameObject.Find("Leñador").GetComponent<MovimentoLeñador>().PosicionYResucitarLeñador = BanderaRoja.transform.position.y;

            Destroy(_BanderaBlancaCheckpoint);
    }
    }
}
