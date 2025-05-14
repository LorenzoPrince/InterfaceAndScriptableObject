using UnityEngine;

public class Enemy : MonoBehaviour, Iinteractuable, IreciboDa�o
{
    [SerializeField] private ScriptableEnemy enemyData;

    public string Nombre;
    public int vida;
    public int dano;
   // private Animator anim;

    void Start()
    {
        // Nunca modificar directamente el ScriptableObject en tiempo de ejecuci�n
        //anim = GetComponent<Animator>();
        Nombre = enemyData.Nombre;
        vida = enemyData.Vida;
        dano = enemyData.Da�o;
    }
    public void Accion()
    {
        enemyData.PrintDate();
        Debug.Log(Nombre + vida + dano);
    }
    public void RecibirDa�o(int dmg)
    {
        vida -= dmg;
        Debug.Log(Nombre + " recibi� " + dmg + " de da�o. Vida restante: " + vida);
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
