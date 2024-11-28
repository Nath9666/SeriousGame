using System.Collections;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cylinder;

    private Material cubeMaterial;
    private Material sphereMaterial;
    private Material cylinderMaterial;

    private int speed = 10;
    private int counter = 0;
    private bool isCubeRotating = false;
    private bool isSpehereRotating = false;
    private bool isCylinderRotating = false;


    // Start is called before the first frame update
    void Start()
    {
        cubeMaterial = cube.GetComponent<MeshRenderer>().material;
        sphereMaterial = sphere.GetComponent<MeshRenderer>().material;
        cylinderMaterial = cylinder.GetComponent<MeshRenderer>().material;
        
        StartCoroutine(ManageObject());
    }

    // Update is called once per frame
    void Update()
    {
        if(isCylinderRotating) cylinder.transform.Rotate(speed * Time.deltaTime, 0, 0);
        if(isCubeRotating) cube.transform.Rotate(0, speed * Time.deltaTime, 0);
        if(isSpehereRotating) sphere.transform.Rotate(0, 0, speed * Time.deltaTime);

        counter ++;

        if(counter % 100 == 0) 
        {
            cubeMaterial.color = new Color(Random.Range(0, 255)/255f, Random.Range(0, 255)/255f, Random.Range(0, 255)/255f);
            sphereMaterial.color = new Color(Random.Range(0, 255)/255f, Random.Range(0, 255)/255f, Random.Range(0, 255)/255f);
            cylinderMaterial.color = new Color(Random.Range(0, 255)/255f, Random.Range(0, 255)/255f, Random.Range(0, 255)/255f);
        }
    }

    private IEnumerator ManageObject()
    {
        yield return ManageObjectWithConditions();
        while(true)
        {
            isCubeRotating = true;
            yield return new WaitForSeconds(3.0f);
            isCubeRotating = false;
            isSpehereRotating = true;
            yield return new WaitForSeconds(3.0f);
            isSpehereRotating = false;
            isCylinderRotating = true;
            yield return new WaitForSeconds(3.0f);
            isCylinderRotating = false;
        }
    }

    private IEnumerator ManageObjectWithConditions()
    {
        isCubeRotating = true;
        yield return new WaitUntil(() => cube.activeSelf == false);
        isCubeRotating = false;
        isSpehereRotating = true;
        yield return new WaitForSeconds(3.0f);
        isSpehereRotating = false;
        isCylinderRotating = true;
        yield return new WaitForSeconds(3.0f);
        isCylinderRotating = false;
    }
}
