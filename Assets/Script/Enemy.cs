using UnityEngine;

public class Enemy : MonoBehaviour, Iinteractuable, IreciboDaño
{
    public string Nombre;
    public int vida;
    public int dano;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Accion()
    {
        Debug.Log(Nombre + vida + dano);
    }
    public void RecibirDaño(int dmg)
    {
        vida -= dmg;
        if (vida <= 0)
        {
            anim.Play("Muerte");
        }
    }
    public void Muerte()
    {
        Destroy(this.gameObject);
    }


}
