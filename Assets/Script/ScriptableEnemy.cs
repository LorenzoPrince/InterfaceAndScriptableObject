using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Scriptable Objects/ScriptableEnemy")]
public class ScriptableEnemy : ScriptableObject //Se utiliza para almacenar datos, util para compartir datos entre varias instancias.
{
    [SerializeField] private string nombre;
    [SerializeField] private int daño;
    [SerializeField] private int vida;

    public string Nombre { get { return nombre; } } //el get recordar que es para ver.
    public int Daño { get { return daño; } }
    public int Vida { get { return vida; } } 

    public void PrintDate()
    {
        Debug.Log(nombre);
        Debug.Log(daño);
        Debug.Log(vida);
    }
}
