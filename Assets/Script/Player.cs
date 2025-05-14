using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float distanciaRayCast = 5f;
    [SerializeField] private float disntanciaOverlap = 2f;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            interactuarConObjecto();
        }
        if (Input.GetKey(KeyCode.E))
        {
            Atacar();
        }
        Caminar();
    }


    private void interactuarConObjecto()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distanciaRayCast);

        Debug.DrawRay(transform.position, Vector2.up * distanciaRayCast, Color.red);

        if (hit.collider.GetComponent<Iinteractuable>() != null) 
        {
            Debug.Log("Le pegue" + hit.collider.name);
            hit.collider.GetComponent<Iinteractuable>().Accion();
        }
        else
        {
            Debug.Log("No estoy intectuando con objectos");
        }
    }
    void Atacar()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, disntanciaOverlap);
        foreach (var hitCollider in hitColliders) //lo recorre
        {
            if (hitCollider.GetComponent<IReciboDaño>() != null)
            {
                Debug.Log("Le pegue" + hitCollider.name);
                hitCollider.GetComponent<IReciboDaño>().RecibirDaño(Dano);
            }
        }
    }
    void Caminar()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(Movimiento_X * velocidad, 0);
    }

}
