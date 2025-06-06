using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public IUMANAGER uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<IUMANAGER>();
    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            //impedir la compra
            Debug.Log("Dinero insuficiente");
            return false;
        }
        else
        {
            money += amount; //se suma y se asigna +=
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }

        
    }

   
}
