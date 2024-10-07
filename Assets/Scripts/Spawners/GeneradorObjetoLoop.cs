using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetoLoop : MonoBehaviour
{

    [SerializeField] private GameObject objetoPrefab;

    [SerializeField]
    [Range((float)0.5, 5f)]
    private float tiempoEspera;

    [SerializeField]
    [Range((float)0.5, 5f)]
    private float tiempoIntervalo;

    private void Start()
    {
        InvokeRepeating(nameof(GenerarObjetoLoop), tiempoEspera, tiempoIntervalo);
    }

    void GenerarObjetoLoop()
    {
        Instantiate(objetoPrefab, transform.position, Quaternion.identity);
    }
}