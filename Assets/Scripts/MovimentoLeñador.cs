using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLeñador : MonoBehaviour
{

    public Rigidbody2D rbd;
    private BoxCollider2D bc2d;

    public LayerMask capaSuelo;

    private Animator anim;

    private SpriteRenderer spritePersonaje;
    public float fuerza;

    [SerializeField] private float _vel;

    void Start()
    {

        rbd = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Saltar

        if (Input.GetKeyDown(KeyCode.Space) && EstaEnSuelo())
        {
            Saltar();
        }



        //Caminar

        float velocidadInput = Input.GetAxisRaw("Horizontal");
        rbd.velocity = new Vector2(velocidadInput * _vel, rbd.velocity.y);
        anim.SetFloat("Camina", Mathf.Abs(velocidadInput));

        if (velocidadInput < 0)
        {

            spritePersonaje.flipX = true;

        }

        else if (velocidadInput > 0)
        {

            spritePersonaje.flipX = false;

        }

    }

    public void Saltar()
    {

        rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
    }

    bool EstaEnSuelo()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(bc2d.bounds.center, new Vector2(bc2d.bounds.size.x, bc2d.bounds.size.y), 0f, Vector2.down, 0.2f, capaSuelo);
        return raycastHit.collider != null;
    }
}
