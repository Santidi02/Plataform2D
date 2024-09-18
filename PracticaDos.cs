using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaDos : MonoBehaviour
{
    private int[] numeros = { 97, -64, -3, -58, -15, 58, 51, 38, -31, -37 };
    private float timer = 0f;
    private const float tiempoLimite = 4.5f;
    private bool arrayModificado = false;

    void Start()
    {
        // Generar tres números aleatorios entre -100 y 100
        int numero1 = UnityEngine.Random.Range(-100, 101);
        int numero2 = UnityEngine.Random.Range(-100, 101);
        int numero3 = UnityEngine.Random.Range(-100, 101);

        // Uso de la función MinMax
        var resultado = MinMax(numero1, numero2, numero3);
        Debug.Log(resultado);
    }

    void Update()
    {
        // Temporizador
        timer += Time.deltaTime;

        // Verifica si pasan 4.5 segundos 
        if (timer >= tiempoLimite && !arrayModificado)
        {
            ModificarArrayNumeros();
            arrayModificado = true; // Evita que se cambie mas de una vez
        }
    }

    string MinMax(int a, int b, int c)
    {
        Debug.Log($"Números generados: {a}, {b}, {c}");

        // Determina el mayor y el menor
        int mayor = Math.Max(a, Math.Max(b, c));
        int menor = Math.Min(a, Math.Min(b, c));

        Debug.Log($"El número mayor es: {mayor}, El número menor es: {menor}");

        // Comprueba mayor y menor fuera del rango
        if (mayor > 100)
        {
            return "Mayor fuera de rango";
        }
        if (menor < 0)
        {
            return "Menor fuera de rango";
        }

        // Calcula el promedio para ver si está fuera del rango
        double promedio = (a + b + c) / 3.0;
        return $"El valor promedio es: {promedio}";
    }

    void ModificarArrayNumeros()
    {
        // Analiza el array y duplica los números pares
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0) // Verificar si es par
            {
                numeros[i] *= 2; // Duplicar
            }
        }

        // Imprime el array en la consola con los numeros pares
        Debug.Log("Array modificado: " + string.Join(", ", numeros));
    }
}
