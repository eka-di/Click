using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public int money;
    public TMP_Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
    }
    public void ButtonClick()
    {
        money++;
        PlayerPrefs.SetInt("money", money);
    }

    public void ToTask() 
    {
        SceneManager.LoadScene(1);
    }
    public void ToShop()
    {
        SceneManager.LoadScene(2);
    }

    void Update()
    {
        moneyText.text = money +"";
    }
}
