using UnityEngine;

public class Enemy : MonoBehaviour, Iinteractuable, IreciboDaño
{
    [SerializeField] private ScriptableEnemy enemyData;

    public string Nombre;
    public int vida;
    public int dano;
   // private Animator anim;

    void Start()
    {
        // Nunca modificar directamente el ScriptableObject en tiempo de ejecución
        //anim = GetComponent<Animator>();
        Nombre = enemyData.Nombre;
        vida = enemyData.Vida;
        dano = enemyData.Daño;
    }
    public void Accion()
    {
        enemyData.PrintDate();
        Debug.Log(Nombre + vida + dano);
    }
    public void RecibirDaño(int dmg)
    {
        vida -= dmg;
        Debug.Log(Nombre + " recibió " + dmg + " de daño. Vida restante: " + vida);
        if (vida <= 0)
        {        
            Muerte();
            //anim.Play("Muerte");
        }
    }
    public void Muerte()
    {
        Destroy(this.gameObject);
    }


}
