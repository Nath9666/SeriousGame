using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerceauController : MonoBehaviour
{
    //Public Fields
    public CerceauBehaviour behaviour;

    //private Fields
    private Material cerceauMaterial;

    // Start is called before the first frame update
    private void Awake()
    {
        cerceauMaterial = GetComponent<MeshRenderer>().material;
    }
    void Start()
    {
        StartCoroutine(RandomMove());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * 50, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EFREIPlayer")
        {
            Debug.Log("Object detected");
        }
    }

    public IEnumerator RandomMove()
    {
        while (true)
        {
            Vector3 initialPostion = transform.position;
            Vector3 destinationPosition = new Vector3(Random.Range(-24, 24), 2.2f, Random.Range(-24, 24));
            float time = 0.0f;
            while(time <= 1.0f)
            {
                time += Time.deltaTime;
                transform.position = Vector3.Lerp(initialPostion, destinationPosition, time);
                yield return new WaitForSeconds(0.05f);
            }
        }
    }

    public void SetBehavior(CerceauBehaviour currentBehavior, Color behaviorColor)
    {
        Debug.Log("test");
        behaviour = currentBehavior;
        cerceauMaterial.color = behaviorColor;
    }
}

public enum CerceauBehaviour { good, bad}
