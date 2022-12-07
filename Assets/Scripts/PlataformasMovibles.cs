using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMovibles : MonoBehaviour
{
    public GameObject ObjetoAMover;

    public Transform StartPoint;
    public Transform EndPoint;

    public float _vel;

    private Vector3 Direccion;

    // Start is called before the first frame update
    void Start()
    {
        Direccion = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        ObjetoAMover.transform.position = Vector3.MoveTowards(ObjetoAMover.transform.position, Direccion, _vel * Time.deltaTime);

        if (ObjetoAMover.transform.position == EndPoint.position)
        {
            Direccion = StartPoint.position;
        }

        if (ObjetoAMover.transform.position == StartPoint.position)
        {
            Direccion = EndPoint.position;
        }

    }
}
