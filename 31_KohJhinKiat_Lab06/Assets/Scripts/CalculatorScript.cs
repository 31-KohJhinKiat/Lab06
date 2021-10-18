using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalculatorScript : MonoBehaviour
{
    public InputField InputAmount;
    public InputField InputValue;
    public float value;
    public Toggle KoreanWon;
    public Toggle TaiwanDollars;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calculate()
    {
        if(KoreanWon.isOn)
        {
            value = float.Parse(InputAmount.text) * 878.29f;
            InputValue.text = "$" + value;
        }

        if (TaiwanDollars.isOn)
        {
            value = float.Parse(InputAmount.text) * 20.74f;
            InputValue.text = "$" + value;
        }


    }

    public void clear()
    {
        SceneManager.LoadScene("GameScene");
    }

}
