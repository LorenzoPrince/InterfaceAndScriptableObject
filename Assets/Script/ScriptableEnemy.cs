using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Scriptable Objects/ScriptableEnemy")]
public class ScriptableEnemy : ScriptableObject //Se utiliza para almacenar datos, util para compartir datos entre varias instancias.
{
    [SerializeField] private string nombre;
    [SerializeField] private string daño;
    [SerializeField] private string vida;

    public string Nombre { get { return nombre; } } //el get recordar que es para ver.
    public string Daño { get { return nombre; } }
    public string Vida { get { return nombre; } } 

    public void PrintDate()
    {
        Debug.Log(nombre);
        Debug.Log(daño);
        Debug.Log(vida);
    }
}
