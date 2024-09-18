using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaDos : MonoBehaviour
{
    void Start()
    {
        // Ejemplo de uso
        var resultado = MinMax(10, 20, 30);
        Debug.Log(resultado);
    }

    string MinMax(int a, int b, int c)
    {
        Debug.Log($"Números generados: {a}, {b}, {c}");

        // Encontrar el mayor y el menor
        int mayor = Math.Max(a, Math.Max(b, c));
        int menor = Math.Min(a, Math.Min(b, c));

        Debug.Log($"El número mayor es: {mayor}, El número menor es: {menor}");

        // Verificar si el mayor está fuera del rango
        if (mayor > 100)
        {
            return "Mayor fuera de rango";
        }

        // Verificar si el menor está fuera del rango
        if (menor < 0)
        {
            return "Menor fuera de rango";
        }

        // Calcular el promedio si ninguno de los valores está fuera del rango
        double promedio = (a + b + c) / 3.0;
        return $"El valor promedio es: {promedio}";
    }
}
