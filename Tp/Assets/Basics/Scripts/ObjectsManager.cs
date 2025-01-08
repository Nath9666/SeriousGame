using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    [SerializeField] private GameObject Sphere;
    [SerializeField] private GameObject Cylinder;
    [SerializeField] private int speed = 100;
    int counter = 0;
    private Material cubeMaterial;
    private Material sphereMaterial;
    private Material cylinderMaterial;
    private bool isCubeRotating = false;
    private bool isSphereRotating = false;
    private bool isCylinderRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        cubeMaterial = Cube.GetComponent<MeshRenderer>().material;
        sphereMaterial = Sphere.GetComponent<MeshRenderer>().material;
        cylinderMaterial = Cylinder.GetComponent<MeshRenderer>().material;
        //Cube = GameObject.Find("Cube");
        StartCoroutine(ManageObjects());
    }

    // Update is called once per frame
    void Update()
    {
        if(isCubeRotating)
            Cube.transform.Rotate(0, speed * Time.deltaTime, 0);
        
        if(isSphereRotating)
            Sphere.transform.Rotate(speed * Time.deltaTime, 0, 0);

        if(isCylinderRotating)
            Cylinder.transform.Rotate(0, 0, speed * Time.deltaTime);

        counter++;
        if(counter % 100 == 0)
        {
            cubeMaterial.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
            sphereMaterial.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
            cylinderMaterial.color = new Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f);
        }
    }

    private IEnumerator ManageObjects()
    {
        yield return ManageObjectsWithConditions();
        //StartCoroutine(ManageObjectsWithConditions());
        while (true)
        {
            isCubeRotating = true;
            yield return new WaitForSeconds(3.0f);
            isCubeRotating = false;
            isSphereRotating = true;
            yield return new WaitForSeconds(3.0f);
            isSphereRotating = false;
            isCylinderRotating = true;
            yield return new WaitForSeconds(3.0f);
            isCylinderRotating = false;
        }
    }

    private IEnumerator ManageObjectsWithConditions()
    {
        isCubeRotating = true;
        yield return new WaitUntil(() => Cube.activeSelf == false);
        isCubeRotating = false;
        isSphereRotating = true;
        yield return new WaitForSeconds(3.0f);
        isSphereRotating = false;
        isCylinderRotating = true;
        yield return new WaitForSeconds(3.0f);
        isCylinderRotating = false;
    }
}
