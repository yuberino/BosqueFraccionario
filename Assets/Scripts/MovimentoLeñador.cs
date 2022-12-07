using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentoLeñador : MonoBehaviour
{

    public Rigidbody2D rbd;
    private BoxCollider2D bc2d;

    private Animator anim;

    private SpriteRenderer spritePersonaje;
    public float fuerzaSalto;

    [SerializeField] private float _velLeñador;

    public bool NoEstaEnSuelo = false;

    public GameObject Leñador;

    public GameObject _prefabFondo;

    public double contadorSpawnFondo = 21.5;
    public GameObject _triggerSpawnearFondo;

    public GameObject[] corazones;
    public int vida;

    public float PosicionXResucitarLeñador = -7.5f;
    public float PosicionYResucitarLeñador = 0.3f;

    void Start()
    {

        vida = 3;

        rbd = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Saltar

        if (Input.GetKeyDown(KeyCode.Space) && !NoEstaEnSuelo)
        {
            rbd.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

            NoEstaEnSuelo = true;
        }

        //Caminar

        float velocidadInput = Input.GetAxisRaw("Horizontal");
        rbd.velocity = new Vector2(velocidadInput * _velLeñador, rbd.velocity.y);
        anim.SetFloat("Camina", Mathf.Abs(velocidadInput));

        if (velocidadInput < 0)
        {

            spritePersonaje.flipX = true;

        }

        else if (velocidadInput > 0)
        {

            spritePersonaje.flipX = false;

        }

        //Vida

        if (vida < 1)
        {
            Destroy(corazones[0].gameObject);
            SceneManager.LoadScene("MenuPrincipal");
        }
        else if (vida < 2)
        {
            Destroy(corazones[1].gameObject);
        }
        else if (vida < 3)
        {
            Destroy(corazones[2].gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
{
    //Si el leñador colisiona con el suelo, podrá saltar.
    if (other.gameObject.CompareTag("Suelo"))
    {
        NoEstaEnSuelo = false;

        rbd.velocity = new Vector2(rbd.velocity.x, 0);
    }

    //Si el leñador esta en una plataforma movible, el se movera con la plataforma
    if (other.gameObject.CompareTag("PlataformaMovible"))
    {
        transform.parent = other.transform;
    }

}

    private void OnCollisionExit2D(Collision2D other)
{
    //Si el leñador NO esta en una plataforma movible, el se movera con la plataforma
    if (other.gameObject.CompareTag("PlataformaMovible"))
    {
        transform.parent = null;
    }

}

private void OnTriggerEnter2D(Collider2D col)
{
    //Si el leñador toca el trigger de las plataformas, saltará.
    if (col.gameObject.CompareTag("Plataforma"))
    {
        NoEstaEnSuelo = false;

        rbd.velocity = new Vector2(rbd.velocity.x, 0);
        
    } 

    //Si leñador toca el trigger, no saltará
    if (col.gameObject.CompareTag("TriggerNoSaltar"))
    {
        NoEstaEnSuelo = true;
    }

    //Si leñador toca el trigger de algún pincho o enemigo, morirá y volvera al principio del nivel.
    if (col.gameObject.CompareTag("TocaEnemigoOPincho"))
    {
        Leñador.transform.position = new Vector3(PosicionXResucitarLeñador, PosicionYResucitarLeñador, 0);
        vida--;
    }

    //Si el trigger de spawnear fondo no está inicializado, que vuelva a tenerlo.
    if (_triggerSpawnearFondo == null)
    {
        _triggerSpawnearFondo = GameObject.FindGameObjectWithTag("SpawnearSiguienteFondo");
    }

    if (col.gameObject.CompareTag("SpawnearSiguienteFondo"))
    {
        GameObject Fondo = Instantiate(_prefabFondo);
        Fondo.transform.position = new Vector3((((float)contadorSpawnFondo)), 0, 0);
        contadorSpawnFondo = contadorSpawnFondo + 21.5;

        //Una vez spawneado el trigger se destruirá para que no se repita.
        Destroy(_triggerSpawnearFondo);
        
    }
    
}

}