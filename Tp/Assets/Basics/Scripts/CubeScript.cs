using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField]
    private int speed = 10;
    [SerializeField]
    private Material cubeMaterial;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        cubeMaterial = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
        counter++;
        if(counter % 50 == 0)
        {
            cubeMaterial.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
        }
    }
}
