using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Scriptable Objects/ScriptableEnemy")]
public class ScriptableEnemy : ScriptableObject //Se utiliza para almacenar datos, util para compartir datos entre varias instancias.
{
    [SerializeField] private string nombre;
    [SerializeField] private string da�o;
    [SerializeField] private string vida;

    public string Nombre { get { return nombre; } } //el get recordar que es para ver.
    public string Da�o { get { return nombre; } }
    public string Vida { get { return nombre; } } 

    public void PrintDate()
    {
        Debug.Log(nombre);
        Debug.Log(da�o);
        Debug.Log(vida);
    }
}
