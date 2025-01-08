using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerceauGameManager : Singleton<CerceauGameManager>
{
    //public fields
    public Color currentGoodColor;
    public Color currentBadColor;

    //private Fields
    [SerializeField] private CerceauxManager cerceauxManager;
    [SerializeField] private List<Color> goodColors;
    [SerializeField] private List<Color> badColors;
    private float behaviorChangingInterval = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        InitGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitGame()
    {
        cerceauxManager.InstantiateCerceaux(8);
        StartCoroutine(SetBehaviors());
        GameUIController.Instance.InstanciateHealth(4);
    }

    private IEnumerator SetBehaviors()
    {
        while (true)
        {
            currentGoodColor = goodColors[Random.Range(0, goodColors.Count)];
            currentBadColor = badColors[Random.Range(0, badColors.Count)];
            cerceauxManager.SetCearceauxBehaviors(currentGoodColor, currentBadColor);
            yield return new WaitForSeconds(behaviorChangingInterval);
        }
    }
}
