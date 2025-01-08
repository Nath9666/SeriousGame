using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerceauxManager : MonoBehaviour
{
    [SerializeField] private GameObject Cerceau;
    public List<CerceauController> CerceauControllers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateCerceaux(int number)
    {
        for(int i=0; i < number; i++)
        {
            Vector3 cerceauPosition = new Vector3(Random.Range(-24, 24), 2.2f, Random.Range(-24, 24));
            Quaternion cerceauRotation = new Quaternion();
            cerceauRotation.eulerAngles = new Vector3(0, Random.Range(0, 360), 90);
            GameObject cerceau = Instantiate(Cerceau, cerceauPosition, cerceauRotation, transform);
            CerceauControllers.Add(cerceau.GetComponent<CerceauController>());
        }
    }

    public void SetCearceauxBehaviors(Color goodColor, Color badColor)
    {
        for(int i = 0; i < CerceauControllers.Count; i++)
        {
            int behaviorNumber = Random.Range(0, 2);
            switch (behaviorNumber)
            {
                case 0:
                    CerceauControllers[i].SetBehavior(CerceauBehaviour.good, goodColor);
                    break;
                case 1:
                    CerceauControllers[i].SetBehavior(CerceauBehaviour.bad, badColor);
                    break;
                default:
                    CerceauControllers[i].SetBehavior(CerceauBehaviour.good, goodColor);
                    break;
            }
        }
    }
}
