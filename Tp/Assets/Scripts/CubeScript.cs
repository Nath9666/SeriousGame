using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    [SerializeField] private Material cubeMaterial;
    private int counter = 0;

    void Start()
    {
        cubeMaterial = GetComponent<MeshRenderer>().material;
    }
    
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
        counter++;

        if(counter % 50 == 0) cubeMaterial.color = new Color(Random.Range(0, 255)/255f, Random.Range(0, 255)/255f, Random.Range(0, 255)/255f);
    }
}
