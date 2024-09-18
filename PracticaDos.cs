using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaDos : MonoBehaviour
{
    void Start()
    {
        // Generar tres números aleatorios entre -100 y 100
        int numero1 = UnityEngine.Random.Range(-100, 101);
        int numero2 = UnityEngine.Random.Range(-100, 101);
        int numero3 = UnityEngine.Random.Range(-100, 101);

        // Uso de la función
        var resultado = MinMax(numero1, numero2, numero3);
        Debug.Log(resultado);
    }

    string MinMax(int a, int b, int c)
    {
        Debug.Log($"Números generados: {a}, {b}, {c}");

        // Encontrar el mayor y el menor
        int mayor = Math.Max(a, Math.Max(b, c));
        int menor = Math.Min(a, Math.Min(b, c));

        Debug.Log($"El número mayor es: {mayor}, El número menor es: {menor}");

        // Verificar  mayor y menor fuera del rango
        if (mayor > 100)
        {
            return "Mayor fuera de rango";
        }

        
        if (menor < 0)
        {
            return "Menor fuera de rango";
        }

        // Calcular el promedio si ninguno de los valores está fuera del rango
        double promedio = (a + b + c) / 3.0;
        return $"El valor promedio es: {promedio}";
    }
}
