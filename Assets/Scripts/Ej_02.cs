using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2.Solicitar el ingreso del precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
public class Ej_02 : MonoBehaviour
{
    public float pre1;
    public float pre2;
    public float pre3;
    public float monto;
    // Start is called before the first frame update
    void Start()
    {
        float precio;
        float final;
        precio=pre1+pre2+pre3;
        if (precio > monto)
        {
            Debug.Log("La suma de los precios de los productos es mayor a la del monto disponible.");
            final = precio - monto;
            Debug.Log("Te sobran " + final + " pesos.");
        } else if (precio == monto)
        {
            Debug.Log("El precio de los productos es igual a la del monto disponible");
        } else
        {
            Debug.Log("La suma de los precios de los productos es menor a la del monto disponible.");
            final = monto - precio;
            Debug.Log("Te faltan " + final + " pesos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
