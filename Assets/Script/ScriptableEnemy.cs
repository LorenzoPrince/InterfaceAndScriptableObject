using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Scriptable Objects/ScriptableEnemy")]
public class ScriptableEnemy : ScriptableObject //Se utiliza para almacenar datos, util para compartir datos entre varias instancias.
{
    [SerializeField] private string nombre;
    [SerializeField] private int da�o;
    [SerializeField] private int vida;

    public string Nombre { get { return nombre; } } //el get recordar que es para ver.
    public int Da�o { get { return da�o; } }
    public int Vida { get { return vida; } } 

    public void PrintDate()
    {
        Debug.Log(nombre);
        Debug.Log(da�o);
        Debug.Log(vida);
    }
}
