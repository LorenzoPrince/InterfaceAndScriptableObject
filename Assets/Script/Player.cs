using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float distanciaRayCast = 5f;
    [SerializeField] private float disntanciaOverlap = 2f;
    [SerializeField] private int Dano = 10;
    public LayerMask layerMask; // Este será el LayerMask que define qué capas considerar
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            interactuarConObjecto();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Atacar();
        }
        Caminar();
    }


    private void interactuarConObjecto()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distanciaRayCast, ~layerMask);

        Debug.DrawRay(transform.position, Vector2.up * distanciaRayCast, Color.red, 0.1f);

        if (hit.collider != null)
        {
            Debug.Log("Raycast golpeó con: " + hit.collider.name + " en capa: " + LayerMask.LayerToName(hit.collider.gameObject.layer));

            Iinteractuable interactuable = hit.collider.GetComponent<Iinteractuable>();
            if (interactuable != null)
            {
                Debug.Log("Interacción con: " + hit.collider.name);
                interactuable.Accion();
            }
            else
            {
                Debug.Log("El objeto golpeado no tiene Iinteractuable");
            }
        }
        else
        {
            Debug.Log("Raycast no golpeó ningún objeto");
        }
    }

    void Atacar()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, disntanciaOverlap);
        foreach (var hitCollider in hitColliders) //lo recorre
        {
            if (hitCollider.GetComponent<IreciboDaño>() != null)
            {
                Debug.Log("Le pegue" + hitCollider.name);
                hitCollider.GetComponent<IreciboDaño>().RecibirDaño(Dano);

            }
        }
    }
    void Caminar()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");
        rb2d.linearVelocity = new Vector2(Movimiento_X * velocidad, 0);
    }

}
