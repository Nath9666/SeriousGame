using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CerceauManager : MonoBehaviour
{
    [SerializeField] private GameObject Cerceau;
    [SerializeField] private int positionMax = 24;
    [SerializeField] private int number = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InstantiateCerceau(number);
    }

    private void InstantiateCerceau(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Vector3 position = new Vector3(Random.Range(positionMax*-1, positionMax), 2.2f, Random.Range(positionMax*-1, positionMax));
            Quaternion rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, Random.Range(0, 360), 90);
            // Instantiate the Cerceau GameObject at the position of the Cerceau GameObject
            Instantiate(Cerceau, position, rotation, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
