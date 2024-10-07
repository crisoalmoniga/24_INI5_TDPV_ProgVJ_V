using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjeto : MonoBehaviour
{

    [SerializeField] private GameObject objetoPrefab;

    [SerializeField]
    [Range((float)0.5, 5f)]
    private float tiempoEspera;

    private void Start()
    {
        Invoke("GenerarObjeto", tiempoEspera);
    }

    void GenerarObjeto()
    {
        Instantiate(objetoPrefab, transform.position, Quaternion.identity);
    }
}