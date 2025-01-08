using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUIController : Singleton<GameUIController>
{
    [SerializeField] private TextMeshProUGUI Scoretext;
    [SerializeField] private Image goodColorImage;
    [SerializeField] private GameObject HealthPanel;
    [SerializeField] private Image HealthImage;
    private int InitialHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int score)
    {
        Scoretext.text = score.ToString();
    }

    public void SetGoodColor(Color color)
    {
        goodColorImage.color = color;
    }

    public void SetHealth(int health)
    {
        for (int i = 0; i < InitialHealth - health; i++)
        {
            HealthPanel.transform.GetChild(i).gameObject.GetComponent<Image>().color = new Color(0, 0, 0, 0.2f);
        }
    }

    public void InstanciateHealth(int health)
    {
        for (int i = 0; i < health; i++)
        {
            Instantiate(HealthImage, HealthPanel.transform);
            HealthImage.color = Color.green;
        }

        InitialHealth = health;
    }
}
